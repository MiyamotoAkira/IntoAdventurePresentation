using System;
using Microsoft.Owin.Hosting;
using System.Net.Http;
using ClassesAndInterfaces;

namespace OwinSelfHost
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9000/"; 

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress)) 
            { 
                // Create HttpCient and make a request to api/values 
                HttpClient client = new HttpClient(); 

                var response = client.GetAsync(baseAddress + "weapons").Result; 

                Console.WriteLine(response); 
                Console.WriteLine(response.Content.ReadAsStringAsync().Result); 

                response = client.GetAsync(baseAddress + "weapons/1/getrandomdamage").Result; 

                Console.WriteLine(response); 
                Console.WriteLine(response.Content.ReadAsStringAsync().Result); 
            } 

            Console.ReadLine(); 
        }
    }
}
