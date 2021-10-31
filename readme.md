
# Animal Shelter API - Friday Project 12

### By Becket Harvey

An animal shelter api that hosts a database containing user generated animals for adoption.

## Technologies Used
* C#
* VS Code
* ASP.NET Core MVC
* MySQL
* Entity Framework Core v 5.0
* Swagger
* Postman(Or Thunder Client Extension in VSCode)
* NewtonsoftJson


## Description
This api database contains animals for adoption! Users can access different endpoints in apicalls to this api to view, edit, create and delete these poor little fictional fuzzballs.

### Prerequisites


**Install .NET Core**
  * Mac:Install [here](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-2.2.106-macos-x64-installer)
  * Windows: Install [here](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-2.2.203-windows-x64-installer)

**Install dotnet script**

Use the command ```dotnet tool install -g dotnet -script in a terminal```



## Setup and Use


**AppSettings**

1. Create new file appsettings.json in YOURPROJECTFOLDER/Animal
2. Add the following code to the new appsettings.json, replacing the YOUR_PASSWORD_HERE with your mySQL password

        {  
          "Logging": {  
            "LogLevel": {  
              "Default": "Information",  
              "Microsoft": "Warning",  
              "Microsoft.Hosting.Lifetime": "Information"  
            }  
          },  
          "AllowedHosts": "*",  
          "ConnectionStrings": { 
            "DefaultConnection": "Server=localhost;Port=3306;database=becket_harvey;uid=root;pwd=YOUR_PASSWORD_HERE;", 
            "ConnStr": "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SarathlalDB;Integrated Security=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"  
          },  
          "JWT": {  
            "ValidAudience": "http://localhost:5000",  
            "ValidIssuer": "http://localhost:5000",  
            "Secret": "epicodus"  
          }  
        } 

**Database Setup**
1. In terminal, navigate into YOURPROJECTFOLDER/Animal and run command ```dotnet ef database update``` to build database

2. OPTIONAL : You can run the project with no data and update with your own content OR seed the project with pre-built data by following the following steps. (The project comes with pre-seeded data, but this can be replaced)
  - Navigate to the Models/TravelContext.cs file
  - Override the ```OnModelCreating(ModelBuilder builder)``` with the following code:
    >     protected override void OnModelCreating(ModelBuilder builder)
            {
            builder.Entity<Destination>()
            .HasData(
              new Animal { AnimalId = 1, Name = "Ruffus", Species = "Dog", Age = 7, Gender = "Male" },
              new Animal { AnimalId = 2, Name = "Fuzz Aldrin", Species = "Cat", Age = 1, Gender = "Male" },
              new Animal { AnimalId = 3, Name = "Pawpstar", Species = "Dog", Age = 2, Gender = "Female" },
            );


**Launch API in Server**
1. In YOURPROJECTFOLDER/Animal, run command ```dotnet run``` to open the api in your browser

## 🛰️ API Documentation
Explore the API endpoints in Postman or a browser. You will not be able to utilize authentication in a browser.

### Using Swagger Documentation 
To explore the API with Swagger, launch the project using `dotnet run` with the Terminal or Powershell, and input the following URL into your browser: `http://localhost:5000/swagger`

..........................................................................................

### Endpoints
Base URL: `http://localhost:5000`

#### HTTP Request Structure
```
GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id}
```

#### Example Query
```
https//localhost:5000/api/animals/1
```

### Reviews
Access information about the posted reviews

#### HTTP Request
```
GET /api/Animals
POST /api/Animals
GET /api/Animals/{id}
PUT /api/Animal/{id}
DELETE /api/Animal/{id}

```


#### Sample JSON Response
```
Update to include sample from API
```


------------------------------

### 🤝 Contributors

| Author | GitHub | Email |
|--------|:------:|:-----:|

| [Becket Harvey](https://www.linkedin.com/in/becket-harvey-sunshine/) | [SunshinePunch](https://github.com/SunshinePunch) |

------------------------------