pipeline {
    agent {
        docker { image 'bitnami/dotnet-sdk:5'}
    }

    stages {
        stage('build') {
            steps {
                sh "dotnet restore"
                sh "dotnet build"
            }
        }
    }
}