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
        stage('Clean') {
            steps {
                // Clean the specific project
                bat 'dotnet clean C:/room/BmiCal/bmi_calculator/bmi_calculator.csproj'
            }
        }
        stage('Build') {
            steps {
                // Build the project using a relative path
                bat 'dotnet C:/room/BmiCal/bmi_calculator/bmi_calculator.csproj'
            }
        }
        stage('stage 4') {
            steps {
                echo 'four'
            }
        }
    }
}
//C:/room/BmiCal/bmi_calculator/bmi_calculator.csproj
