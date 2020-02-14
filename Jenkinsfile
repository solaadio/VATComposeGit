node {
    def appCheckVatId
    def appFeedback
    def appGetAppInfo
    def appGetRates

    stage('Clone repository') {
        /* Let's make sure we have the repository cloned to our workspace */

        checkout scm
    }

    stage('Build Checkvatid') {
        /* This builds the actual image; synonymous to
         * docker build on the command line */

        
        appCheckVatId = docker.build("solaadio/checkvatid", "./src/CheckVatId")
    }

    stage('Push image') {
        /* Finally, we'll push the image with two tags:
         * First, the incremental build number from Jenkins
         * Second, the 'latest' tag.
         * Pushing multiple tags is cheap, as all the layers are reused. */
        docker.withRegistry('https://registry.hub.docker.com', 'docker-hub-credentials') {
            appCheckVatId.push("${env.BUILD_NUMBER}")
            appCheckVatId.push("latest")
        }
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
    
}
