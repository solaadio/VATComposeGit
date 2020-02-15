node {
    def appCheckVatId
    def appFeedback
    def appGetAppInfo
    def appGetRates
    def appGetRatesMongo
    
    def servicePrincipalId = '7c60dbaf-c9c2-46e1-905a-f083ad23ecf1'
    def resourceGroup = 'rgPaul'
    def aks = 'aksPaul'

    def dockerRegistry = 'acrPaul.azurecr.io'
    def imageName = "checkvatid:${env.BUILD_NUMBER}"
    env.IMAGE_TAG = "${dockerRegistry}/${imageName}"
    def dockerCredentialId = 'acrPaul'

    stage('Clone repository') {
        /* Let's make sure we have the repository cloned to our workspace */
        checkout scm
    }

    stage('Build Checkvatid') {
        /* This builds the actual image; synonymous to
         * docker build on the command line */
        appCheckVatId = docker.build("solaadio/checkvatid", "./src/CheckVatId")
    }

    stage('Push image to Docker hub') {
        /* Finally, we'll push the image with two tags:
         * First, the incremental build number from Jenkins
         * Second, the 'latest' tag.
         * Pushing multiple tags is cheap, as all the layers are reused. */
        docker.withRegistry('https://registry.hub.docker.com', 'docker-hub-credentials') {
            appCheckVatId.push("${env.BUILD_NUMBER}")
            appCheckVatId.push("latest")
        }
    }
    
    stage('Push Image to ACR') {
        withDockerRegistry([credentialsId: dockerCredentialId, url: "http://${dockerRegistry}"]) {
            dir('target') {
                sh """
                    cp -f ../src/CheckVatId/dockerfile .
                    docker build -t "${env.IMAGE_TAG}" ../src/CheckVatId 
                    docker push "${env.IMAGE_TAG}"
                    docker build -t "${dockerRegistry}/checkvatid:latest" ../src/CheckVatId 
                    docker push "${dockerRegistry}/checkvatid:latest"
                """
            }
        }
    }
    
    stage('Deploy') {
    // Apply the deployments to AKS.
    // With enableConfigSubstitution set to true, the variables ${TARGET_ROLE}, ${IMAGE_TAG}, ${KUBERNETES_SECRET_NAME}
    // will be replaced with environment variable values
    acsDeploy azureCredentialsId: servicePrincipalId,
              resourceGroupName: resourceGroup,
              containerService: "${aks} | AKS",
              configFilePaths: 'manifests/checkvatid.yaml',
              enableConfigSubstitution: true,
              containerRegistryCredentials: [[credentialsId: dockerCredentialId, url: "http://${dockerRegistry}"]]
    }
    
    stage('Build Feedback') {
        /* This builds the actual image; synonymous to
         * docker build on the command line */

        
        appFeedback = docker.build("solaadio/feedback", "./src/Feedback")
    }

    stage('Push image') {
        /* Finally, we'll push the image with two tags:
         * First, the incremental build number from Jenkins
         * Second, the 'latest' tag.
         * Pushing multiple tags is cheap, as all the layers are reused. */
        docker.withRegistry('https://registry.hub.docker.com', 'docker-hub-credentials') {
            appFeedback.push("${env.BUILD_NUMBER}")
            appFeedback.push("latest")
        }
    }
    
    stage('Build GetAppInfo') {
        /* This builds the actual image; synonymous to
         * docker build on the command line */

        
        appGetAppInfo = docker.build("solaadio/getappinfo", "./src/GetAppInfo")
    }

    stage('Push image') {
        /* Finally, we'll push the image with two tags:
         * First, the incremental build number from Jenkins
         * Second, the 'latest' tag.
         * Pushing multiple tags is cheap, as all the layers are reused. */
        docker.withRegistry('https://registry.hub.docker.com', 'docker-hub-credentials') {
            appGetAppInfo.push("${env.BUILD_NUMBER}")
            appGetAppInfo.push("latest")
        }
    }
    
    stage('Build GetRates') {
        /* This builds the actual image; synonymous to
         * docker build on the command line */

        
        appGetRates = docker.build("solaadio/getrates", "./src/GetRates")
    }

    stage('Push image') {
        /* Finally, we'll push the image with two tags:
         * First, the incremental build number from Jenkins
         * Second, the 'latest' tag.
         * Pushing multiple tags is cheap, as all the layers are reused. */
        docker.withRegistry('https://registry.hub.docker.com', 'docker-hub-credentials') {
            appGetRates.push("${env.BUILD_NUMBER}")
            appGetRates.push("latest")
        }
    }
    
    stage('Build GetRatesMongo') {
        /* This builds the actual image; synonymous to
         * docker build on the command line */

        
        appGetRatesMongo = docker.build("solaadio/getratesmongo", "./src/GetRatesMongo")
    }

    stage('Push image') {
        /* Finally, we'll push the image with two tags:
         * First, the incremental build number from Jenkins
         * Second, the 'latest' tag.
         * Pushing multiple tags is cheap, as all the layers are reused. */
        docker.withRegistry('https://registry.hub.docker.com', 'docker-hub-credentials') {
            appGetRatesMongo.push("${env.BUILD_NUMBER}")
            appGetRatesMongo.push("latest")
        }
    }
    
}
