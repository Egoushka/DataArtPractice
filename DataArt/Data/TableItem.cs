using System;
using System.Collections.Generic;

namespace DataArt.Data;

public class TableItem
{
    public string Department { get; set; }
    public List<string> Products { get; set; }
    public List<double> Supply { get; set; }
    public List<double> Sales { get; set; }
    public List<double> Profit { get; set; }

    public object[] ToTableRow()
    {
        return new[]
        {
            Department,
            string.Join(",", Products),
            string.Join(",", Supply),
            string.Join(",", Sales),
            string.Join(",", Profit)
        };

    }
}