using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyServer.Model
{
    public class Domains
    {
        public int Id { get; set; }
        public required string Url { get; set; }
        public required bool GenerateVHost { get; set; }
    }
}
