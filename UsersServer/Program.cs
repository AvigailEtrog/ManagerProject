using System;
using UsersServer;
namespace UsersServer;
class Program
{
    static DataAccess d = new DataAccess();
static void Main(string[] args)
    
    {
        //int rowsAffected=d.InsertCategory("Data Source=SRV2\\PUPILS;Initial Catalog=AdoNetUsers;Integrated Security=True");
        //Console.WriteLine(rowsAffected +" rows affacted");
        //int rowsAffected = d.InsertProduct("Data Source=SRV2\\PUPILS;Initial Catalog=AdoNetUsers;Integrated Security=True");
        //Console.WriteLine(rowsAffected + " rows affacted");
        d.readData("Data Source=SRV2\\PUPILS;Initial Catalog=AdoNetUsers;Integrated Security=True");
    }

}


