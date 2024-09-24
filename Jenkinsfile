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
                bat 'dotnet build C:/Users/MQASTAFF/OneDrive/BmiCal/bmi_calculator/bmi_calculator.csproj'
            }
        }
        stage('stage 4') {
            steps {
                echo 'four'
            }
        }
    }
}
