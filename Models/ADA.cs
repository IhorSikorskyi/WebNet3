using CsvHelper.Configuration.Attributes;

namespace WebNet3.Models;

public class Ada
{
    [Name("ticker")] public string ticker { get; set; }

    [Name("date")] public string date { get; set; }

    [Name("open")] public string open { get; set; }

    [Name("high")] public string high { get; set; }

    [Name("low")] public string low { get; set; }

    [Name("close")] public string close { get; set; }

}
