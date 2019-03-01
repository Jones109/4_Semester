using System;

namespace MyFirstEFCoreProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Commands: l(list), u (change lastname), r (reset database), and e (exit) - and -l to first two for logs");
            Console.WriteLine("Checking if database exist");
            Console.WriteLine(Commands.WipeCreateSeed(true) ? "Created database and seeded it" : "Database exists");

            do {
                Console.Write("> ");
                var command = Console.ReadLine();
                switch (command) {
                    case "l":
                        Commands.ListAll();
                        break;
                        
                    case "l -l":
                        Commands.ListAllWithLogs();
                        break;
                    
                    case "u":
                        Commands.ChangeLastName();
                        break;
                    
                    case "u -l":
                        Commands.ChangeLastNameLogs();
                        break;
                    
                    case "r":
                        Commands.WipeCreateSeed(false);
                        break;
                    
                    case "e":
                        return;
                    
                    default:
                        Console.WriteLine("Unknown command");
                        break;
                }
            } while (true);
        }
    }
}
