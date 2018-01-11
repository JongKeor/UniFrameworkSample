pipeline {
  agent {
    node {
      label 'mac'
    }
    
  }
  stages {
    stage('Common') {
      steps {
        echo 'Start'
        svn(changelog: true, url: 'http://10.221.2.136/nw1/Victory/trunk/Victory/Victory', poll: true)
      }
    }
    stage('Build') {
      parallel {
        stage('Android') {
          steps {
            echo 'Androi'
          }
        }
        stage('IOS') {
          steps {
            echo 'Ios'
            sh 'echo \'hello\''
          }
        }
        stage('Window') {
          steps {
            echo 'Window'
          }
        }
      }
    }
    stage('Deploy') {
      steps {
        echo 'deploy'
      }
    }
  }
  environment {
    UNI_OUTPUT_DIR = 'build'
  }
}