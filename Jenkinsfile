pipeline {
    agent any
    triggers {
        githubPush()
    }
    stages {
        stage('Restore packages'){
           steps{
               sh 'dotnet restore dotnet-demo-project.sln'
            }
         }
        stage('Clean'){
           steps{
               sh 'dotnet clean dotnet-demo-project.sln --configuration release'
            }
         }
        stage('Build'){
           steps{
               sh 'dotnet build dotnet-demo-project.sln --configuration Release --no-restore'
            }
         }
        stage('Test: Unit Test'){
           steps {
                sh 'dotnet test dotnet-test-project/dotnet-test-project.csproj --configuration release --no-restore'
             }
          }
        stage('Publish'){
             steps{
               sh 'dotnet publish dotnet-demo-project/dotnet-demo-project.csproj --configuration release --no-restore'
             }
        }
        stage('Deploy'){
             steps{
               sh '''for pid in $(lsof -t -i:9090); do
                       kill -9 $pid
               done'''
               sh 'cd dotnet-demo-project/bin/Release/net6.0/publish'
               sh 'nohup dotnet dotnet-demo-project.dll --urls="http://0.0.0.0:9090" --no-restore > /dev/null 2>&1 &'
             }
        }
    }
}