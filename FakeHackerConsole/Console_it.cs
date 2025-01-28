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
    public class Console_it
    {
        public static void Main()
        {
            int scelta;

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                disegnaMenu();
                do
                    Console.Write("$ > ");
                while (!int.TryParse(Console.ReadLine(), out scelta));
                Console.Clear();
                switch (scelta)
                {
                    case 0:
                        Console.WriteLine("Uscita - Chiudi questa finestra");
                        break;
                    case 1:
                        attaccodos();
                        break;
                    case 2:
                        installaVirus();
                        break;
                    case 3:
                        crackPassword();
                        break;
                    case 4:
                        encryptFile();
                        break;
                    case 5:
                        decryptFile();
                        break;
                    case 6:
                        fakeIPTrace();
                        break;
                    case 7:
                        scanNetwork();
                        break;
                    case 8:
                        hackSocialMedia();
                        break;
                    case 100:
                        infocrediti();
                        break;
                    default:
                        Console.WriteLine("Opzione non disponibile!");
                        break;
                }
                Console.ReadKey();
            }
            while (scelta != 0);
        }

        private static void infocrediti()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("==============================================");
            Console.WriteLine("        FAKE HACKER CONSOLE - INFO & CREDITI ");
            Console.WriteLine("==============================================");
            Console.WriteLine();

            Console.WriteLine(" Progetto: Fake Hacker Console");
            Console.WriteLine(" Creato da: HighMark (Marco)");
            Console.WriteLine(" Diritti: (C) All rights reserved");
            Console.WriteLine();

            Console.WriteLine(" Sito ufficiale: http://fakehackerconsole.chickenkiller.com/");
            Console.WriteLine(" Termini di Servizio (ToS): http://fakehackerconsole.chickenkiller.com/tos");
            Console.WriteLine(" Codice sorgente: https://github.com/HighMark-31/fakehackerconsole");
            Console.WriteLine(" Contatti e richieste: https://highmark.it/");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" REGOLAMENTO DI UTILIZZO E REDISTRIBUZIONE:");
            Console.WriteLine(" - E' consentito l'uso e la modifica del software, MA i diritti devono restare a HighMark.");
            Console.WriteLine(" - NON e' consentita la redistribuzione senza autorizzazione.");
            Console.WriteLine(" - Per distribuire il software, e' necessario contattare HighMark tramite i contatti presenti sul sito.");
            Console.WriteLine();

            Console.ResetColor();
            Console.WriteLine("Premi un tasto per tornare al menu...");
            Console.ReadKey();
        }



        private static void installaVirus()
        {
            Console.WriteLine("*------------------------------*");
            Console.WriteLine("* Installa VIRUS nel pc nemico *");
            Console.WriteLine("*------------------------------*");
            Console.Write("Inserisci IP target: ");
            string ip = Console.ReadLine();
            Console.Write("Inserisci sistema operativo (es: Windows, macOS, Linux): ");
            string os = Console.ReadLine();
            Console.WriteLine($"\nConnettendo a {ip} ({os})...");
            Thread.Sleep(1500);
            fakeProgressBar("Preparazione exploit", 10);
            Console.WriteLine("Injecting codice malevolo...");
            Thread.Sleep(2000);
            fakeProgressBar("Distribuzione payload", 20);
            Console.WriteLine("Esecuzione virus in corso...");
            Thread.Sleep(2000);
            Console.WriteLine("\n[VIRUS INSTALLATO CON SUCCESSO]");
        }

        private static void attaccodos()
        {
            Console.WriteLine("*-------------------------*");
            Console.WriteLine("*   Attacco DOS / DDOS    *");
            Console.WriteLine("*-------------------------*");
            Console.Write("Inserisci IP target: ");
            string ip = Console.ReadLine();
            Console.WriteLine("\nPreparazione pacchetti...");
            Thread.Sleep(1000);
            fakeProgressBar("Preparazione rete", 15);
            Console.WriteLine("Avvio attacco...");
            Thread.Sleep(2000);
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine($"Invio pacchetto #{i + 1} a {ip}...");
                Thread.Sleep(100);
            }
            Console.WriteLine("\n[ATTACCO COMPLETATO]");
        }

        private static void crackPassword()
        {
            Console.WriteLine("*----------------------*");
            Console.WriteLine("* Crack Password Tool *");
            Console.WriteLine("*----------------------*");
            Console.Write("Inserisci hash della password: ");
            string hash = Console.ReadLine();
            Console.WriteLine("\nAnalisi hash...");
            Thread.Sleep(1500);
            fakeProgressBar("Tentativi brute-force", 30);
            Console.WriteLine("\nPassword trovata: 'P@ssw0rd123' (simulazione)");
        }

        private static void encryptFile()
        {
            Console.WriteLine("*---------------------*");
            Console.WriteLine("* Encrypt File Tool  *");
            Console.WriteLine("*---------------------*");
            Console.Write("Inserisci percorso file da criptare: ");
            string path = Console.ReadLine();
            Console.WriteLine($"\nCriptazione file '{path}'...");
            Thread.Sleep(2000);
            fakeProgressBar("Processo criptazione", 25);
            Console.WriteLine("\n[FILE CRIPTATO CON SUCCESSO]");
        }

        private static void decryptFile()
        {
            Console.WriteLine("*---------------------*");
            Console.WriteLine("* Decrypt File Tool  *");
            Console.WriteLine("*---------------------*");
            Console.Write("Inserisci percorso file da decriptare: ");
            string path = Console.ReadLine();
            Console.WriteLine($"\nDecriptazione file '{path}'...");
            Thread.Sleep(2000);
            fakeProgressBar("Processo decriptazione", 25);
            Console.WriteLine("\n[FILE DECRIPTATO CON SUCCESSO]");
        }

        private static void fakeIPTrace()
        {
            Console.WriteLine("*--------------------*");
            Console.WriteLine("*    IP Tracing      *");
            Console.WriteLine("*--------------------*");
            Console.Write("Inserisci IP target: ");
            string ip = Console.ReadLine();
            Console.WriteLine("\nTracciamento in corso...");
            Thread.Sleep(2000);
            fakeProgressBar("Raccolta dati", 15);

            string[] locations = {
        "Berlino, Germania",
        "Parigi, Francia",
        "New York, USA",
        "Tokyo, Giappone",
        "Londra, Regno Unito",
        "Sydney, Australia",
        "Mosca, Russia",
        "Roma, Italia",
        "Madrid, Spagna",
        "Toronto, Canada",
        "Pechino, Cina",
        "Dubai, Emirati Arabi Uniti",
        "Rio de Janeiro, Brasile",
        "Cape Town, Sudafrica",
        "Mumbai, India"
    };

            Random random = new Random();
            string randomLocation = locations[random.Next(locations.Length)];

            Console.WriteLine($"\nLocalità trovata: {ip} - {randomLocation}");
        }

        private static void scanNetwork()
        {
            Console.WriteLine("*---------------------*");
            Console.WriteLine("* Network Scan Tool  *");
            Console.WriteLine("*---------------------*");
            Console.WriteLine("\nScansione rete in corso...");
            Thread.Sleep(3000);
            fakeProgressBar("Rilevamento host", 20);
            Console.WriteLine("\nHost trovati:");
            Console.WriteLine(" - 192.168.1.1 (Router)");
            Console.WriteLine(" - 192.168.1.10 (PC)");
            Console.WriteLine(" - 192.168.1.20 (Smartphone)");
        }

        private static void hackSocialMedia()
        {
            Console.WriteLine("*-------------------------*");
            Console.WriteLine("* Hack Social Media Tool *");
            Console.WriteLine("*-------------------------*");
            Console.Write("Inserisci username: ");
            string username = Console.ReadLine();
            Console.WriteLine($"\nGenerazione exploit per {username}...");
            Thread.Sleep(2000);
            fakeProgressBar("Accesso al profilo", 20);
            Console.WriteLine("\n[ACCESSO COMPLETATO]");
        }

        private static void fakeProgressBar(string messaggio, int steps)
        {
            Console.Write($"{messaggio}: [");
            for (int i = 0; i <= steps; i++)
            {
                Console.Write("=");
                Thread.Sleep(100);
            }
            Console.WriteLine("]");
        }

        private static void disegnaMenu()
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
            Console.WriteLine(" FakeHackerConsole IT - HighMark (Marco) @ All rights reserved - highmark.it");
            Console.WriteLine("====================================================================================================");

            Console.WriteLine(" SELEZIONA UN'OPZIONE: ");
            Console.WriteLine("| 1: Attacco DOS / DDOS [IP]");
            Console.WriteLine("| 2: Installa virus nel pc nemico");
            Console.WriteLine("| 3: Crack Password");
            Console.WriteLine("| 4: Criptazione File");
            Console.WriteLine("| 5: Decriptazione File");
            Console.WriteLine("| 6: Geolocalizzazione IP");
            Console.WriteLine("| 7: Scan Network");
            Console.WriteLine("| 8: Hack Social Media");
            Console.WriteLine("- 100: Informazioni & Crediti");
            Console.WriteLine("- 0: Esci");
            Console.WriteLine();

            Console.WriteLine("--> Visita il sito ufficiale: http://fakehackerconsole.chickenkiller.com/");
            Console.WriteLine("--> Source Code GitHub: https://github.com/HighMark-31/fakehackerconsole");
            Console.WriteLine("--> Progetto by HighMark: https://highmark.it/");

            Console.ResetColor();
        }


    }
}
