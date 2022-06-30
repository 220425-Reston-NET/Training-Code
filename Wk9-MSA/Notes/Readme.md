# Introduction to Microservices
## Monolithic Architecture
* Both the backend and frontend is tightly coupled
* Very easy to deploy
* Mostly used for small projects and prototypes
* Very hard to scale due to everything being tightly coupled
    * You can’t evolve frontend separately from the backend and vice versa

## Service Oriented Architecture
* The architecture style of breaking up your application into services
* Decouple the frontend from the backend
* Easier to scale compared to monolithic
* Can be used to develop complex projects and a little harder to deploy compared to monolithic

## Micro-services Architecture
* Implementation of SOA that breaks down services even more (Think of Single Responsible principle in SOLID)
* It wants each service to be responsible for one thing only
* Each service is independent of another service meaning if one goes does, the rest of the services can still operate perfectly
* Starting this architecture is complex and mostly used/transitioned after you have a huge customer based and a huge project
* Very popular architecture style used by big IT companies
    * Nano-services architecture might also be used by other IT companies

# MSA Characteristics
## Single Responsibility Principle
* One service must be responsible for one thing

## Encapsulated
* Each service must encapsulate the data and behavior in a single unit
* Each data for each service must be private and can only be accessed by the service it was assigned to

## Independent
* Each service is independent of each other
* If a service goes down, it doesn’t affect the other services
* Each service can be developed by a completely different language

## Benefits
* Scalability
    * Adding new features to a single service shouldn't affect your other services
    * You can also add/remove services without affecting the other services
* Simplicity of developing new features
    * Simple once the infastructure is setup (since you have to setup multiple databases, multiple services, etc.)
    * Adding new features is a lot easier and you don't have to worry about breaking other features
* Deployment of individual service
    * Easy to deploy the individual services when scaling out
    * Trying to redeploy one massive service with a lot of features will definitely take a while to process
* Language Agnostic 
    * You can work with different langauge as long as they all send the data in the same protocol (http)
    * Let's you work with the right language for different application
* Testable
    * Easy to test when each service serve only one purpose

# Drawbacks
* Initial setup
    * Deploying everything at the same time will take a while and might cause problems due to deploying a whole ecosystem of services
* Complex when it comes to communication between services
* Monitoring
    * Checking on multiple services to see if there is an issue (used to be manual thing but it is better now)
* Communication is key
    * Since there are multiple services and they must have a stable communication

# Key things to help MSA work
Service Discoverability
* You have a service registry that contains information about the services in your MSA ecosystem
    * Think of the DNS 
* They are responsible for automatic process of checking/monitoring your services
Gateway
* They are responsible for helping the services communicate with each other
* Main point, you have a single-entry point for your frontend to communicate and that single entry point will handle all the communication of any of the services to do function

# Load Balancing
* With multiple services running in different containers/servers/nodes, you have a load balancer to handle all the traffic
* They will balance the outgoing/internal traffic of your MSA system
# Message Queues
* Another mechanism to help with communication in your MSA
* It stores messages in a queue until they are process especially with a spiky workload
Circuit Breaker
* If something fails, it’ll make sure that it won’t create cascading failure of your other services

# Kurbernetes (K8s)
* Open-source system for deploying MSA applications
* K8s uses containerized workload and services to handle its MSA processes 
* Helps us scale our application very easily using container orchestration tool
* Also helps us monitor our application when scaling without us having to do much of anything

## Container Orchestration
* Best way to scaling your app in this modern world
* This will essentially automatically deploy more containers depending on the amount of workload
* Scaling
    * It will have multiple containers running the same image and will continue spinning up more (or taking them down) containers as needed
* Network
    * Load balancer and service discoverability is with container orchestration

# K8s Architecture
* Container
    * A running instance of an image
* Pods
    * They are the smallest unit in K8s (since container belongs in docker while pods is strictly from K8s)
    * May be made up of one or more containers
    * The pod will keep on running and never stopping and if one pod somehow fails a new pod will come up to replace it
    * They provide the necessary environment variables needed to run the containers
    * Each pod will have a unique IP address, storage, config, information for the containers
* Worker nodes
    * 