node {
    def appGetAppInfo
    
    def servicePrincipalId = 'azure_service_principal'
    def resourceGroup = 'rgJenkinsAzure'
    def aks = 'aksJenkinsAzure'

    def dockerRegistry = 'acrJenkinsAzure.azurecr.io'
    def imageName = "checkvatid:${env.BUILD_NUMBER}"
    env.IMAGE_TAG = "${dockerRegistry}/${imageName}"
    def dockerCredentialId = 'acrJenkinsAzure'

    stage('Clone repository') {
        /* Let's make sure we have the repository cloned to our workspace */
        checkout scm
    }

    stage('Build GetAppInfo') {
        /* This builds the actual image; synonymous to
         * docker build on the command line */

        appGetAppInfo = docker.build("solaadio/getappinfo", "./src/GetAppInfo")
    }
    
    stage('Push AppInfo image to Docker hub') {
        /* Finally, we'll push the image with two tags:
         * First, the incremental build number from Jenkins
         * Second, the 'latest' tag.
         * Pushing multiple tags is cheap, as all the layers are reused. */
        docker.withRegistry('https://registry.hub.docker.com', 'docker-hub-credentials') {
            appGetAppInfo.push("${env.BUILD_NUMBER}")
            appGetAppInfo.push("latest")
        }
    }

    stage('Push GetAppInfo Image to ACR') {
        withDockerRegistry([credentialsId: dockerCredentialId, url: "http://${dockerRegistry}"]) {
            dir('target') {
                sh """
                    cp -f ../src/GetAppInfo/dockerfile .
                    docker build -t "${dockerRegistry}/getappinfo:${env.BUILD_NUMBER}" ../src/GetAppInfo 
                    docker push "${dockerRegistry}/getappinfo:${env.BUILD_NUMBER}"
                    docker build -t "${dockerRegistry}/getappinfo:latest" ../src/GetAppInfo 
                    docker push "${dockerRegistry}/getappinfo:latest"
                """
            }
        }
    }

    imageName = "getappinfo:${env.BUILD_NUMBER}"
    env.IMAGE_TAG = "${dockerRegistry}/${imageName}"
    stage('Deploy GetAppInfo to AKS') {
        // Apply the deployments to AKS.
        // With enableConfigSubstitution set to true, the variables ${TARGET_ROLE}, ${IMAGE_TAG}, ${KUBERNETES_SECRET_NAME}
        // will be replaced with environment variable values
        acsDeploy azureCredentialsId: servicePrincipalId,
                  resourceGroupName: resourceGroup,
                  containerService: "${aks} | AKS",
                  configFilePaths: 'manifests/getappinfo.yaml',
                  enableConfigSubstitution: true,
                  containerRegistryCredentials: [[credentialsId: dockerCredentialId, url: "http://${dockerRegistry}"]]
    }

}
