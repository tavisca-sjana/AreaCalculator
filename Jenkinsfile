pipeline {
  agent any
  stages {
    stage('Build') {
      parallel {
        stage('Build') {
          steps {
            sh 'echo ""'
            sh 'echo "build"'
          }
        }
        stage('') {
          steps {
            echo 'build2'
          }
        }
      }
    }
    stage('test') {
      steps {
        echo 'this is test'
      }
    }
  }
}