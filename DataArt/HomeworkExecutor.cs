using System.Text.Json;
using DataArt.Tasks;

namespace DataArt;

public static class HomeworkExecutor
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
    public static void FourthHomework()
    {
        var homework = new FourthHomework();

        var laptop = homework.GetLaptopFromUser();
        
        Console.WriteLine(JsonSerializer.Serialize(laptop));
    }
    public static void FifthHomework()
    {
        var homework = new FifthHomework();

        homework.JokeOrVerse();
        NextTask();
        
        homework.DetermineWhenUserWereBorn();
        NextTask();
        
        homework.GiveUserRightMenuDependsOnAge();
        NextTask();
        
        homework.EnterLoginAndPassword();
        NextTask();
    }
    
    private static void NextTask()
    {
        Console.WriteLine();
    }
}