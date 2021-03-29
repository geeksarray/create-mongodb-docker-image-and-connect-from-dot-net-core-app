# Create MongoDB Docker Image and Connect from .NET Core app

This blog creates a Docker MongoDB Image container, database, collection and connnect this container through .NET Core Console app to read table data.

This blog creates a Docker MongoDB Image container, database, collection and connnect this container through .NET Core Console app to read table data.

Docker resolves a classic problem of developer it works on my machine!. You might have seen incidents where code is working absolutely fine on a developer machine however on a test or production environment it is not.

MongoDB is a NoSQL database, it is not the only SQL, it can do some different things than SQL databases. It stores data in JSON like documents.

[Code to connect MongoDB docker container from .NET Core Console application](https://github.com/geeksarray/create-mongodb-docker-image-and-connect-from-dot-net-core-app/blob/main/ConnectMongoDB/ProductCollection.cs)

Console application reads data from MongoDB Docker container and display collection as shown in this diagram.

![MongoDB Driver with .NET Core application](https://geeksarray.com/images/blog/mongodb-driver-with-dot-net-core-csharp.PNG)

For more details please visit - https://geeksarray.com/blog/create-mongodb-docker-image-and-connect-from-dot-net-core-app


