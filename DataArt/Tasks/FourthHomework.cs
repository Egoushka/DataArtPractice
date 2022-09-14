using DataArt.Data;

namespace DataArt.Tasks;

public class FourthHomework
{
    public Laptop GetLaptopFromUser()
    {
        var laptop = new Laptop
        {
            Model = GetLaptopModelFromUser(),
            Year = GetLaptopYearFromUser(),
            ProcessorPower = GetLaptopProcessorPowerFromUser(),
            RAM = GetLaptopRamFromUser()
        };

        return laptop;
    }

    private string GetLaptopModelFromUser()
    {
        Console.WriteLine("Specify laptop model in input below:");
        var model = Console.ReadLine() ?? throw new InvalidOperationException();

        return model;
    }
    private int GetLaptopYearFromUser()
    {
        Console.WriteLine("Specify laptop year in input below:");
        var year = Console.ReadLine()!;

        int.TryParse(year, out var result);
        
        return result;
        
    }
    private double GetLaptopProcessorPowerFromUser()
    {
        Console.WriteLine("Specify laptop processor power in input below:");
        var processorPower = Console.ReadLine() ?? throw new InvalidOperationException();
        
        double.TryParse(processorPower, out var result);
        
        return result;
    }
    private int GetLaptopRamFromUser()
    {
        Console.WriteLine("Specify laptop ram in input below:");
        var ram = Console.ReadLine() ?? throw new InvalidOperationException();

        int.TryParse(ram, out var result);
        
        return result;
    }
 
}