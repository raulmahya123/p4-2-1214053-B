using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Camel : Hasil
    {
        protected string pageCount;

        public Camel(string type, string title, string pagecount) : base(type, title)

        {
            this.pageCount = pagecount;
        }
        public string PageCount
        {
            get { return pageCount; }
            set { pageCount = value; }
        }
    }
}
