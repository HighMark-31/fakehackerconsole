using System;
using System.Threading;

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
    public class Console_en
    {
        public static void Main()
        {
            int choice;

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                drawMenu();
                do
                    Console.Write("$ > ");
                while (!int.TryParse(Console.ReadLine(), out choice));
                Console.Clear();
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Exit - Close this window");
                        break;
                    case 1:
                        DOSAttack();
                        break;
                    case 2:
                        InstallVirus();
                        break;
                    case 3:
                        CrackPassword();
                        break;
                    case 4:
                        EncryptFile();
                        break;
                    case 5:
                        DecryptFile();
                        break;
                    case 6:
                        FakeIPTrace();
                        break;
                    case 7:
                        ScanNetwork();
                        break;
                    case 8:
                        HackSocialMedia();
                        break;
                    case 100:
                        creditsInfo();
                        break;
                    default:
                        Console.WriteLine("Option not available!");
                        break;
                }
                Console.ReadKey();
            }
            while (choice != 0);
        }

        private static void creditsInfo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("==============================================");
            Console.WriteLine("        FAKE HACKER CONSOLE - INFO & CREDITS ");
            Console.WriteLine("==============================================");
            Console.WriteLine();

            Console.WriteLine(" Project: Fake Hacker Console");
            Console.WriteLine(" Created by: HighMark (Marco)");
            Console.WriteLine(" Rights: (C) All rights reserved");
            Console.WriteLine();

            Console.WriteLine(" Official website: http://fakehackerconsole.chickenkiller.com/");
            Console.WriteLine(" Terms of Service (ToS): http://fakehackerconsole.chickenkiller.com/tos");
            Console.WriteLine(" Source code: https://github.com/HighMark-31/fakehackerconsole");
            Console.WriteLine(" Contacts and requests: https://highmark.it/");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" USAGE AND REDISTRIBUTION POLICY:");
            Console.WriteLine(" - You are allowed to use and modify the software, BUT the rights must remain with HighMark.");
            Console.WriteLine(" - Redistribution is NOT allowed without authorization.");
            Console.WriteLine(" - To distribute the software, you must contact HighMark through the contacts on the website.");
            Console.WriteLine();

            Console.ResetColor();
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
        }



        private static void InstallVirus()
        {
            Console.WriteLine("*------------------------------*");
            Console.WriteLine("* Install VIRUS on enemy PC   *");
            Console.WriteLine("*------------------------------*");
            Console.Write("Enter target IP: ");
            string ip = Console.ReadLine();
            Console.Write("Enter operating system (e.g., Windows, macOS, Linux): ");
            string os = Console.ReadLine();
            Console.WriteLine($"\nConnecting to {ip} ({os})...");
            Thread.Sleep(1500);
            FakeProgressBar("Preparing exploit", 10);
            Console.WriteLine("Injecting malicious code...");
            Thread.Sleep(2000);
            FakeProgressBar("Deploying payload", 20);
            Console.WriteLine("Executing virus...");
            Thread.Sleep(2000);
            Console.WriteLine("\n[VIRUS INSTALLED SUCCESSFULLY]");
        }

        private static void DOSAttack()
        {
            Console.WriteLine("*-------------------------*");
            Console.WriteLine("*    DOS / DDOS Attack    *");
            Console.WriteLine("*-------------------------*");
            Console.Write("Enter target IP: ");
            string ip = Console.ReadLine();
            Console.WriteLine("\nPreparing packets...");
            Thread.Sleep(1000);
            FakeProgressBar("Preparing network", 15);
            Console.WriteLine("Starting attack...");
            Thread.Sleep(2000);
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine($"Sending packet #{i + 1} to {ip}...");
                Thread.Sleep(100);
            }
            Console.WriteLine("\n[ATTACK COMPLETED]");
        }

        private static void CrackPassword()
        {
            Console.WriteLine("*----------------------*");
            Console.WriteLine("* Crack Password Tool *");
            Console.WriteLine("*----------------------*");
            Console.Write("Enter password hash: ");
            string hash = Console.ReadLine();
            Console.WriteLine("\nAnalyzing hash...");
            Thread.Sleep(1500);
            FakeProgressBar("Brute-force attempts", 30);
            Console.WriteLine("\nPassword found: 'P@ssw0rd123' (simulation)");
        }

        private static void EncryptFile()
        {
            Console.WriteLine("*---------------------*");
            Console.WriteLine("* Encrypt File Tool  *");
            Console.WriteLine("*---------------------*");
            Console.Write("Enter file path to encrypt: ");
            string path = Console.ReadLine();
            Console.WriteLine($"\nEncrypting file '{path}'...");
            Thread.Sleep(2000);
            FakeProgressBar("Encryption process", 25);
            Console.WriteLine("\n[FILE ENCRYPTED SUCCESSFULLY]");
        }

        private static void DecryptFile()
        {
            Console.WriteLine("*---------------------*");
            Console.WriteLine("* Decrypt File Tool  *");
            Console.WriteLine("*---------------------*");
            Console.Write("Enter file path to decrypt: ");
            string path = Console.ReadLine();
            Console.WriteLine($"\nDecrypting file '{path}'...");
            Thread.Sleep(2000);
            FakeProgressBar("Decryption process", 25);
            Console.WriteLine("\n[FILE DECRYPTED SUCCESSFULLY]");
        }

        private static void FakeIPTrace()
        {
            Console.WriteLine("*--------------------*");
            Console.WriteLine("*    IP Tracing      *");
            Console.WriteLine("*--------------------*");
            Console.Write("Enter target IP: ");
            string ip = Console.ReadLine();
            Console.WriteLine("\nTracing in progress...");
            Thread.Sleep(2000);
            FakeProgressBar("Collecting data", 15);

            string[] locations = {
                "Berlin, Germany",
                "Paris, France",
                "New York, USA",
                "Tokyo, Japan",
                "London, United Kingdom",
                "Sydney, Australia",
                "Moscow, Russia",
                "Rome, Italy",
                "Madrid, Spain",
                "Toronto, Canada",
                "Beijing, China",
                "Dubai, United Arab Emirates",
                "Rio de Janeiro, Brazil",
                "Cape Town, South Africa",
                "Mumbai, India"
            };

            Random random = new Random();
            string randomLocation = locations[random.Next(locations.Length)];

            Console.WriteLine($"\nLocation found: {ip} - {randomLocation}");
        }

        private static void ScanNetwork()
        {
            Console.WriteLine("*---------------------*");
            Console.WriteLine("* Network Scan Tool  *");
            Console.WriteLine("*---------------------*");
            Console.WriteLine("\nScanning network...");
            Thread.Sleep(3000);
            FakeProgressBar("Detecting hosts", 20);
            Console.WriteLine("\nHosts found:");
            Console.WriteLine(" - 192.168.1.1 (Router)");
            Console.WriteLine(" - 192.168.1.10 (PC)");
            Console.WriteLine(" - 192.168.1.20 (Smartphone)");
        }

        private static void HackSocialMedia()
        {
            Console.WriteLine("*-------------------------*");
            Console.WriteLine("* Hack Social Media Tool *");
            Console.WriteLine("*-------------------------*");
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.WriteLine($"\nGenerating exploit for {username}...");
            Thread.Sleep(2000);
            FakeProgressBar("Accessing profile", 20);
            Console.WriteLine("\n[ACCESS GRANTED]");
        }

        private static void FakeProgressBar(string message, int steps)
        {
            Console.Write($"{message}: [");
            for (int i = 0; i <= steps; i++)
            {
                Console.Write("=");
                Thread.Sleep(100);
            }
            Console.WriteLine("]");
        }

        private static void drawMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("  ______    _        _    _            _              _____                      _      ");
            Console.WriteLine(" |  ____|  | |      | |  | |          | |            / ____|                    | |     ");
            Console.WriteLine(" | |__ __ _| | _____| |__| | __ _  ___| | _____ _ __| |     ___  _ __  ___  ___ | | ___ ");
            Console.WriteLine(" |  __/ _` | |/ / _ \\  __  |/ _` |/ __| |/ / _ \\ '__| |    / _ \\| '_ \\/ __|/ _ \\| |/ _ \\");
            Console.WriteLine(" | | | (_| |   <  __/ |  | | (_| | (__|   <  __/ |  | |___| (_) | | | \\__ \\ (_) | |  __/");
            Console.WriteLine(" |_|  \\__,_|_|\\_\\___|_|  |_|\\__,_|\\___|_|\\_\\___|_|   \\_____\\___/|_| |_|___/\\___/|_|\\___|");
            Console.WriteLine();

            Console.WriteLine("====================================================================================================");
            Console.WriteLine(" FakeHackerConsole EN - HighMark (Marco) @ All rights reserved - highmark.it");
            Console.WriteLine("====================================================================================================");

            Console.WriteLine(" SELECT AN OPTION: ");
            Console.WriteLine("| 1: DOS / DDOS Attack ");
            Console.WriteLine("| 2: Install a virus on the enemy's PC");
            Console.WriteLine("| 3: Crack Password");
            Console.WriteLine("| 4: File Encryption");
            Console.WriteLine("| 5: File Decryption");
            Console.WriteLine("| 6: IP Geolocation");
            Console.WriteLine("| 7: Network Scan");
            Console.WriteLine("| 8: Social Media Hacking");
            Console.WriteLine("- 100: Information & Credits");
            Console.WriteLine("- 0: Exit");
            Console.WriteLine();

            Console.WriteLine("--> Visit the official website: http://fakehackerconsole.chickenkiller.com/");
            Console.WriteLine("--> Source Code on GitHub: https://github.com/HighMark-31/fakehackerconsole");
            Console.WriteLine("--> Project by HighMark: https://highmark.it/");

            Console.ResetColor();
        }

    }
}