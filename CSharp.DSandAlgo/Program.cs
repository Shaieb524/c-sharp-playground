using CSharp.DSandAlgo.Algorithms.Helper;
using CSharp.DSandAlgo.Algorithms.Sort;

List<int> list = new List<int> { 5,3,4,7,2,8,6,9,1 };

string[] abbs = 
{
    "En", "Fr", "Gr"
};

string[] countries =
{
    "England", "France", "German"
};

var countryNames = abbs.Zip(countries, (abb, country) =>

    abb + ":" + country
);


Console.WriteLine(abbs.Any());
Console.WriteLine(countries.Contains("Englang"));

var t = countries.Take(2).Select(x => x="England");

foreach (var i in t)
    Console.WriteLine(i);