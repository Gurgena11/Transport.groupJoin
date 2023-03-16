using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
   
internal class Program
    {
        static void Main(string[] args)
        {
            List<transport> trans = new List<transport>()
            {
                new transport() {Name = "boat", Type="sea" },
                new transport() {Name = "jet", Type="air" },
                new transport() {Name = "war ship",Type="sea"  },
                new transport() {Name = "boeing" , Type="air"},
                new transport() {Name = "train", Type="land" },
                new transport() {Name = "bike", Type="land" }
            };

            List<land> lands = new List<land>()
            {
                new land(){type = "sea"},
                new land(){type = "land"},
                new land(){type = "air"}
            };

            var querry = from i in lands
                         join g in trans
                         on i.type equals g.Type
                         into res
                         from x in res
                         group x by x.Type;

            trans.Add(new transport() { Name = "velosapedi", Type = "land"}); 

            foreach (var item in querry)
            {
                Console.WriteLine(item.Key);
                foreach(var i in item)
                {
                    
                        Console.WriteLine($"\t {i.Name}");
                    
                }
            }

                 
            
        }
    }
}
