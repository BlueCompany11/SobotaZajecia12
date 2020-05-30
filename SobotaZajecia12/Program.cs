using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SobotaZajecia12
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista2 = new List<string>();
            lista2.Add("Ala");
            lista2.Add("ma");
            lista2.Add("kota");
            string wypisz = Scal(lista2);
            Console.WriteLine(wypisz);

            var lista3 = new List<string>();
            lista3.Add("Ala2");
            lista3.Add("ma2");
            lista3.Add("kota2");
            string wypisz2 = Scal(lista3);
            Console.WriteLine(wypisz2);
            Console.ReadKey();


            return;
            var lista = new List<int>();
            //Dodawanie do kolekcji
            lista.Add(4);
            lista.Add(8);
            lista.Add(5);
            lista.Add(4);
            //lista[2]
            int suma = 0;
            //sumowanie
            //0       lista.Count-1
            //lista[0] lista[1] 
            for (int i = 0; i < lista.Count; i++)
            {
                int aktualnyObiekt = lista[i];
                if(aktualnyObiekt > 7)
                {
                    continue;
                }
                if (aktualnyObiekt == 5)
                {
                    break;
                }
                suma += aktualnyObiekt;
            }
            //PrezentacjaWyniku
            Console.WriteLine("Suma: "+suma.ToString());
            Console.ReadKey();

        }

        static string Scal(List<string> lista)
        {
            string ret = "";
            for (int i = 0; i < lista.Count; i++)
            {
                ret += lista[i] + " ";
            }
            return ret;
        }
        
        void NicNieZwracajacaMetoda()
        {
            
        }

        void NicNieZwracajacaMetodaZArugmentami(int liczba)
        {
            Console.WriteLine("liczba: "+liczba.ToString());
        }

        int MetodaZwracajacaInt()
        {
            return 5;
        }

        string MetodaZwracjacaIntIprzyjmujacaListe(List<string> lista)
        {
            string ret = "";
            for (int i = 0; i < lista.Count; i++)
            {
                ret += lista[i];
            }
            return ret;
        }
    }
}
