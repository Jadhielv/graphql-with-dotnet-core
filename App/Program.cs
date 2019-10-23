using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var schema = Schema.For(@"
                type Jedi {
                    name: String,
                    side: String,
                    id: ID
                }

                type Query {
                    hello: String,
                    jedis: [Jedi],
                    jedi(id: ID): Jedi
                }
                ", _ =>
                {
                    _.Types.Include<Query>();
                });

            var jsonAllData = schema.Execute(_ =>
            {
                _.Query = "{ jedis { id, name, side } }";
            });

            var jsonWParameter = schema.Execute(_ =>
            {
                _.Query = "{ jedi(id: 3) { name } }";
            });

            Console.WriteLine(jsonAllData);
            Console.WriteLine(jsonWParameter);
        }
    }
    public class Query
    {
        [GraphQLMetadata("jedis")]
        public IEnumerable<Jedi> GetJedis()
        {
            return StarWarsDB.GetJedis();
        }

        [GraphQLMetadata("hello")]
        public string GetHello()
        {
            return "Hello Query Class";
        }

        [GraphQLMetadata("jedi")]
        public Jedi GetJedi(int id)
        {
            return StarWarsDB.GetJedis().SingleOrDefault(x => x.Id == id);
        }
    }
}
