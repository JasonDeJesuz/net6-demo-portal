![sheeple Logo](/Docs/github_assets/sheeple_logo.jpeg)

# Quickstart
This directory contains a docker-compose setup that includes the services with all their supporting infrastructure and configuration to allow the Directory API services to be worked with locally.



## Quickstart Requirements
- HomeBrew (MAC)
- Docker
- Docker-Compose
- JQ
- coreutils 

## Installing Docker

### Mac

### Windows

## Installing Docker-Compose

### Mac

### Windows

## Installing JQ

### Mac
First, make sure HomeBrew is installed.
Then: 
```
brew install jq
```

##Installing CoreUtils
```
brew install coreutils
```

## Cloning the repository
```
https://github.com/JasonDeJesuz/test_sheeple_people
```

## Starting the Services
After cloning the repository:
```
git clone git@github.com
cd sheeple
```

Change to the quickstart/docker-compose directory:
```
cd quickstart/docker-compose
```

Start the local docker-compose based environment:
### Windows
```
./run-quickstart.sh
```

### Mac
```
sudo sh run-quickstart.sh
```

This will start the sheeple directory service

|Locally Mappped port | Service |
|----------|-------|
|localhost:7195| sheeple People Directory |

## Common Errors
You might face some erros, when running this quickstart. Here are some reminders, and things you can try.

#### 1. Not enough space on disk
This usually means, the allocated space provided and assigned to docker has been reached. a Quick, yet destructive fix for this is to make sure you do not have any stopped containers, networks no used by at least one container, dangling images, and dangling build cache.
```
docker system prune
```

## References
- [Cool Config Driven Docker-Compose](https://levelup.gitconnected.com/docker-environment-variables-appsettings-json-net-bdac052bf3db)

---

<a href="https://guywithagopro.com"><img src="../../Docs/github_assets/j_logo.png" alt="jason logo" width=200 /></a>