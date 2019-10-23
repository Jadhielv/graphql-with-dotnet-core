using System;
using GraphQL;
using GraphQL.Types;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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

            var root = new { Hello = "Hello World!" };
            var json = schema.Execute(_ =>
            {
                _.Query = "{ hello }";
                _.Root = root;
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
            return "Hello Query class";
        }

        public static IEnumerable<Jedi> GetJedis() => new List<Jedi>() {
                new Jedi() { Name ="Luke", Side="Light"},
                new Jedi() { Name ="Yoda", Side="Light"},
                new Jedi() { Name ="Darth Vader", Side="Dark"}
             };
    }
}
