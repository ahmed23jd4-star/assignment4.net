using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            //Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print
            //the second price(index 1).

            //double[] prices = { 25.5, 40, 33.75 };
            //Console.WriteLine(prices[1]);

            #endregion
            #region q2
            //Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
            //shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.

            //int [,] shelfcopies = { { 3 , 5} , {1 ,4}  } ;
            //Console.WriteLine(shelfcopies[ 1 ,0]);
            //foreach (var item in shelfcopies)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region q3
            //Write a method called PrintWelcomeMessage that takes no parameters and prints
            //"Welcome to the Library!".Call it from Main.

            //PrintWelcomeMessage();

            #endregion
            #region q4
            //Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with
            //"Clean Code".

            //PrintBookTitle("computer science");
            #endregion
            #region q5
            //Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
            //int pages = 400; and print pages afterward. What do you expect to see, and why?
            //int pages = 400;
            //addbonuspages(pages);
            //Console.WriteLine(pages);   // 400 doesn,t change becaouse passing by value and this value type doesn,t change

            #endregion
            #region q6
            //Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
            //with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to
            //see, and why?
            //double[] prices = { 25.5, 40.0 };
            //applydiscount(prices);
            //Console.WriteLine(prices[0]); // actually subtravt becouse that passing by value but the data type is refernce
                                          // so paramter has the same addrese for array prices in heap

            #endregion
        }
        //public static void PrintWelcomeMessage()
        //{
        //    Console.WriteLine("welcime to the library !");
        //}
        ///////////////////////////////////////////////////////////////////////////////////////////////

        //public static void PrintBookTitle (string title)
        //{
        //Console.WriteLine($"book title : {title}");
        //}
        #region method q 5
        //public static void addbonuspages(int pages){
        //    pages += 50;


        //    }
        #endregion
        #region method q6
        //public static void applydiscount(double[] prices)
        //{
        //    prices[0] -= 5;
        //}
        #endregion
    }
}
