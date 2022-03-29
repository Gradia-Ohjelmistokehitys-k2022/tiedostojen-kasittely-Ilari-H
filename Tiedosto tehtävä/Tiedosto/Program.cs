using System;
using System.Linq;

namespace Tiedosto
{
    internal class Program
    {
        public static bool OnOlemassa(string filename)
        {
            return File.Exists(filename);
        }

        public static string[] LueRivitTaulukoksi(string filename)
        {
            string[] rivit;
            rivit = File.ReadAllLines(filename);
            return rivit;
        }



        public static List<string> LuerivitListaksi(string filename)
        {
            string[] rivit = LueRivitTaulukoksi(filename);
            List<string> rivilista = new List<string>();

            return rivilista;
        }



        public static string LueRivitMerkitseJonoksi(string filename)
        {
            string[] rivit = LueRivitTaulukoksi(filename);
            string ret = "";
            foreach (string rivi in rivit)
                ret += rivi;
            return ret;
        }


        
        static void Main(string[] args)
        {
            Console.WriteLine("anna tiedoston nimi; ");
            string tnimi = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Tiedostossa lukee: ");
            Console.WriteLine(File.ReadAllText(@"C:\Ohjelmointi\Tiedosto käsittely\Tiedosto\Tiedosto\bin\Debug\net6.0\teksti.txt"));

            String[] rivit = { "Hello world!", "uusi rivi", "Huuhaa!" };

            File.WriteAllLines("teksti.txt", rivit);
            


            if (OnOlemassa(tnimi))
            {
                FileStream fs = new FileStream(tnimi, FileMode.Open, FileAccess.Read);

                Console.WriteLine("Kirjoitettiin:");
                Console.WriteLine();


                Console.WriteLine("taulukoksi:");
                Console.WriteLine(File.ReadAllText(@"C:\Ohjelmointi\Tiedosto käsittely\Tiedosto\Tiedosto\bin\Debug\net6.0\teksti.txt"));
                Console.WriteLine();
                Thread.Sleep(1000);


                Console.WriteLine("listaksi:");
                Console.WriteLine(File.ReadAllText(@"C:\Ohjelmointi\Tiedosto käsittely\Tiedosto\Tiedosto\bin\Debug\net6.0\teksti.txt"));
                Console.WriteLine();
                Thread.Sleep(1000);


                Console.WriteLine("merkkijonoksi:");
                Console.WriteLine(LueRivitMerkitseJonoksi(@"C:\Ohjelmointi\Tiedosto käsittely\Tiedosto\Tiedosto\bin\Debug\net6.0\teksti.txt"));
                Console.WriteLine();
                Thread.Sleep(1000);


                Console.WriteLine("Pilkuilla:");

                char ch;
                int Tchar = 0;
                StreamReader reader;
                reader = new StreamReader(@"C:\Ohjelmointi\Tiedosto käsittely\Tiedosto\Tiedosto\bin\Debug\net6.0\teksti.txt");
                do
                {
                    ch = (char)reader.Read();
                    Console.Write(",");
                    Console.Write(ch);
                    
                    Tchar++;
                } while (!reader.EndOfStream);
                reader.Close();
                reader.Dispose();

                



                Console.WriteLine();
                Thread.Sleep(1000);



                var fileName = @"C:\Ohjelmointi\Tiedosto käsittely\Tiedosto\Tiedosto\bin\Debug\net6.0\teksti.txt";
                FileInfo fi = new FileInfo(fileName);
                var size = fi.Length;
                Console.WriteLine();
                DateTime fileCreatedDate = File.GetCreationTime(@"teksti.txt");
                Console.WriteLine("Tiedoston koko bitteinä: {0}", size + " " + "Tiedosto Luotiin: " + fileCreatedDate);
                

            }

            else
            {
                Console.WriteLine("Tiedostoa " + tnimi + " ei löydy");
            }

        }
    }
}


