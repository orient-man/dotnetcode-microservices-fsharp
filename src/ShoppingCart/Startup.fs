namespace ShoppingCart

open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Owin
open Nancy
open Nancy.Configuration
open Nancy.Owin

type Startup () =
    member __.Configure(app: IApplicationBuilder) =
        app.UseOwin(fun buildFunc -> buildFunc.UseNancy() |> ignore) |> ignore

type TracingBootstrapper () =
    inherit Nancy.DefaultNancyBootstrapper ()
    override __.Configure(env) =
        env.Tracing(enabled = true, displayErrorTraces = true)