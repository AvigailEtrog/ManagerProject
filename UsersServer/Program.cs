using System;
using UsersServer;
namespace UsersServer;
class Program
{
    static DataAccess d = new DataAccess();
static void Main(string[] args)
    
    {
        int rowsAffected;
        bool flag=true;
        string y = "";
        Console.WriteLine("press c for category or p for products");
        string x = Console.ReadLine();
        if (x == "c")
        {
            
            while (flag!=false)
            {
                rowsAffected = d.InsertCategory("Data Source=SRV2\\PUPILS;Initial Catalog=AdoNetProducts;Integrated Security=True");
                Console.WriteLine(rowsAffected + " rows affacted");
                Console.WriteLine("do yo want to continue? y/n");
                y = Console.ReadLine();
                if (y == "n") flag = false;
            }
        }
        else if(x == "p")
        {
             rowsAffected = d.InsertProduct("Data Source=SRV2\\PUPILS;Initial Catalog=AdoNetProducts;Integrated Security=True");
            Console.WriteLine(rowsAffected + " rows affacted");
            Console.WriteLine("do yo want to continue? y/n");
             y = Console.ReadLine();
            if (y == "n") flag = false;
            while (flag != false)
            {
                rowsAffected = d.InsertProduct("Data Source=SRV2\\PUPILS;Initial Catalog=AdoNetProducts;Integrated Security=True");
                Console.WriteLine(rowsAffected + " rows affacted");
                Console.WriteLine("do yo want to continue? y/n");
                y = Console.ReadLine();
                if (y == "f") flag = false;
            }



        }


       
        d.readData("Data Source=SRV2\\PUPILS;Initial Catalog=AdoNetProducts;Integrated Security=True");
    }

}


