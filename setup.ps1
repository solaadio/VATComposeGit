$name = "iyabo"
$rg = "rg" + $name
$location = "westeurope"
$acr = "acr" + $name
$aks = "aks" +$name
$subscriptionId = "cb5ab4a7-dd08-4be3-9d7e-9f68ae30f224"
$kubeVersion = "1.14.8"
$nodeVMSize = "Standard_B2s"

$appDisplayName="MyAKSApp"
$tenant="2107104e-d4f3-468b-9202-8451051cc80a"
$homePage = "http://" + $tenant + "/$appDisplayName"
$identifierUri = $homePage
$spnRole = "Contributor"
$appPassword="e32d5baa-5c26-4947-a797-43507b5e2f42"
$appSPDisplayName=$appDisplayName+"ServicePrincipal"

#Initialize subscription
$isAzureModulePresent = Get-Module -Name Az* -ListAvailable
if ([String]::IsNullOrEmpty($isAzureModulePresent) -eq $true)
{
    Write-Output "Script requires AzureRM modules. Obtain from https://github.com/Azure/azure-powershell/releases." -Verbose
    return
}

#Check if AD Application Identifier URI is unique
Write-Output "Verifying App URI is unique ($identifierUri)" -Verbose
$existingApplication = Get-AzADApplication -IdentifierUri $identifierUri
if ($null -ne $existingApplication) {
    $appId = $existingApplication.ApplicationId
    Write-Output "An AAD Application already exists with App URI $identifierUri (Application Id: $appId). Choose a different app display name"  -Verbose
    return
}

#Create a new AD Application
Write-Output "Creating a new Application in AAD (App URI - $identifierUri)" -Verbose
$secureAppPassword = $appPassword | ConvertTo-SecureString -AsPlainText -Force
$azureAdApplication = New-AzADApplication -DisplayName $appDisplayName -HomePage $homePage -IdentifierUris $identifierUri -Password $secureAppPassword -Verbose
$appId = $azureAdApplication.ApplicationId
Write-Output "Azure AAD Application creation completed successfully (Application Id: $appId)" -Verbose

#Create new SPN
Write-Output "Creating a new SPN" -Verbose
$spn = New-AzADServicePrincipal -ApplicationId $appId -Role $spnRole -DisplayName $appSPDisplayName
$spnName = $spn.DisplayName
Write-Output "SPN creation completed successfully (SPN Name: $spnName)" -Verbose


Import-Module -Name Az.Accounts
Write-Output "Provide your credentials to access Azure subscription $subscriptionId" -Verbose
Login-AzAccount -SubscriptionId $subscriptionId
$azureSubscription = Get-AzSubscription -SubscriptionId $subscriptionId
$connectionName = $azureSubscription.Id

Set-AzContext -Subscription $connectionName

# Create a resource group $rg on a specific location $location (for example eastus) which will contain the Azure services we need 
Write-Output "Creating new resource group: $rg" -Verbose
New-AzResourceGroup `
  -Name $rg `
  -Location $location
Write-Output "New resource group: $rg created" -Verbose

Write-Output "deleting service principal file" -Verbose
rm ~/.azure/acsServicePrincipal.json
Write-Output "service principal file deleted" -Verbose

Write-Output "Creating new storage account" 
$storageAccount = New-AzStorageAccount `
  -ResourceGroupName $rg `
  -Name "$name$(Get-Random)" `
  -Location $location `
  -SkuName Standard_LRS `
  -Kind StorageV2
Write-Output "New storage account: ($storageAccount.StorageAccountName) created" 

Write-Output "Creating new file share" -Verbose
$fileShare = New-AzStorageShare `
  -Name "$name$(Get-Random)" `
  -Context $storageAccount.Context
Write-Output "New file share: ($fileShare) created" -Verbose


# Create an ACR registry $acr
Write-Output "Creating new Azure Container registry: $acr" -Verbose
New-AzContainerRegistry -Name $acr -ResourceGroupName $rg -Location $location -Sku Basic
Write-Output "New Azure Container registry: ($acr) created" -Verbose


Write-Output "Generating ssh keys" -Verbose
ssh-keygen -t rsa -b 2048
Write-Output "Ssh keys generated" -Verbose

# $spObject=New-AzADServicePrincipal -DisplayName ServicePrincipalName
# $BSTR = [System.Runtime.InteropServices.Marshal]::SecureStringToBSTR($spObject.Secret)
# $UnsecureSecret = [System.Runtime.InteropServices.Marshal]::PtrToStringAuto($BSTR)
# $password = ConvertTo-SecureString $UnsecureSecret -AsPlainText -Force
# $credential = New-Object System.Management.Automation.PSCredential ($spObject.ApplicationId, $password)


# $credProps = @{StartDate = Get-Date; EndDate = (Get-Date -Year 2024); Password = 'MySuperAwesomePasswordIs3373'}
# $credentials = New-Object Microsoft.Azure.Commands.ActiveDirectory.PSADPasswordCredential -Property $credProps
# $sp = New-AzAdServicePrincipal -DisplayName "ServicePrincipalName" -PasswordCredential $credentials

$securePassword = ConvertTo-SecureString $appPassword -AsPlainText -Force
$credential = New-Object System.Management.Automation.PSCredential ($spn.ApplicationId, $securePassword)


Write-Output "Creating new Azure Kubernetes Service cluster: $aks" -Verbose
New-AzAks `
  -Name $aks `
  -Location $location `
  -ResourceGroupName $rg `
  -NodeCount 1 `
  -KubernetesVersion $kubeVersion `
  -NodeVmSize $nodeVMSize `
  -ClientIdAndSecret $credential `
  -Verbose 
Write-Output "New Azure Kubernetes Service cluster: ($aks) created" -Verbose


# Once created (the creation could take ~10 min), get the credentials to interact with your AKS cluster
Write-Output "Getting credentials for Azure Kubernetes Service cluster: $aks" -Verbose
Import-AzAksCredential -ResourceGroupName $rg -Name $aks
Write-Output "Credentials for Azure Kubernetes Service cluster: ($aks) obtained" -Verbose
  

  # az acr build --image "checkvatid:v1" \
  # --registry acrTunde \
  # --file dockerfile . 

  



# Remove-AzResourceGroup -Name $rg
