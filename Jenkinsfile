pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                // Jenkins haalt hier automatisch de code uit je main branch op
                checkout scm
            }
        }

        stage('Build Frontend') {
            steps {
                echo 'Bezig met het bouwen van de Frontend applicatie...'
                // Pas het pad aan naar de map waar je .csproj bestand staat
                bat 'dotnet build "frontend/EasyDevOps.Frontend.csproj" --configuration Release'
            }
        }

        stage('Security Test') {
            steps {
                echo 'Systeemeigen vulnerability scan uitvoeren...'
                // Dit scant je project op bekende beveiligingslekken in NuGet pakketten
                bat 'dotnet list "frontend/EasyDevOps.Frontend.csproj" package --vulnerable'
            }
        }
    }
}
