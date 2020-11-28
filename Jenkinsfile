pipeline {
  agent any
  stages {
    stage('Q10 Step Commission') {
      parallel {
        stage('Q10 Step Commission') {
          steps {
            sh 'echo hello'
            sleep 10
          }
        }

        stage('Q10 Plus Step Commission') {
          steps {
            sleep 5
            sh 'echo test'
          }
        }

      }
    }

  }
}