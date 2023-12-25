using WebNet3.Services;

namespace WebNet3.Models;

public class Dict
{
    public static Dictionary<int, string> Date()
    {
        var dateDictionary = new Dictionary<int, string>();

        var filePath = "ADA.csv";

        var records = CSVService.ReadCSV<Ada>(filePath);

        int count = 1;
        foreach (var record in records)
        {
            dateDictionary.Add(count, record.date);
            count++;
        }

        return dateDictionary;
    }
}