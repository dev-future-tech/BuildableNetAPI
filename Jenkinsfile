pipeline {​​​​​​​​​​​​​​​​​​​​
    agent kubernetes {​​​​​​​​​​​​​​​​​​​​
        containers [
            containerTemplate(name: 'maven', image: 'maven', command: 'sleep', args: '99d'),
            containerTemplate(name: 'java', image: 'openjdk:11-oracle', command: 'sleep', args: '99d')
        ]
    }​​​​​​​​​​​​​​​​​​​​
}​​​​​​​​​​​​​​​​​​​​