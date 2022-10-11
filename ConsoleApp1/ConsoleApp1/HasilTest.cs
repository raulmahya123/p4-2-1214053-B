using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class HasilTest
    {
        static void Main(string[] args)
        {
            /*Product_1214053 myProduct = new Product_1214053();

            myProduct.MyType = "DVD";

            Console.WriteLine(myProduct.MyType);*/

            Signature product1 = new Signature("Signature", "Harga", "32000");
            Malboro product2 = new Malboro("Malboro", "Harga");
            Sampurna product3 = new Sampurna("Sampurna", "Harga", "36000");
            Surya product4 = new Surya("Surya", "Harga", "36000");
            Garpit product5 = new Garpit("garpit", "Harga", "36000");
            Camel product6 = new Camel("camel", "Harga", "36000");
            Esseceng product7 = new Esseceng("esseceng", "Harga", "36000");
            Console.WriteLine("product 1 is {0} called \"{1}\" and has {2} batang ", product1.MyType, product1.MyTitle, product1.PageCount);
            Console.WriteLine("product 2 is {0} called \"{1}\" and has {2} duration", product2.MyType, product2.MyTitle, product2.Duration);
            Console.WriteLine("product 3 is {0} called \"{1}\" and has {2} batang ", product3.MyType, product3.MyTitle, product3.PageCount);
            Console.WriteLine("product 4 is {0} called \"{1}\" and has {2} batang ", product4.MyType, product4.MyTitle, product4.PageCount);
            Console.WriteLine("product 5 is {0} called \"{1}\" and has {2} batang ", product5.MyType, product5.MyTitle, product5.PageCount);
            Console.WriteLine("product 6 is {0} called \"{1}\" and has {2} batang ", product6.MyType, product6.MyTitle, product6.PageCount);
            Console.WriteLine("product 7 is {0} called \"{1}\" and has {2} batang ", product7.MyType, product7.MyTitle, product7.PageCount);




            //Console.WriteLine("\" the book {0} has {1} pages\"", myBook.MyTitle, myBook.PageCount);
        }
    }
}
