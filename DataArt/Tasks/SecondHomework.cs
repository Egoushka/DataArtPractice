using ConsoleTables;
using DataArt.DataProviders;

namespace DataArt.Tasks;

public class SecondHomework
{
    public string MyFavoriteSongText()
    {
        const string verse = "Underneath the bridge, tarp has sprung a leak\n" +
                             "And the animals I've trapped, have all become my pet\n" +
                             "And I'm living off of grass, and the drippings from the ceiling\n" +
                             "It's okay to eat fish 'cause they don't have any feelings\n";


        return verse;
    }
    
    
    public string LittleBunny()
    {
        return "(\\__/)" +
               "\n" +
               "(='.'=)" +
               "\n" +
               "(\")_(\")";
    }
    
    public ConsoleTable GetTableWithData()
    {
        var columnsNames = new[]
        {
            "Department",
            "Product name",
            "Supply",
            "Sales",
            "Profit"
            
        };
        var table = new ConsoleTable(columnsNames);
        
        var data = TableDataProvider.GenerateStaticData();
        foreach (var item in data)
        {
            table.AddRow(item.ToTableRow());
        }

        return table;
    }
}