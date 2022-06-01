# Dockerfile is like an instruction manual for the computer to follow to let it create an image
#From instruction will tell docker engine that this image will depend on this SDK to run
#Dockerhub is equivalent to github and we are just pulling an image version of our SDK to put in this image
from mcr.microsoft.com/dotnet/sdk:6.0 as build

#workdir docker instruction let use create what our working directory will be for this image
workdir /app

#copy docker instruction will let us copy files from this computer to put inside of the docker image
# * asterisks is for wildcard that lets the computer scan for any files that ends with .sln in this case
copy *.sln ./
copy PokeApi/*.csproj PokeApi/
copy PokeBL/*.csproj PokeBL/
copy PokeDL/*.csproj PokeDL/
copy PokeModel/*.csproj PokeModel/
copy PokeTest/*.csproj PokeTest/

#Now we will copy the rest after setting up our project structure
copy . ./

#Restoring our bin and obj files
#run docker instruction will run a CLI command in the image
run dotnet build

#It will create a publish folder that will hold all the information to be able to run your application
run dotnet publish -c Release -o publish

#Multi-stage build in Docker
# It allows us to have multiple ways to create our application
# The first stage was all about building our application hence why we need an SDK
# utlimately it was just to run dotnet build and dotnet publish

#Another stage that is all about running the application or how to run
from mcr.microsoft.com/dotnet/aspnet:6.0 as runtime

workdir /app
copy --from=build /app/publish ./

#CMD docker instructions tells the docker engine how/where to run this application
cmd ["dotnet", "PokeApi.dll"]

#Expose to port 80
expose 80