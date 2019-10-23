using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var schema = Schema.For(@"
                type Jedi {
                    name: String,
                    side: String
                }

                type Query {
                    hello: String,
                    jedis: [Jedi]
                }
                ", _ =>
                {
                    _.Types.Include<Query>();
                });

            var json = schema.Execute(_ =>
            {
                _.Query = "{ jedis { name, side } }";
            });

            Console.WriteLine(json);
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
    }
}
