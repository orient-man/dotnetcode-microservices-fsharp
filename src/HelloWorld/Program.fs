namespace MvcApp

open System
open System.Collections.Generic
open System.IO
open System.Threading.Tasks
open Microsoft.AspNetCore.Hosting

module Program =

    [<EntryPoint>]
    let main args =
        let host = 
            WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build()

        host.Run()
        
        0