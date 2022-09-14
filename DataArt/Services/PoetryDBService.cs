﻿using DataArt.Interfaces;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataArt.Services
{
    internal class PoetryDBService : IPoemService
    {
        private HttpClient Client { get; set; }

        public PoetryDBService()
        {
            Client = new HttpClient();
        }
        public async Task<string> GetPoemAsync()
        {
            var result = "\t";
            try
            {
                HttpResponseMessage response = await Client.GetAsync("https://poetrydb.org/linecount,random/5;1");
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();

                var obj = JArray.Parse(responseBody).First();
                result += string.Join("\n\t", obj["lines"]);

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
