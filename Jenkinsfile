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
        stage('checkout') {
            steps {
                git 'https://github.com/hailHIxxx/bmi_cal.git'
            }
        }
        stage('build') {
            steps {
                bat 'dotnet build bmi_calculator.sln'
            }
        }
        stage('stage 4') {
            steps {
                echo 'four'
            }
        }
    }
}
