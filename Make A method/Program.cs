using System;
using System.Transactions;

namespace Make_A_method
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            age = DesplayGetUserAge();
        }

       
        
        
        static int DesplayGetUserAge()
        {
            int age;
            string userResponse;
            bool validResponce;

            do
            {
                validResponce = true;

                Console.Write("Enter age.");
                userResponse = Console.ReadLine();

                if (!int.TryParse(userResponse, out age))
                {
                    Console.WriteLine("Please Enter Valid Age");
                    validResponce = false;
                }

            } while (!validResponce);


            return age;

           
           
            
            
        } 
        
    }
}
