pipeline {
    agent any

    stages {
        stage('build') {
            steps {
                step {
                    sh "dotnet restore"
                    sh "dotnet build"
                }
            }
        }
    }
}