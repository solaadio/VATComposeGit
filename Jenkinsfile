node {
    def appCheckVatId
    def appFeedback
    def appGetAppInfo
    def appGetRates
    def appGetRatesMongo
    
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

    stage('Build Checkvatid') {
        /* This builds the actual image; synonymous to
         * docker build on the command line */
        appCheckVatId = docker.build("solaadio/checkvatid", "./src/CheckVatId")
    }
    
    stage('Build Feedback') {
        /* This builds the actual image; synonymous to
         * docker build on the command line */
        
        appFeedback = docker.build("solaadio/feedback", "./src/Feedback")
    }

    stage('Build GetRates') {
        /* This builds the actual image; synonymous to
         * docker build on the command line */

        appGetRates = docker.build("solaadio/getrates", "./src/GetRates")
    }
    
    stage('Build GetRatesMongo') {
        /* This builds the actual image; synonymous to
         * docker build on the command line */
        
        appGetRatesMongo = docker.build("solaadio/getratesmongo", "./src/GetRatesMongo")
    }

    stage('Build GetAppInfo') {
        /* This builds the actual image; synonymous to
         * docker build on the command line */

        appGetAppInfo = docker.build("solaadio/getappinfo", "./src/GetAppInfo")
    }

    stage('Push Checkvatid image to Docker hub') {
        /* Finally, we'll push the image with two tags:
         * First, the incremental build number from Jenkins
         * Second, the 'latest' tag.
         * Pushing multiple tags is cheap, as all the layers are reused. */
        docker.withRegistry('https://registry.hub.docker.com', 'docker-hub-credentials') {
            appCheckVatId.push("${env.BUILD_NUMBER}")
            appCheckVatId.push("latest")
        }
    }
    
    stage('Push Feedback image to Docker hub') {
        /* Finally, we'll push the image with two tags:
         * First, the incremental build number from Jenkins
         * Second, the 'latest' tag.
         * Pushing multiple tags is cheap, as all the layers are reused. */
        docker.withRegistry('https://registry.hub.docker.com', 'docker-hub-credentials') {
            appFeedback.push("${env.BUILD_NUMBER}")
            appFeedback.push("latest")
        }
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

    stage('Push GetRates image to Docker hub') {
        /* Finally, we'll push the image with two tags:
         * First, the incremental build number from Jenkins
         * Second, the 'latest' tag.
         * Pushing multiple tags is cheap, as all the layers are reused. */
        docker.withRegistry('https://registry.hub.docker.com', 'docker-hub-credentials') {
            appGetRates.push("${env.BUILD_NUMBER}")
            appGetRates.push("latest")
        }
    }
   

    stage('Push GetRatesMongo image to Docker hub') {
        /* Finally, we'll push the image with two tags:
         * First, the incremental build number from Jenkins
         * Second, the 'latest' tag.
         * Pushing multiple tags is cheap, as all the layers are reused. */
        docker.withRegistry('https://registry.hub.docker.com', 'docker-hub-credentials') {
            appGetRatesMongo.push("${env.BUILD_NUMBER}")
            appGetRatesMongo.push("latest")
        }
    }
        
    
    stage('Push Checkvatid Image to ACR') {
        withDockerRegistry([credentialsId: dockerCredentialId, url: "http://${dockerRegistry}"]) {
            dir('target') {
                sh """
                    cp -f ../src/CheckVatId/dockerfile .
                    docker build -t "${dockerRegistry}/checkvatid:${env.BUILD_NUMBER}" ../src/CheckVatId 
                    docker push "${dockerRegistry}/checkvatid:${env.BUILD_NUMBER}"
                    docker build -t "${dockerRegistry}/checkvatid:latest" ../src/CheckVatId 
                    docker push "${dockerRegistry}/checkvatid:latest"
                """
            }
        }
    }
    
    stage('Push Feedback Image to ACR') {
        withDockerRegistry([credentialsId: dockerCredentialId, url: "http://${dockerRegistry}"]) {
            dir('target') {
                sh """
                    cp -f ../src/Feedback/dockerfile .
                    docker build -t "${dockerRegistry}/feedback:${env.BUILD_NUMBER}" ../src/Feedback 
                    docker push "${dockerRegistry}/feedback:${env.BUILD_NUMBER}"
                    docker build -t "${dockerRegistry}/feedback:latest" ../src/Feedback 
                    docker push "${dockerRegistry}/feedback:latest"
                """
            }
        }
    }
    
    stage('Push GetRates Image to ACR') {
        withDockerRegistry([credentialsId: dockerCredentialId, url: "http://${dockerRegistry}"]) {
            dir('target') {
                sh """
                    cp -f ../src/GetRates/dockerfile .
                    docker build -t "${dockerRegistry}/getrates:${env.BUILD_NUMBER}" ../src/GetRates 
                    docker push "${dockerRegistry}/getrates:${env.BUILD_NUMBER}"
                    docker build -t "${dockerRegistry}/getrates:latest" ../src/GetRates 
                    docker push "${dockerRegistry}/getrates:latest"
                """
            }
        }
    }
    
    stage('Push GetRatesMongo Image to ACR') {
        withDockerRegistry([credentialsId: dockerCredentialId, url: "http://${dockerRegistry}"]) {
            dir('target') {
                sh """
                    cp -f ../src/GetRatesMongo/dockerfile .
                    docker build -t "${dockerRegistry}/getratesmongo:${env.BUILD_NUMBER}" ../src/GetRatesMongo 
                    docker push "${dockerRegistry}/getratesmongo:${env.BUILD_NUMBER}"
                    docker build -t "${dockerRegistry}/getratesmongo:latest" ../src/GetRatesMongo 
                    docker push "${dockerRegistry}/getratesmongo:latest"
                """
            }
        }
    }
    
    stage('Push GetAppInfo Image to ACR') {
        withDockerRegistry([credentialsId: dockerCredentialId, url: "http://${dockerRegistry}"]) {
            dir('target') {
                sh """
                    cp -f ../src/GetAppInfo/dockerfile .
                    docker build -t "${dockerRegistry}/getappinfo:${env.BUILD_NUMBER}" ../src/CheckVatId 
                    docker push "${dockerRegistry}/getappinfo:${env.BUILD_NUMBER}"
                    docker build -t "${dockerRegistry}/getappinfo:latest" ../src/CheckVatId 
                    docker push "${dockerRegistry}/getappinfo:latest"
                """
            }
        }
    }
    
    
    stage('Deploy Checkvatid to AKS') {
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
    
    imageName = "feedback:${env.BUILD_NUMBER}"
    env.IMAGE_TAG = "${dockerRegistry}/${imageName}"
    stage('Deploy Feedback to AKS') {
        // Apply the deployments to AKS.
        // With enableConfigSubstitution set to true, the variables ${TARGET_ROLE}, ${IMAGE_TAG}, ${KUBERNETES_SECRET_NAME}
        // will be replaced with environment variable values
        acsDeploy azureCredentialsId: servicePrincipalId,
                  resourceGroupName: resourceGroup,
                  containerService: "${aks} | AKS",
                  configFilePaths: 'manifests/feedback.yaml',
                  enableConfigSubstitution: true,
                  containerRegistryCredentials: [[credentialsId: dockerCredentialId, url: "http://${dockerRegistry}"]]
    }

    imageName = "getrates:${env.BUILD_NUMBER}"
    env.IMAGE_TAG = "${dockerRegistry}/${imageName}"
    stage('Deploy GetRates to AKS') {
        // Apply the deployments to AKS.
        // With enableConfigSubstitution set to true, the variables ${TARGET_ROLE}, ${IMAGE_TAG}, ${KUBERNETES_SECRET_NAME}
        // will be replaced with environment variable values
        acsDeploy azureCredentialsId: servicePrincipalId,
                  resourceGroupName: resourceGroup,
                  containerService: "${aks} | AKS",
                  configFilePaths: 'manifests/getrates.yaml',
                  enableConfigSubstitution: true,
                  containerRegistryCredentials: [[credentialsId: dockerCredentialId, url: "http://${dockerRegistry}"]]
    }

    imageName = "getratesmongo:${env.BUILD_NUMBER}"
    env.IMAGE_TAG = "${dockerRegistry}/${imageName}"
    stage('Deploy GetRatesMongo to AKS') {
        // Apply the deployments to AKS.
        // With enableConfigSubstitution set to true, the variables ${TARGET_ROLE}, ${IMAGE_TAG}, ${KUBERNETES_SECRET_NAME}
        // will be replaced with environment variable values
        acsDeploy azureCredentialsId: servicePrincipalId,
                  resourceGroupName: resourceGroup,
                  containerService: "${aks} | AKS",
                  configFilePaths: 'manifests/getratesmongo.yaml',
                  enableConfigSubstitution: true,
                  containerRegistryCredentials: [[credentialsId: dockerCredentialId, url: "http://${dockerRegistry}"]]
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
