using System;

namespace puput
{
    class Program
    {
        static string sopoinElain = "pupu";
        static string sopoinElain2 = "kani";
        static int yritykset;
        static string vastausei;
        static Kuviot peli1 = new Kuviot("peli1");

        static void Main(string[] args)
        {
            do
            {
                yritykset = 0;
                Esittely();
                VaiheYksi();
                VaiheKaksi();
            }
            while (vastausei != "ei");
        }

        private static void Esittely()
        {
            Console.WriteLine();
            Console.WriteLine("Tässä pelissä testataan, että oletko oikeassa...");
            Console.WriteLine("Onnea peliin!");
            Console.WriteLine();
        }

        //Ensimmäinen kysymys
        static void VaiheYksi()
        {
            string vastaus = KysymysYksi();
            Console.Clear();
            YksiTulokset(vastaus);
        }

        //Kysymys
        private static string KysymysYksi()
        {
            for (int i = 0; i <= 6; i++)
            {
                for (int j = 0; j <= 16; j++)
                {
                    Console.Write("{0}", peli1.jaggedArray[1][i, j]);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("Ethän herätä pupua...");
            Console.WriteLine(" ");
            Console.WriteLine("Mikä on maailman söpöin eläin?");
            Console.WriteLine("Kirjoita vastauksesi tähän:");
            Console.WriteLine();
            string vastaus = Console.ReadLine();
            return vastaus.ToLower();
        }

        //Tulokset
        static void YksiTulokset(string vastaus)
        {
            if (vastaus == sopoinElain || vastaus == sopoinElain2)
            {
                Console.WriteLine();
                Console.WriteLine(vastaus);
                Console.WriteLine();
                Console.WriteLine("Oikein!!!");
                Console.WriteLine();
                Console.WriteLine("Nyt tulee vähän vaikeampi kysymys, ole tarkkana...");
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine(vastaus);
                Console.WriteLine();
                Console.WriteLine("Olet väärässä. Yritä uudestaan! Mieti vastaustasi tarkkaan.");
                Console.WriteLine();
                VaiheYksi();
            }
        }

        //Toinen kysymys
        static string[] reaktiot = new string[]
        {
            "Kuinka kehtaat?! Et todellakaan ole oikeassa. Loukkaat pupua sanoillasi.",
            "Puput ovat kyllä numero yksi... Mutta taisit ymmärtää nyt väärin.",
            "Ei todellakaan. Yritätkö edes? Alan pikkuhiljaa ajattelemaan, että olet väärässä...",
            "3/10 söpöyttä?! Näiden asioiden kanssa ei leikitä. Olet väärässä.",
            "Hahahahahaha. EI.",
            "Viisi? Eli puput olisivat vain puoliksi söpöjä? Väärin.",
            "Killin kellin kallin kuusi, vastauksesi on VÄÄRIN.",
            "Ei. Ei. Ei. Ei. Ei. Ei. Ei.",
            "Et taida edes yrittää?",
            "Vinkki: lisää vielä yksi."
        };

        static void VaiheKaksi()
        {
            try
            {
                Console.WriteLine("");
                Console.WriteLine("Kuinka söpöjä puput on asteikolla 1-10?");
                Console.WriteLine("Kirjoita vastauksesi ja paina enter:");
                int vastauskaksi = KirjoitaVastausKaksi();
                Console.Clear();
                KaksiTulokset(vastauskaksi);
            }
            catch (Exception)
            {
                Console.WriteLine("Oho, jotain meni mönkään... Yritetään uudestaan.");
                VaiheKaksi();
            }
        }

        //Tässä kysytään kysymys nro. 2, muutetaan annettu numero vastaavaksi int-luvuksi,
        // joka ohjataan int-muodossa KaksiTulokset-kohdan käytettäväksi.
        static int KirjoitaVastausKaksi()
        {
            Console.WriteLine(" ");
            int vastauskaksi = int.Parse(Console.ReadLine());
            return (vastauskaksi);
        }

        //Tässä annetaan reaktio vastauksesta riippuen, käyttäen aiemmin luotua reaktiot-listaa.
        //Vastauksena annettu luku antaa sitä vastaavan vastauksen listasta.
        static void KaksiTulokset(int vastauskaksi)
        {
            if (vastauskaksi == 10)

            {
                for (int i = 0; i <= 6; i++)
                {
                    for (int j = 0; j <= 16; j++)
                    {
                        //Console.Write(pupu0[i, j]);
                        //Console.Write($"{peli1.Pupu0()}");
                        Console.Write("{0}", peli1.jaggedArray[0][i, j]);
                    }
                    Console.WriteLine("");
                }

                Console.WriteLine();
                Console.WriteLine("Täydellistä! Mallikelpoinen vastaus! Katso nyt tuota pupua, miten onnelliseksi hän tuli!");
                UusiYritys();
            }

            else if (vastauskaksi < 10)
            {
                for (int i = 0; i < reaktiot.Length; i++)
                {
                    if (vastauskaksi == i)
                    {
                        Console.WriteLine();
                        Console.WriteLine(vastauskaksi);
                        Console.WriteLine();
                        Console.WriteLine($"{reaktiot[i]}");
                    }
                }

                Console.WriteLine();
                YritysReaktiot();
                if (yritykset < 9)
                {
                    VaiheKaksi();
                }
            }

            else
            {
                Console.WriteLine("Oho, nyt taisi tulla kirjoitusvirhe... Yritä uudestaan!");
                VaiheKaksi();
            }
        }
        private static void YritysReaktiot()
        {
            peli1.Pupu1();
            peli1.Pupu2();
            peli1.Pupu3();
            peli1.Pupu4();
            peli1.Pupu5();
            peli1.Pupu6();
            peli1.Pupu7();
            peli1.Pupu8();
            peli1.Pupu9();

            yritykset++;

            switch (yritykset)
            {
                case 1:
                    Console.WriteLine("Varovasti nyt, ettet herätä pupua loukkaksillasi...");
                    Console.WriteLine("");
                    for (int i = 0; i <= 6; i++)
                    {
                        for (int j = 0; j <= 16; j++)
                        {
                            Console.Write("{0}", peli1.jaggedArray[1][i, j]);
                        }
                        Console.WriteLine("");
                    }
                    break;

                case 2:
                    Console.WriteLine("Sanoin: älä herätä pupua!!!");
                    Console.WriteLine("");
                    for (int i = 0; i <= 6; i++)
                    {
                        for (int j = 0; j <= 16; j++)
                        {
                            Console.Write("{0}", peli1.jaggedArray[2][i, j]);
                        }
                        Console.WriteLine("");
                    }
                    break;

                case 3:
                    Console.WriteLine("Miksi teit sen? Pupu on nyt hereillä, koska loukkasit sitä!");
                    Console.WriteLine("");
                    for (int i = 0; i <= 6; i++)
                    {
                        for (int j = 0; j <= 16; j++)
                        {
                            Console.Write("{0}", peli1.jaggedArray[3][i, j]);
                        }
                        Console.WriteLine("");
                    }
                    break;

                case 4:
                    Console.WriteLine("Eikö sinulla ole tunteita ollenkaan?! Tällä pupulla on, ja hän on hyvin loukkaantunut.");
                    Console.WriteLine("");
                    for (int i = 0; i <= 6; i++)
                    {
                        for (int j = 0; j <= 16; j++)
                        {
                            Console.Write("{0}", peli1.jaggedArray[4][i, j]);
                        }
                        Console.WriteLine("");
                    }
                    break;

                case 5:
                    Console.WriteLine("Nyt minun on pakko varoittaa sinua. Puput ovat kyllä söpöjä, mutta suuttuessaan ne voivat olla myös vaarallisia...");
                    Console.WriteLine("Mieti tarkkaan seuraavaa vastaustasi...");
                    Console.WriteLine("");
                    for (int i = 0; i <= 6; i++)
                    {
                        for (int j = 0; j <= 16; j++)
                        {
                            Console.Write("{0}", peli1.jaggedArray[5][i, j]);
                        }
                        Console.WriteLine("");
                    }
                    break;

                case 6:
                    Console.WriteLine("Varovasti nyt, muista mitä juuri sanoin...");
                    Console.WriteLine("");
                    for (int i = 0; i <= 6; i++)
                    {
                        for (int j = 0; j <= 16; j++)
                        {
                            Console.Write("{0}", peli1.jaggedArray[6][i, j]);
                        }
                        Console.WriteLine("");
                    }
                    break;

                case 7:
                    Console.WriteLine("Oletko hullu?! Jos suututat pupun todella, niin en vastaa seurauksista.");
                    Console.WriteLine("Vielä ehdit perumaan puheesi...");
                    Console.WriteLine("");
                    for (int i = 0; i <= 6; i++)
                    {
                        for (int j = 0; j <= 16; j++)
                        {
                            Console.Write("{0}", peli1.jaggedArray[7][i, j]);
                        }
                        Console.WriteLine("");
                    }
                    break;

                case 8:
                    Console.WriteLine("Nyt sinä teit sen! Suututit pupun!");
                    Console.WriteLine("Nyt on viimeinen mahdollisuutesi alkaa pakenemaan, tai antaa oikea vastaus!!");
                    Console.WriteLine("");
                    for (int i = 0; i <= 7; i++)
                    {
                        for (int j = 0; j <= 11; j++)
                        {
                            Console.Write("{0}", peli1.jaggedArray[8][i, j]);
                        }
                        Console.WriteLine("");
                    }
                    break;

                case 9:
                    Console.WriteLine("Voi ei!!! Hävisit pelin! Pupu suuttui sinulle verisesti!");
                    Console.WriteLine("");
                    for (int i = 0; i <= 8; i++)
                    {
                        for (int j = 0; j <= 12; j++)
                        {
                            Console.Write("{0}", peli1.jaggedArray[9][i, j]);
                        }
                        Console.WriteLine("");
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Puput ovat kuitenkin varsin anteeksiantavaisia... ");

                    UusiYritys();
                    break;

                default:
                    Console.WriteLine("nyt meni jotain pieleen, yritäpäs uudestaan...");
                    break;
            }
        }

        public static void UusiYritys()
        {
            Console.WriteLine("");
            Console.WriteLine("Haluatko pelata uudestaan? Vastaa kyllä tai ei.");
            string uusinta = Console.ReadLine();
            Console.WriteLine("");

            if (uusinta.ToLower() == "kyllä")
            {
                Console.Clear();
                Console.WriteLine("Hienoa!");
                Console.WriteLine("Uusi peli alkakoon!");
            }

            else if (uusinta.ToLower() == "ei" && yritykset == 9)
            {
                Console.WriteLine("Jaahas. Hävisit pelin. Olet siis väärässä.");
                Console.WriteLine("Puput eivät tykkää luovuttajista.");
                vastausei = "ei";
            }

            else if (uusinta.ToLower() == "ei")
            {
                Console.WriteLine("Kiitos pelaamisesta!");
                Console.WriteLine("");
                vastausei = "ei";
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Oho. Nyt tuli väärä vastaus. Yritetään uudestaan:");
                Console.WriteLine("");
                UusiYritys();
            }
        }
    }
}
