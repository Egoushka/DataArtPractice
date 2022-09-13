using System;
using System.Collections.Generic;
using DataArt.Data;

namespace DataArt.DataProviders;

public class TableDataProvider
{
    public static List<TableItem>GenerateStaticData()
    {
        var result = new List<TableItem>();
        var random = new Random();
        result.Add(new TableItem()
        {
            Department = "Food",
            Products = new List<string>
            {
                "Vegetables",
                "Meet",
                "Drinks"
            },
            Supply = new List<double>
            {
                random.Next(100, 1000),
                random.Next(100, 1000),
                random.Next(100, 1000),
            },
            Sales = new List<double>
            {
                random.Next(100, 1000),
                random.Next(100, 1000),
                random.Next(100, 1000),
            },
            Profit = new List<double>
            {
                random.Next(100, 1000),
                random.Next(100, 1000),
                random.Next(100, 1000),
            }
        });
        result.Add(new TableItem()
        {
            Department = "Household chemicals",
            Products = new List<string>
            {
                "Soap",
                "Cleaners"
            },
            Supply = new List<double>
            {
                random.Next(100, 1000),
                random.Next(100, 1000),
                random.Next(100, 1000),
            },
            Sales = new List<double>
            {
                random.Next(100, 1000),
                random.Next(100, 1000),
                random.Next(100, 1000),
            },
            Profit = new List<double>
            {
                random.Next(100, 1000),
                random.Next(100, 1000),
                random.Next(100, 1000),
            }
        });
        result.Add(new TableItem()
        {
            Department = "Сlothes",
            Products = new List<string>
            {
                "Underwear",
                "Pants",
                "Shirts",
                "Sweaters"

            },
            Supply = new List<double>
            {
                random.Next(100, 1000),
                random.Next(100, 1000),
                random.Next(100, 1000),
            },
            Sales = new List<double>
            {
                random.Next(100, 1000),
                random.Next(100, 1000),
                random.Next(100, 1000),
            },
            Profit = new List<double>
            {
                random.Next(100, 1000),
                random.Next(100, 1000),
                random.Next(100, 1000),
            }
        });
        return result;
    }
    
}