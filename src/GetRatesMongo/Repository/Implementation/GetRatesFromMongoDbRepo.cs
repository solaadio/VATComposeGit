using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Authentication;
using System.Threading.Tasks;
using Microsoft.Azure.KeyVault;
using Microsoft.Azure.KeyVault.Models;
using Microsoft.Azure.Services.AppAuthentication;
using Models;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using Repository.Interfaces;

namespace Repository.Implementation
{
    public class GetRatesFromMongoDbRepo : IGetRatesRepository
    {
        public  async Task<List<CountryRates>> GetReturnRates()
        {
            string connectionString = string.Empty;
            try
            {
                connectionString = await GetCredentialsAsync();
            }
            catch
            {
                HttpClient myHttpClient = new HttpClient
                {
                    BaseAddress = new Uri(
                        "http://getrates/VATToolBox/GetRates")
                };
                var response = await myHttpClient.GetAsync("http://getrates/VATToolBox/GetRates");

                var stringContent = await response.Content.ReadAsStringAsync();

                var responseObject = JsonConvert.DeserializeObject<List<CountryRates>>(stringContent);

                return responseObject;
            }

            MongoClientSettings settings = MongoClientSettings.FromUrl(
              new MongoUrl(connectionString)
            );
            settings.SslSettings =
              new SslSettings { EnabledSslProtocols = SslProtocols.Tls12 };
            var mongoClient = new MongoClient(settings);

            var db = mongoClient.GetDatabase("vat");
            
            IMongoCollection<RatesBson> col = db.GetCollection<RatesBson>("rates");

            
            //           var res = await col.Find(new BsonDocument("version",3.51)).SortByDescending(x => x.Version).Limit(1).FirstAsync();
            RatesBson res = await col.Find(new BsonDocument("version", 3.51)).FirstAsync();

            return res.Rates;
        }

        private async Task<string> GetCredentialsAsync()
        {
            try
            {
                /* The next four lines of code show you how to use AppAuthentication library to fetch secrets from your key vault */
                AzureServiceTokenProvider azureServiceTokenProvider = new AzureServiceTokenProvider();
                KeyVaultClient keyVaultClient = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(azureServiceTokenProvider.KeyVaultTokenCallback));
                var secret = await keyVaultClient.GetSecretAsync("https://vtlogionvault.vault.azure.net/secrets/cosmosDB/7569b86d2ded4e65a377d84601182ae9")
                        .ConfigureAwait(false);
               return secret.Value;
            }
            /* If you have throttling errors see this tutorial https://docs.microsoft.com/azure/key-vault/tutorial-net-create-vault-azure-web-app */
            /// <exception cref="KeyVaultErrorException">
            /// Thrown when the operation returned an invalid status code
            /// </exception>
            catch (KeyVaultErrorException)
            {
                throw;
            }
        }
    }
}