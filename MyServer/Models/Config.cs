using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyServer.Model
{
    public class Config
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string FilePath { get; set; }
        public string? Argument { get; set; }
        public bool Hidden { get; set; }
        public bool Startup { get; set; }
        public required Module Module { get; set; }
        public string FullName { get => Module.Name + " - " + Name; }
    }
}
