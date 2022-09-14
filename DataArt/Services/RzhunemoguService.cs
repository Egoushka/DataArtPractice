using DataArt.Interfaces;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataArt.Services
{
    internal class RzhunemoguService : IJokeService
    {
        private HttpClient Client { get; set; } 
        public RzhunemoguService()
        {
            Client = new HttpClient();
            
        }
        public async Task<string> GetJokeAsync()
        {
            var result = "";
            try
            {
                HttpResponseMessage response = await Client.GetAsync("http://rzhunemogu.ru/RandJSON.aspx?CType=1");
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();

                var obj = JObject.Parse(responseBody);
                result = obj["content"].ToString();

            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            return result;
        }
    }
}
