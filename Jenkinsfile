node {
    def app1
    def app2

    stage('Clone repository') {
        /* Let's make sure we have the repository cloned to our workspace */

        checkout scm
    }

    stage('Build Checkvatid') {
        /* This builds the actual image; synonymous to
         * docker build on the command line */

        
        app1 = docker.build("solaadio/checkvatid", "./src/CheckVatId")
    }

    stage('Push image') {
        /* Finally, we'll push the image with two tags:
         * First, the incremental build number from Jenkins
         * Second, the 'latest' tag.
         * Pushing multiple tags is cheap, as all the layers are reused. */
        docker.withRegistry('https://registry.hub.docker.com', 'docker-hub-credentials') {
            app1.push("${env.BUILD_NUMBER}")
            app1.push("latest")
        }
    }
    
        stage('Build Feedback') {
        /* This builds the actual image; synonymous to
         * docker build on the command line */

        
        app2 = docker.build("solaadio/feedback", "./src/Feedback")
    }

    stage('Push image') {
        /* Finally, we'll push the image with two tags:
         * First, the incremental build number from Jenkins
         * Second, the 'latest' tag.
         * Pushing multiple tags is cheap, as all the layers are reused. */
        docker.withRegistry('https://registry.hub.docker.com', 'docker-hub-credentials') {
            app2.push("${env.BUILD_NUMBER}")
            app2.push("latest")
        }
    }
}
