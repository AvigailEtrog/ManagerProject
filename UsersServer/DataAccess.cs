
using System;
using System.Data;
using System.Data.SqlClient;
namespace UsersServer
{
    public class DataAccess
    {
        public int InsertCategory(string connectionString) {

            string  CategoryName;
            Console.WriteLine("enter CategoryName");
            CategoryName = Console.ReadLine();


            string query = "INSERT INTO Categories(CategoryName)" +
                "Values(@CategoryName)";
            using (SqlConnection cn = new SqlConnection(connectionString))
            using (SqlCommand cmd =new SqlCommand(query, cn))
            {
                cmd.Parameters.Add("@CategoryName", SqlDbType.VarChar, 20).Value = CategoryName;
                cn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                cn.Close();
                return rowsAffected;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
            }
        }


        public int InsertProduct(string connectionString)
        {

            string CategoryId, ProductName, ProductPrice, ProductDescription, ProductImage;
            Console.WriteLine("enter CategoryId");
            CategoryId = Console.ReadLine();
            Console.WriteLine("enter ProductName");
            ProductName = Console.ReadLine();
            Console.WriteLine("enter ProductPrice");
            ProductPrice = Console.ReadLine();
            Console.WriteLine("enter ProductDescription");
            ProductDescription = Console.ReadLine();
            Console.WriteLine("enter ProductImage");
            ProductImage = Console.ReadLine();

            string query = "insert into Products(CategoryId,ProductName,ProductPrice,ProductDescription,ProductImage)" +
                "Values(@CategoryId,@ProductName,@ProductPrice,@ProductDescription,@ProductImage)";
            using (SqlConnection cn = new SqlConnection(connectionString)) 
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.Add("@CategoryId", SqlDbType.Int).Value = CategoryId;
                cmd.Parameters.Add("@ProductName", SqlDbType.VarChar,20).Value = ProductName;
                cmd.Parameters.Add("@ProductPrice", SqlDbType.Int).Value = ProductPrice;
                cmd.Parameters.Add("@ProductDescription", SqlDbType.VarChar,100).Value = ProductDescription;
                cmd.Parameters.Add("@ProductImage", SqlDbType.VarChar,50).Value = ProductImage;


                cn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                cn.Close();
                return rowsAffected;
            }
        }
      internal void readData(string connectionString)
       {
            string query = "select p.* ,c.*" +
                    "from Products p join Categories c " +
                    "on  p.CategoryId=c.Id";
            using(SqlConnection cn=new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, cn);
                try
                {
                    cn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}",
                            reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7]);
                    }
                    reader.Close();

                }
                catch (Exception ex )
                {

                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();

            }
                
        
        
        
        
        }

    }
}
