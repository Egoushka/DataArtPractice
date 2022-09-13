using System;
using DataArt.Tasks;

namespace DataArt;

public static class HomeworkExecuter
{
    public static void SecondHomework()
    {
        var homework = new SecondHomework();

        Console.WriteLine(homework.MyFavoriteSongText());
        NextTask();
        Console.WriteLine(homework.LittleBunny());
        NextTask();
        Console.WriteLine(homework.GetTableWithData());
    }
    public static void ThirdHomework()
    {
        var homework = new ThirdHomework();

        Console.WriteLine($"Average temperature - {homework.FindAverageTemperature()}");
        NextTask();
        Console.WriteLine($"Average count of candy - {homework.FindAverageNumberOfCandies()}");
        NextTask();
        homework.ResolveMoneyIssue();
        NextTask();
        homework.ResolveSalaryIssue();

    }
    private static void NextTask()
    {
        Console.WriteLine();
    }
}