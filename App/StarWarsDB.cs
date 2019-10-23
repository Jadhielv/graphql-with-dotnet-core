using System.Collections.Generic;
public class StarWarsDB
{
    public static IEnumerable<Jedi> GetJedis() => new List<Jedi>()
    {
        new Jedi(){ Id=1, Name="Luke", Side="Light" },
        new Jedi(){ Id=2, Name="Yoda", Side="Light" },
        new Jedi(){ Id=3, Name="Darth Vader", Side="Dark" }
    };
}


