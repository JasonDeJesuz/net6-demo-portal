![sheeple Logo](/Docs/github_assets/sheeple_logo.jpeg)

# sheeple Directory 🐑

## Intro 👀
##### The `sheeple` directory project has been built to briefly showcase the skillsets, I possess as a `.NET Developer`.
##### Project built by [Jason De Jesuz](https://guywithagopro.com), for sheeple Digital using the following technologies.
#### For any questions, please contact me via [jason@lyemac.co.za](mailto:jason@lyemac.co.za) 👀

### Tech Stack 👨‍💻
- .NET 6
- MVC (Model View Controller)
- Entity Framework Core 6
- MS SQL Server (Code First Approach)
- HTML5, CSS3, JavaScript, jQuery
- Docker
- GitHub

### Hardware 💻
- Macbook Pro
- Windows 11

## TODO 👀
- Role based views (Only display Admin Operations to Admins)
- People Directory Search
- People Directory Search Predictive Typing
- People Directory Filter
- ~~User Registration (User & Admin)~~
- ~~User Login (User & Admin)~~
- ~~People Directory List~~
- ~~People Directory Add (Admin)~~
- ~~People Directory Update (Admin)~~
- ~~People Directory Delete (Admin)~~

## Pages 📄
| Name | URL | Category |
|------|-----|----------|
| User Login | [/auth/login](https://localhost:7195/auth/login) | Auth |
| User Registration | [/auth/register](https://localhost:7195/auth/register) | Auth |
| People List | [/person/list](https://localhost:7185/person/list) | People |
| People Create | [/person?actionType=create](https://localhost:7185/person?actionType=create) | People |
| People Edit | [/person?id=1&actionType=modify](https://localhost:7185/person?actionType=modify) | People |

## Postman 🦸‍♂️
Postman was used for the core testing and development of the API, you can find the Postman setup [here](/Docs/postman/sheeple.postman_collection.json).

You are required to create an Environment which contains the following global variables:
| Name | Description | Value |
|------|-------------|-------|
| host | The URL of the application | https://localhost:7195 |
| personId | The ID of the person, created. | 1 |
| token | The token which is retrieved when logging in, this will be set automatically | |

## Getting Started 🦄

### dotnet
The application will run migrations on startup, if the database connection is successful.
```
cd sheeple
```

Before getting started, make sure the appsettings.json file contains the correct values.

```
dotnet run --project sheeple
```

### QuickStart using Docker-Compose
You can use the QuickStart section to quickly get the entire solution up and running.
The Quickstart can be found [here](quickstart/docker-compose/README.md).

## Quick Links
- [QuickStart](quickstart/docker-compose/README.md)
- [PostMan Collection](Docs/postman/sheeple.postman_collection.json)
- [Database Setup & Info](/docs/database/README.md)

---

<a href="https://guywithagopro.com"><img src="Docs/github_assets/j_logo.png" alt="jason logo" width=200 /></a>