pipeline {
  agent {
    node {
      label 'mac'
    }
    
  }
  stages {
    stage('Android') {
      parallel {
        stage('Android') {
          steps {
            echo 'test'
          }
        }
        stage('Ios') {
          steps {
            echo 'ios'
          }
        }
        stage('Window') {
          steps {
            echo 'window'
          }
        }
      }
    }
  }
  environment {
    UNI_OUTPUT_DIR = 'build'
  }
}