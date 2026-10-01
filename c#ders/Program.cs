using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_ders
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1ci

            Console.WriteLine("Ad: ");
            string ad = Console.ReadLine();

            Console.WriteLine("Yas: ");
            string yas = Console.ReadLine();
            int.TryParse(yas, out int YAS);

            Console.WriteLine("Boy: ");
            string boy = Console.ReadLine();
            double.TryParse(boy, out double BOY);

            Console.WriteLine("Salam menim adim " + ad + "dir.Menim " + YAS + " yasim var, boyum " + BOY + "m-dir.");

            //2ci
            const double Pi = 3.14159;
            Console.WriteLine("Radius daxil edin: ");
            string radius = Console.ReadLine();
            double.TryParse(radius, out double R);
            double S = Pi * R * R;
            Console.WriteLine(S);

            //3cu
            const double USD = 1.7, EUR = 1.82;

            Console.WriteLine("Manat daxil edin: ");
            string manat = Console.ReadLine();
            double.TryParse(manat, out double MAN);

            double dollar = MAN / USD;
            double euro = MAN / EUR;
            Console.WriteLine(dollar + "USD");
            Console.WriteLine(euro + "EUR");

            //4cu
            Console.WriteLine("Azerbaycan dili qiymeti: ");
            string az = Console.ReadLine();
            int.TryParse(az, out int AZ);

            Console.WriteLine("Riyaziyyat qiymeti: ");
            string riy = Console.ReadLine();
            int.TryParse(riy, out int RIY);

            Console.WriteLine("Ingilis dili: ");
            string ing = Console.ReadLine();
            int.TryParse(ing, out int ING);

            Console.WriteLine("Kimya: ");
            string kimya = Console.ReadLine();
            int.TryParse(kimya, out int KIMYA);

            Console.WriteLine("Fizika: ");
            string fizika = Console.ReadLine();
            int.TryParse(fizika, out int FIZIKA);

            double ortalama = (AZ + RIY + ING + KIMYA + FIZIKA) / 5.0;
            Console.WriteLine("Ortalamaniz: " + ortalama);

            if (ortalama >= 90)
            {
                Console.WriteLine("Ela netice");

            }
            else if (ortalama >= 50)
            {
                Console.WriteLine("Ortalama netice");

            }
            else
            {
                Console.WriteLine("Kesildiniz");

            }

            //5
            const double faiz = 0.12;
            Console.WriteLine("Ilkin meblegi qeyd edin: ");
            string ilkmebleg = Console.ReadLine();
            double.TryParse(ilkmebleg, out double ILK);

            Console.WriteLine("nece ilk saxlayacaqsiniz: ");
            string il = Console.ReadLine();
            int.TryParse(il, out int IL);
            double gelecekmebleg = ILK * (1 + faiz * IL);

            Console.WriteLine(gelecekmebleg);

            //6
            Console.Write("Mesafeni daxil edin: ");
            string mesafe = Console.ReadLine();
            double.TryParse(mesafe, out double M);

            Console.WriteLine("Yanacagi  daxil edin: ");
            string yanacaq = Console.ReadLine();
            double.TryParse(yanacaq, out double Y);

            double serfiyyat = (Y / M) * 100;
            Console.WriteLine(serfiyyat);

            if (Y > 0 && M > 0)
            {

            }
            else
            {
                Console.WriteLine("Daxil edilen melumat yanlisdir!");
            }
        }
    }
}
