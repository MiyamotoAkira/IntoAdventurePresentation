// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

open System
open System.Net.Http
open Microsoft.Owin.Hosting
open Functions

[<EntryPoint>]
let main argv = 
    let baseAddress = "http://localhost:9000/"

    // Start OWIN host 
    use webApp = WebApp.Start<Startup>(url = baseAddress) 
    use client = new HttpClient(); 

    let response = client.GetAsync(baseAddress + "weapons").Result; 

    Console.WriteLine(response); 
    Console.WriteLine(response.Content.ReadAsStringAsync().Result); 


    let response = client.GetAsync(baseAddress + "weapons/1/getrandomdamage").Result; 

    Console.WriteLine(response); 
    Console.WriteLine(response.Content.ReadAsStringAsync().Result); 

    let response = Console.ReadLine();
    0 // return an integer exit code

