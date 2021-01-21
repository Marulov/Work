using System;

namespace CreateMyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();   // myListimizi oluşturduk ve içine eleman ekledik.
            myList.Add("Kiraz");
            myList.Add("Elma");
            myList.Add("Armut");

            foreach (var item in myList.Items)  //foreach ile myListimizi döndük.
            {
                Console.WriteLine(item);
            }

        }
    }
}
