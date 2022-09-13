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

    private static void NextTask()
    {
        Console.WriteLine();
    }
}