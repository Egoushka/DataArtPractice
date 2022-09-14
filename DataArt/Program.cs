using System.Text;

namespace DataArt
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Configure();

            HomeworkExecutor.FifthHomework();
        }

        private static void Configure()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding.GetEncoding("windows-1254");
        }
     
    }
}

