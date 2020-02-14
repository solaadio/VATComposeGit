$name = "iyabo"
$rg = "rg" + $name
$location = "westeurope"
$acr = "acr" + $name
$aks = "aks" +$name
$subscriptionId = "cb5ab4a7-dd08-4be3-9d7e-9f68ae30f224"
$kubeVersion = "1.14.8"
$nodeVMSize = "Standard_B2s"



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

Write-Output "Creating new Azure Kubernetes Service cluster: $aks" -Verbose
New-AzAks `
  -Name $aks `
  -Location $location `
  -ResourceGroupName $rg `
  -NodeCount 1 `
  -KubernetesVersion $kubeVersion `
  -NodeVmSize $nodeVMSize `
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
