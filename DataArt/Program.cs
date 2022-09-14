
using System.Speech.Synthesis;
using System.Text;
using DataArt.Interfaces;
using DataArt.Services;
using DataArt.Tasks;

namespace DataArt
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Configure();

            HomeworkExecuter.FifthHomework();
        }
        public static void Configure()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding.GetEncoding("windows-1254");
        }
     
    }
}

