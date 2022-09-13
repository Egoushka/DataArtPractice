using System;
using System.Collections.Generic;
using System.Linq;

namespace DataArt.Tasks;

public class ThirdHomework
{
    public double FindAverageTemperature()
    {
        var data = new List<double>
        {
            10,
            16.5,
            14.3,
            8
        };
        return data.Average();
    }
    public double FindAverageNumberOfCandies()
    {
        var data = new List<int>
        {
            10,
            15,
            8,
            12
        };
        return data.Average();
    }

    public void ResolveMoneyIssue()
    {
        var random = new Random();
        
        var pirates = random.Next(2, 10);
        var money = random.Next(100, 200);

        var rest = pirates % money;
        var moneyPerPirate = money / pirates;
        Console.WriteLine($"Pirates - {pirates}");
        Console.WriteLine($"Money - {money}");
        
        
        Console.WriteLine($"Every pirate got {moneyPerPirate}");
        Console.WriteLine($"{rest} coins were thrown to sea");
    }
   
    public void ResolveSalaryIssue()
    {
        var random = new Random();

        var firstWorkerHours = random.Next(0, 12);
        var secondWorkerHours = random.Next(0, 12);

        var usdPerHour = random.Next(1, 10);

        var firstWorkerSalary = firstWorkerHours * usdPerHour;
        var secondWorkerSalary = secondWorkerHours * usdPerHour;
        
        Console.WriteLine($"First worker worked {firstWorkerHours} hours and get {firstWorkerSalary}");
        Console.WriteLine($"Second worker worked {secondWorkerHours} hours and get {secondWorkerSalary}");
        
        Console.WriteLine($"They earn {firstWorkerSalary + secondWorkerSalary}");
    }
}