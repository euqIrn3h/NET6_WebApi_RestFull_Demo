This is a demo web api who implements a RESTFull API of a moovie storage. In this project it was used MySql as database , EF CORE as ORM and .NET 6 environmet to develop the API.

To Migrate the database you need to set the /Env/Env.cs file with this code

    using System;
    namespace ApiRest.Env
    {
        public static class Env
        {
            public static void Variaveis(){
                Environment.SetEnvironmentVariable("CONNECTION", "Server= YourServer; Port= YourPort; Database= YourDatabase; Uid= YourLogin; Pwd= YourPassword;");
            }
        }
    }

and then type o CLI

    dotnet ef migrations add InitialCreate
    dotnet ef database update

then to run the project just type o CLI

    dotnet run