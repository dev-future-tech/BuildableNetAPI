pipeline {
    agent any

    stages {
        stage('build') {
            steps {
                sh "dotnet restore"
                sh "dotnet build"
            }
        }
    }
}