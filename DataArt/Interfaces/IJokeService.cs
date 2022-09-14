using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataArt.Interfaces
{
    internal interface IJokeService
    {
        public Task<string> GetJokeAsync();
    }
}
