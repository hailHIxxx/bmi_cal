pipeline {
    agent any

    stages {
        stage ('Clean workspace') {
          steps {
            cleanWs()
          }
        }
        stage('.NET check') {
            steps {
                bat 'dotnet --version'
            }
        }
        stage('build') {
            steps {
                bat 'csc Why.cs'
            }
        }
        stage('stage 4') {
            steps {
                echo 'four'
            }
        }
    }
}
