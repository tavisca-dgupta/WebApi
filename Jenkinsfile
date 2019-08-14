pipeline {
    agent any
    stages {
        stage('Restore') {
            echo 'Restoring packages'
            steps{
                sh 'dotnet restore'
            }
        }
     	stage('Build'){
     		echo 'build project'
            steps{
                sh 'dotnet build HelloHiApi.sln -p:Configuration=release -v:q'
            }

     	}
     	stage('Test'){
     		echo 'Test project'
            steps{
                sh 'dotnet test HelloHiApi.Test/HelloHiApi.Test.csproj -p:Configuration=release -v:q'
                }

     	}
     	stage('Publish'){
     		echo 'publish project'
            steps{
                sh 'dotnet publish'
            }

     	}

     	}
     	post{
     		success{
     			archiveArtifacts artifacts: '**', fingerprint:true
     			sh 'dotnet HelloHiApi/bin/Release/netcoreapp2.1/HelloHiApi.dll'
     		}
    }
}