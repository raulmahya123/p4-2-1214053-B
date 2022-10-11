using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Hasil
    {
        private string myType;
        private string myTitle;

        public Hasil()
        {

        }
        public Hasil(string type, string title)
        {
            this.myType = type;
            this.myTitle = title;

        }
        public string MyType //property
        {
            get
            {
                return myType;
            }
            set
            {
                myType = value;
            }
        }
        public string MyTitle
        {
            get
            {
                return myTitle;
            }
            set
            {
                myTitle = value;
            }
        }
    }
}
