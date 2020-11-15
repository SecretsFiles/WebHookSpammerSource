using System;
using System.Collections.Specialized;
using System.Threading;

namespace Discord_Webhook_Spammer
{
    class Load
    {
        static string webhook = "";
        static string message = "";
        static string name = "";
        static string avatar = "";

        static void Main(string[] args)
        {

            char opcion;
            String continuar;

            do
            {
                Console.Title = "WebHook Spammer - Secrets Files";
                Console.WindowHeight = 27;
                Console.BufferHeight = 27;
                Console.WindowWidth = 120;
                Console.BufferWidth = 120;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("            ███████╗███████╗ ██████╗██████╗ ███████╗████████╗███████╗    ███████╗██╗██╗     ███████╗███████╗");
                Console.WriteLine("            ██╔════╝██╔════╝██╔════╝██╔══██╗██╔════╝╚══██╔══╝██╔════╝    ██╔════╝██║██║     ██╔════╝██╔════╝");
                Console.WriteLine("            ███████╗█████╗  ██║     ██████╔╝█████╗     ██║   ███████╗    █████╗  ██║██║     █████╗  ███████╗");
                Console.WriteLine("            ╚════██║██╔══╝  ██║     ██╔══██╗██╔══╝     ██║   ╚════██║    ██╔══╝  ██║██║     ██╔══╝  ╚════██║");
                Console.WriteLine("            ███████║███████╗╚██████╗██║  ██║███████╗   ██║   ███████║    ██║     ██║███████╗███████╗███████║");
                Console.WriteLine("            ╚══════╝╚══════╝ ╚═════╝╚═╝  ╚═╝╚══════╝   ╚═╝   ╚══════╝    ╚═╝     ╚═╝╚══════╝╚══════╝╚══════╝");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                                                 WebHook Spammer");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("                                           --------------------------");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  [");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("1");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("] | Español");
                Console.WriteLine("");
                Console.Write("  [");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("2");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("] | English");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Credits: Secrets Files and Alecchernobyl");

                do
                {
                    opcion = Console.ReadKey(true).KeyChar;
                }
                while (opcion < '1' || opcion > '4');

                switch (opcion)
                {
                    case '1':
                        {
                            Console.WindowHeight = 27;
                            Console.BufferHeight = 27;
                            Console.WindowWidth = 120;
                            Console.BufferWidth = 120;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("            ███████╗███████╗ ██████╗██████╗ ███████╗████████╗███████╗    ███████╗██╗██╗     ███████╗███████╗");
                            Console.WriteLine("            ██╔════╝██╔════╝██╔════╝██╔══██╗██╔════╝╚══██╔══╝██╔════╝    ██╔════╝██║██║     ██╔════╝██╔════╝");
                            Console.WriteLine("            ███████╗█████╗  ██║     ██████╔╝█████╗     ██║   ███████╗    █████╗  ██║██║     █████╗  ███████╗");
                            Console.WriteLine("            ╚════██║██╔══╝  ██║     ██╔══██╗██╔══╝     ██║   ╚════██║    ██╔══╝  ██║██║     ██╔══╝  ╚════██║");
                            Console.WriteLine("            ███████║███████╗╚██████╗██║  ██║███████╗   ██║   ███████║    ██║     ██║███████╗███████╗███████║");
                            Console.WriteLine("            ╚══════╝╚══════╝ ╚═════╝╚═╝  ╚═╝╚══════╝   ╚═╝   ╚══════╝    ╚═╝     ╚═╝╚══════╝╚══════╝╚══════╝");
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("                                      Info: El avatar y el nombre es opcional");
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("                                           --------------------------");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.Write("  [");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("+");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("] Ingrese la URL del webhook: ");
                            webhook = Console.ReadLine();

                            Console.Write("  [");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("+");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("] Ingrese el nombre de usuario: ");
                            name = Console.ReadLine();
                            Console.WriteLine("");

                            Console.Write("  [");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("+");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("] Ingrese el mensaje: ");
                            message = Console.ReadLine();
                            Console.WriteLine("");

                            Console.Write("  [");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("+");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("] Ingrese la URL del avatar: ");
                            avatar = Console.ReadLine();

                            Console.Clear();

                            while (true)
                            {
                                spammerES();
                            }
                        }

                    case '2':
                        {
                            Console.WindowHeight = 27;
                            Console.BufferHeight = 27;
                            Console.WindowWidth = 120;
                            Console.BufferWidth = 120;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("            ███████╗███████╗ ██████╗██████╗ ███████╗████████╗███████╗    ███████╗██╗██╗     ███████╗███████╗");
                            Console.WriteLine("            ██╔════╝██╔════╝██╔════╝██╔══██╗██╔════╝╚══██╔══╝██╔════╝    ██╔════╝██║██║     ██╔════╝██╔════╝");
                            Console.WriteLine("            ███████╗█████╗  ██║     ██████╔╝█████╗     ██║   ███████╗    █████╗  ██║██║     █████╗  ███████╗");
                            Console.WriteLine("            ╚════██║██╔══╝  ██║     ██╔══██╗██╔══╝     ██║   ╚════██║    ██╔══╝  ██║██║     ██╔══╝  ╚════██║");
                            Console.WriteLine("            ███████║███████╗╚██████╗██║  ██║███████╗   ██║   ███████║    ██║     ██║███████╗███████╗███████║");
                            Console.WriteLine("            ╚══════╝╚══════╝ ╚═════╝╚═╝  ╚═╝╚══════╝   ╚═╝   ╚══════╝    ╚═╝     ╚═╝╚══════╝╚══════╝╚══════╝");
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("                                        Info: Avatar and name is optional");
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("                                           --------------------------");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.Write("  [");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("+");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("] Please Input the Webhook URL: ");
                            webhook = Console.ReadLine();
                            Console.WriteLine("");
                            Console.Write("  [");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("+");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("] Please Input the Username: ");
                            name = Console.ReadLine();
                            Console.WriteLine("");

                            Console.Write("  [");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("+");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("] Please Input the message: ");
                            message = Console.ReadLine();
                            Console.WriteLine("");

                            Console.Write("  [");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("+");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("] Please Input the Avatar URL: ");
                            avatar = Console.ReadLine();

                            Console.Clear();

                            while (true)
                            {
                                spammerEN();
                            }

                        }
                }
                continuar = Console.ReadLine();
                Console.WriteLine("\n");
            }
            while (continuar != "n");
        }
        static async void spammerEN()
        {
            try
            {
                Thread.Sleep(200);
                _ = Http.Post(webhook, new NameValueCollection()
                {
                {
                    "username",
                    name

                },
                {
                    "avatar_url",
                    avatar

                },
                {
                    "content",
                    message
                },


            });
                Console.WindowHeight = 27;
                Console.BufferHeight = 28;
                Console.WindowWidth = 120;
                Console.BufferWidth = 120;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(DateTime.Now.ToString("[hh:mm:ss]") + " ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[+] Successfully send Webhook!");
            }
            catch
            {
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(DateTime.Now.ToString("[hh:mm:ss]") + " ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[-] Couldn't send Webhook!");
            }
        }
        static async void spammerES()
        {
            try
            {
                Thread.Sleep(200);
                _ = Http.Post(webhook, new NameValueCollection()
                {
                {
                    "username",
                    name

                },
                {
                    "avatar_url",
                    avatar

                },
                {
                    "content",
                    message
                },


            });
                Console.WindowHeight = 27;
                Console.BufferHeight = 28;
                Console.WindowWidth = 120;
                Console.BufferWidth = 120;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(System.DateTime.Now.ToString("[hh:mm:ss]") + " ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[+] Webhook enviado correctamente!");
            }
            catch
            {
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(System.DateTime.Now.ToString("[hh:mm:ss]") + " ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[-] No se pudo enviar el Webhook!");
            }
        }
    }
}
