# Empires Puzzle API
![master](https://github.com/ming-tsai/EmpiresPuzzlesAPI/workflows/master/badge.svg)

This project is an example how to deploy dotnet core 3.1 API in Heroku using Empire Puzzles information.

### Game descriptions
Empires & Puzzles: RPG Quest. Empires & Puzzles is a completely new take on RPG games, combining match-3 battles and building a mighty stronghold - topped with thrilling PVP duels.

# Prerequisities
  - [Donet core sdk 3.1](https://dotnet.microsoft.com/download)
  - [Heroku cli](https://devcenter.heroku.com/articles/heroku-cli) (optional)

# Getting start

## Run project locally
1. Build project
```bash
dotnet build
```

2. Config dev connection string on appsettings.Development.json
```json
  "ConnectionStrings" : {
    "PostgreSQL" : "User ID={user};Password={paswword};Host={host};Port=5432;Database={database};Pooling=true;SslMode=Require;TrustServerCertificate=True;"
  }
```
3. Run project
```bash
dotnet run --project EmpiresPuzzles.API
```

## Deploy project on Heroku

1. Create [Heroku app](https://trailhead.salesforce.com/en/content/learn/projects/develop-heroku-applications/create-a-heroku-app)
2. Add-ons [postgresql](https://www.heroku.com/postgres) on Heroku app
3. Find database credentials on [dashboard](https://data.heroku.com/)
4. Set [Heroku environment variable](https://devcenter.heroku.com/articles/config-vars#using-the-heroku-cli) with name `ConnectionStrings__PostgreSQL`
```value
User ID={user};Password={paswword};Host={host};Port=5432;Database={database};Pooling=true;SslMode=Require;TrustServerCertificate=True;
```
5. Configure `APP_NAME` and `HEROKU_API_KEY` secrets [see more](https://codeburst.io/deploy-a-containerized-asp-net-core-app-to-heroku-using-github-actions-9e54c72db943)
6. Create action with this [workflow](https://github.com/ming-tsai/EmpiresPuzzlesAPI/blob/master/.github/workflows/dotnetcore.yml)

7. Run workflow
8. Open swagger endpoint `{APP_NAME}.herokuapp.com/swagger`
9. Open GraphQL endpoint `{APP_NAME}.herokuapp.com/graphql`

# Examples in GraphQL
This is an example for getting full fileds of heroes information.
```graphql
query getFullFields {
  heroes {
    name
    stars
    color
    teamCost
    maxPower
    maxAttack
    maxDefense
    maxHealth
    maxLevel
    fandomWikiURI
    heroSpeed {
      description
    }
  }
}
```

This is an example for getting hero by name
```graphql
query getByName {
  hero(name: "Thorne") {
    name
    stars
    color
    teamCost
    maxPower
    maxAttack
    maxDefense
    maxHealth
    maxLevel
    fandomWikiURI
    heroSpeed {
      description
    }
  }
}
```
# Environments
[Swagger Environment](https://empires-puzzles-api.herokuapp.com/swagger)

[GraphQL Environment](https://empires-puzzles-api.herokuapp.com/graphql)

# References

[Deploy a Containerized ASP.NET Core App to Heroku using GitHub Actions](https://codeburst.io/deploy-a-containerized-asp-net-core-app-to-heroku-using-github-actions-9e54c72db943)

[GraphL](https://graphql.org/)

[GraphQL with NetCore API](https://learnmoreseekmore.blogspot.com/2019/11/graphql-api-integration-in-aspnet-core.html)

[GraphQL UI on dotnet core](https://github.com/JosephWoodward/graphiql-dotnet)

[Empires and puzzles fandom wiki](https://empiresandpuzzles.fandom.com/wiki/Home)
