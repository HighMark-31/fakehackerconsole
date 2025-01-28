using System.Text;

/* 
 __    __  __            __        __       __                      __       
/  |  /  |/  |          /  |      /  \     /  |                    /  |      
$$ |  $$ |$$/   ______  $$ |____  $$  \   /$$ |  ______    ______  $$ |   __ 
$$ |__$$ |/  | /      \ $$      \ $$$  \ /$$$ | /      \  /      \ $$ |  /  |
$$    $$ |$$ |/$$$$$$  |$$$$$$$  |$$$$  /$$$$ | $$$$$$  |/$$$$$$  |$$ |_/$$/ 
$$$$$$$$ |$$ |$$ |  $$ |$$ |  $$ |$$ $$ $$/$$ | /    $$ |$$ |  $$/ $$   $$<  
$$ |  $$ |$$ |$$ \__$$ |$$ |  $$ |$$ |$$$/ $$ |/$$$$$$$ |$$ |      $$$$$$  \ 
$$ |  $$ |$$ |$$    $$ |$$ |  $$ |$$ | $/  $$ |$$    $$ |$$ |      $$ | $$  |
$$/   $$/ $$/  $$$$$$$ |$$/   $$/ $$/      $$/  $$$$$$$/ $$/       $$/   $$/ 
              /  \__$$ |                                                     
              $$    $$/                                                      
               $$$$$$/                                                       

*************************************          Created by HighMark [Highmark.it]              ***********************************************
*************************************          All rights reserved at HighMark                ***********************************************
*************************    Respect the license of use : use , modify and give rights at me    *********************************************/


namespace FakeHackerConsole
{
    internal class Program
    {
        private static string configPath = Path.Combine("C:/HighMarkAPP/FakeHackerConsole", "config.ini");

        static void Main(string[] args)
        {
            EnsureConfigExists();

            string[] configLines = File.ReadAllLines(configPath);

            if (configLines.Length < 2 || configLines[1].Trim() != "accepted")
            {
                SetupLanguageAndDisclaimer();
            }
            else
            {
                string language = configLines[0].Trim();
                switch (language)
                {
                    case "it":
                        Console_it.Main();
                        break;
                    case "en":
                        Console_en.Main();
                        break;
                    default:
                        SetupLanguageAndDisclaimer();
                        break;
                }
            }
        }

        private static void EnsureConfigExists()
        {
            try
            {
                string directoryPath = Path.GetDirectoryName(configPath);

                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                if (!File.Exists(configPath))
                {
                    File.WriteAllText(configPath, "en\nnot_accepted", Encoding.UTF8);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore durante la creazione del file di configurazione: {ex.Message}");
                Environment.Exit(1);
            }
        }

        private static void SetupLanguageAndDisclaimer()
        {
            int scelta;

            do
            {
                DisegnaMenuLingua();
                do
                    Console.Write("$ > ");
                while (!int.TryParse(Console.ReadLine(), out scelta));

                Console.Clear();

                switch (scelta)
                {
                    case 0:
                        Console.WriteLine("Exit - Close this window");
                        return;
                    case 1:
                        File.WriteAllText(configPath, "it\nnot_accepted", Encoding.UTF8);
                        AccettaDisclaimer("it");
                        return;
                    case 2:
                        File.WriteAllText(configPath, "en\nnot_accepted", Encoding.UTF8);
                        AccettaDisclaimer("en");
                        return;
                    default:
                        Console.WriteLine("This option doesn't exist!");
                        break;
                }

                Console.ReadKey();
            } while (scelta != 0);
        }

        private static void AccettaDisclaimer(string language)
        {
            string message = language == "it"
                ? "Devi accettare i Termini di Servizio disponibili su http://fakehackerconsole.chickenkiller.com/tos e confermare che questo programma è un prank creato a scopo di divertimento. Accetti? (s/n)"
                : "You must accept the Terms of Service available at http://fakehackerconsole.chickenkiller.com/tos and confirm that this program is a prank created for entertainment purposes. Do you accept? (y/n)";

            Console.WriteLine(message);
            string risposta = Console.ReadLine()?.Trim().ToLower();

            if (risposta == "s" || risposta == "y")
            {
                Console.WriteLine(language == "it"
                    ? "Grazie per aver accettato. Procediamo!"
                    : "Thank you for accepting. Let's proceed!");

                string[] configLines = File.ReadAllLines(configPath);
                configLines[1] = "accepted";
                File.WriteAllLines(configPath, configLines, Encoding.UTF8);

                if (language == "it")
                    Console_it.Main();
                else
                    Console_en.Main();
            }
            else
            {
                Console.WriteLine(language == "it"
                    ? "Non puoi utilizzare il programma senza accettare i Termini di Servizio. Uscita in corso..."
                    : "You cannot use the program without accepting the Terms of Service. Exiting...");
                Environment.Exit(1);
            }
        }

        private static void DisegnaMenuLingua()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Welcome to the FakeHackerConsole - HighMark(Marco)@All rights reserved ");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("LANGUAGE SELECT");
            Console.WriteLine();
            Console.WriteLine("| 1: Italiano");
            Console.WriteLine("| 2: English");
            Console.WriteLine("- 0: Exit");
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
