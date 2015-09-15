

namespace Functions
open System
open Owin
open System.Web.Http;

type public Startup() = 
    member this.Configuration (appBuilder : IAppBuilder) = 
        // Configure Web API for self-host. 
        let config = new HttpConfiguration()
        config.MapHttpAttributeRoutes()
        appBuilder.UseWebApi(config) |> ignore

