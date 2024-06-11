using static System.Net.Mime.MediaTypeNames;
using System;
using Microsoft.EntityFrameworkCore;

namespace _1_Entity_DbFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            RehberContext rehberContext = new RehberContext();

            var persons = rehberContext.Tables.ToList();

            foreach (var item in persons)
            {
                Console.WriteLine(item.FirstName);
            }


            


        }
    }
}


//Scaffold - DbContext "Server = ENVER\SQLEXPRESS;Database=Rehber;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameWorkCore.SqlServer