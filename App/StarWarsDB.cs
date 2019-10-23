public class StarWarsDB
{
    public static IEnumerable<Jedi> GetJedis() => new List<Jedi>() {
        new Jedi(){ Name ="Luke", Side="Light"},
        new Jedi(){ Name ="Yoda", Side="Light"},
        new Jedi(){ Name ="Darth Vader", Side="Dark"}
        };
}


