# GraphQL in .NET Core and C#

Learn how you can use GraphQL in .NET Core and C#

Results:

GetAll

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

Working with parameters

{
  "data": {
    "jedi": {
      "name": "Darth Vader"
    }
  }
}