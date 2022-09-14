using System;

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
        string model;
        
        Console.WriteLine("Specify laptop model in input below:");
        model = Console.ReadLine();

        return model;
    }
    private int GetLaptopYearFromUser()
    {
        string year;
        
        Console.WriteLine("Specify laptop year in input below:");
        year = Console.ReadLine();
         
        int.TryParse(year, out var result);
        
        return result;
        
    }
    private double GetLaptopProcessorPowerFromUser()
    {
        string processorPower;
        
        Console.WriteLine("Specify laptop processor power in input below:");
        processorPower = Console.ReadLine();
        
        double.TryParse(processorPower, out var result);
        
        return result;
    }
    private int GetLaptopRamFromUser()
    {
        string ram;
        
        Console.WriteLine("Specify laptop ram in input below:");
        ram = Console.ReadLine();

        int.TryParse(ram, out var result);
        
        return result;
    }
 
}