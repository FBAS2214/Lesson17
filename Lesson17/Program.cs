using Serilog;
using Serilog.Sinks.SystemConsole.Themes;
using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace MyApp
{
    class Program
    {
        static void Main()
        {
            // Regex, Log, Ildasm, Questions


            string? txt = null;
            string? pattern = @"^The.*Spain$";
            Regex regex = new Regex(pattern);


            // txt = "The rain in Spain";
            // if (regex.IsMatch(txt))
            //     Console.WriteLine("Match");
            // else
            //     Console.WriteLine("No match");







            // txt = "bzzz";
            // pattern = "[a-m]"; // [a-mA-M]
            // regex = new Regex(pattern);
            // 
            // if (regex.IsMatch(txt))
            //     Console.WriteLine("Match");
            // else
            //     Console.WriteLine("No match");






            // txt = "6789";
            // pattern = "[0-5]";
            // regex = new Regex(pattern);
            // 
            // if (regex.IsMatch(txt))
            //     Console.WriteLine("Match");
            // else
            //     Console.WriteLine("No match");





            // MailAddress m = new MailAddress(emailaddress);



            // pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            // 
            // while (true)
            // {
            //     txt = Console.ReadLine();
            // 
            //     if (Regex.IsMatch(txt, pattern))
            //         Console.WriteLine("Match");
            //     else
            //         Console.WriteLine("No match");
            // }










            // ///////////////////////////////////
            // 
            // string format = "[{Timestamp:HH:mm:ss} {Level:u3}] {Message} {Exception} {ThreadId} // {MachineName} {NewLine}";
            // 
            // Log.Logger = new LoggerConfiguration()
            //     .WriteTo.Console(outputTemplate: format, theme: AnsiConsoleTheme.Code)
            //     //.WriteTo.ColoredConsole(outputTemplate: format)
            //     //.WriteTo.MSSqlServer("conStr")
            //     .WriteTo.File("myLog.txt", outputTemplate: format)
            //     .Enrich.WithMachineName()
            //     .Enrich.WithThreadId()
            //     .CreateLogger();
            // 
            // 
            // 
            // 
            // Log.Error(new NullReferenceException("ExMsg"), "MessageError");
            // Log.Information("MessageInfo");
            // Log.Warning("MessageWarning");
            // Log.Fatal("MessageFatal");

        }
    }
}

