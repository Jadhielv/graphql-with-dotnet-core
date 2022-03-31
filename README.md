# GraphQL in .NET Core

[![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/Jadhielv/graphql-with-dotnet-core/blob/master/LICENSE)
[![Twitter Follow](https://img.shields.io/twitter/follow/jadhielv?style=social)](https://twitter.com/intent/follow?screen_name=jadhielv)

## Getting Started

This project is a starting point for a learn how you can use GraphQL in **.NET Core**

### How to Use

**GetAll**

```
{
  "data": {
    "jedis": [
      {
        "id": "1",
        "name": "Luke",
        "side": "Light"
      },
      {
        "id": "2",
        "name": "Yoda",
        "side": "Light"
      },
      {
        "id": "3",
        "name": "Darth Vader",
        "side": "Dark"
      }
    ]
  }
}
```

**Working with parameters**

```
{
  "data": {
    "jedi": {
      "name": "Darth Vader"
    }
  }
}
```

## License
<!--- If you're not sure which open license to use see https://choosealicense.com/--->

This project uses the following license -> [MIT](<https://choosealicense.com/licenses/mit/>)
