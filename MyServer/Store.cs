using MyServer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyServer
{
    static internal class Store
    {
        public static BindingList<Module> Modules = [];
        public static BindingList<Config> Configs = [];
        public static BindingList<Config> Startup = [];
        public static BindingList<MyProgram> Programs = [];
        public static BindingList<Bookmark> Bookmarks = [];
    }
}
