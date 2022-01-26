using Newtonsoft.Json;
using NugetExample;

Mascot nugetMascot = new Mascot()
    {
        name = "NuGet Warior",
        team = "NuGet",
        catchPhrase = "Where packages come to life!"
    };

string json = JsonConvert.SerializeObject(nugetMascot, Formatting.Indented);
Console.WriteLine(json);