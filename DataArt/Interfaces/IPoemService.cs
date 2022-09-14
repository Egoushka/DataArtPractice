using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataArt.Interfaces
{
    internal interface IPoemService
    {
        public Task<string> GetPoemAsync();
    }
}
