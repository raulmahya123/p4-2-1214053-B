using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Malboro : Hasil
    {
       
             protected String duration;

        public Malboro(string title, string duration) //method dengan construktor pake 2 parameter
        {
            this.MyTitle = title;
            this.MyType = "Malboro";
            this.duration = duration;

            Console.WriteLine("ini dari class rokok");
        }
        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }
    }
    
}
