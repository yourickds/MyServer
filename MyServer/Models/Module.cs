using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace MyServer.Model
{
    public class Module
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public ICollection<Config>? Configs { get; set; }
    }
}
