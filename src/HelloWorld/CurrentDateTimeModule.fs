namespace HelloWorld

open System
open Nancy

type CurrentDateTimeModule () as this =
    inherit NancyModule ()

    do
        this.Get("/", fun _ -> DateTime.UtcNow)