# Hello World Container App

Sample dotnet 6.0 minimal api to run in docker and kubernetes. This app is a regular "Hello World!" app. I generally use this while demoing concepts using containers and kubernetes. I have been trying to make the container size as small as possible. It is currently 43.23 MB.

## To Run

This app is too simple to be used on its own. It makes sense to use it in a container as a sample app. This app is a regular "Hello World" app and simply prints hello world to the console. It can be configured to print hello and a configured string by changing the environment variable TARGET either in a docker file or as an environment variable

### Docker
This code as already been built into a container image and is available on dockerhub.
To directly pull the image use ```docker pull pradeepl/helloworld:latest```

or you can use docker run as below

```
docker run --rm -p 8000:8080 -e TARGET=Universe pradeepl/helloworld:latest  
curl http://0.0.0.0:8000
```

### Kubernetes

Create a deployment and use the image
