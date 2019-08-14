pipeline {
    agent any
    stages {
        stage('Restore') {
            steps{
                            echo 'Restoring packages'
                sh 'dotnet restore'
            }
        }
     	stage('Build'){
            steps{
                     		echo 'build project'
                sh 'dotnet build HelloHiApi.sln -p:Configuration=release -v:q'
            }

     	}
     	stage('Test'){
            steps{
                     		echo 'Test project'
                sh 'dotnet test HelloHiApi.Test/HelloHiApi.Test.csproj -p:Configuration=release -v:q'
                }

     	}
     	stage('Publish'){
            steps{
                     		echo 'publish project'
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
