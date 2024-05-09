using System;

namespace Tasklar_for10may
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task6
            //Console.Write("N-i daxil edin:");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        Console.WriteLine($"{i} N-nin bolenlerinden biridir.");
            //    }
            //}
            #endregion
            #region task7
            //Console.Write("N-i daxil edin:");
            //int n = int.Parse(Console.ReadLine());
            //for(int i = 10; i < 100; i++)
            //{
            //    double x;
            //    x = (double)n / (double)i;
            //    Console.WriteLine(x);
            //}
            #endregion
            #region task8
            //Console.Write("Deqiqeni daxil edin:");
            //int deqiqe = int.Parse(Console.ReadLine());
            //int total;
            //if (deqiqe < 0)
            //{
            //    Console.WriteLine("Deqiqe anlayisi 0-dan boyuk olmalidir. Zehmet olmasa duzgun daxil edin!");
            //}
            //else { 
            //if(deqiqe>0 && deqiqe < 500)
            //{
            //    total = deqiqe * 5;
            //}
            //else {
            //    total = deqiqe * 3;
            //} 
            //int x = total % 100;
            //int y = total / 100;
            //Console.WriteLine($"Total odenis:{y} manat {x} qepik.");
            //}
            #endregion
            #region task9
            //Console.Write("Zehmet olmasa besreqemli M ededini daxil edin:");
            //int m = int.Parse(Console.ReadLine());
            //int firstnumber = m / 10000;
            //m = m % 10000;
            //int secondnumber = m / 1000;
            //m = m % 1000;
            //int thirdnumber = m / 100;
            //m = m % 100;
            //int fourthnumber = m / 10;
            //int fifthnumber = m % 10;
            //int N = firstnumber * 1000 + secondnumber * 100 + fourthnumber * 10 + fifthnumber;
            //Console.WriteLine($"Yeni alinan dordreqemli ededimiz:{N}");
            #endregion
            #region task10
            //Console.WriteLine("Zehmet olmasa Olimpiadanin basladigi Saati, deqiqeni ve saniyeni qeyd edin:");
            //Console.Write("Saat:");
            //int h1 = int.Parse(Console.ReadLine());
            //Console.Write("Deqiqe:");
            //int m1 = int.Parse(Console.ReadLine());
            //Console.Write("Saniye:");
            //int s1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Zehmet olmasa Olimpiadanin bitdiyi Saati, deqiqeni ve saniyeni qeyd edin:");
            //Console.Write("Saat:");
            //int h2 = int.Parse(Console.ReadLine());
            //Console.Write("Deqiqe:");
            //int m2 = int.Parse(Console.ReadLine());
            //Console.Write("Saniye:");
            //int s2 = int.Parse(Console.ReadLine());
            //int saniye;
            //int deqiqe;
            //int saat;
            //if (s1 < s2)
            //{
            //    saniye = s2 - s1;
            //    if (m1 < m2)
            //    {
            //        deqiqe = m2 - m1;
            //        saat = h2 - h1;
            //    }
            //    else
            //    {
            //        deqiqe = (m2 + 60) - m1;
            //        saat = h2 - h1 - 1;
            //    }
            //}
            //else
            //{
            //    saniye = (s2 + 60) - s1;
            //    if (m1 < m2)
            //    {
            //        deqiqe = m2 - m1;
            //        saat = h2 - h1;
            //    }
            //    else
            //    {
            //        deqiqe = (m2 + 60) - m1-1;
            //        saat = h2 - h1 - 1;
            //    }
            //}
            //Console.WriteLine($"Olimpiada {saat}saat {deqiqe}deqiqe {saniye}saniye cekdi.");
            #endregion
            #region task11
            //Console.Write("Zehmet olmasa nnn.ddd formasinda olan heqiqi ededi daxil edin:");
            //double x = double.Parse(Console.ReadLine());
            //int y = (int)x;
            ////Burada z bizim ele bir ededimizdir ki nnn.ddd verilmis heqiqi ededimizden z-i cixanda heqiqi ededin tam hissesini 0 edir
            //int n = y / 111;
            //int z = 111 * n;
            //x = x * 1000 - z * 1000;
            //int d = (int)x / 111;
            //double newnumber = (double)d * 111 + (double)n * 0.111;
            //Console.WriteLine($"Yaranan yeni ededimiz:{newnumber}");
            #endregion
            #region task12
            //Console.Write("Natural ededi daxil edin:");
            //int n = int.Parse(Console.ReadLine());
            //if (n % 4 == 0)
            //{
            //    int k = n / 4;
            //    Console.WriteLine($"{n}=4*{k}");
            //}
            //else
            //{
            //    int k = n / 4;
            //    int m = n % 4;
            //    Console.WriteLine($"{n}=4*{k}+{m}");
            //}
            #endregion
            #region task13
            //Console.Write("Ededi daxil edin:");
            //int n = int.Parse(Console.ReadLine());
            //int i=1;
            //int z = 0;
            //double x;
            //if (n > 9)
            //{
            //    do
            //    {
            //        x = n / Math.Pow(10, i);
            //        i++;
            //        z++;
            //    } while (x >= 1);
            //    z = z - 1;
            //}
            //else
            //{
            //    Console.WriteLine("Emeliyyati yerine yetirmek mumkun deyil");
            //}
            //Console.WriteLine(z);
            #endregion
            #region task14
            //Console.Write("Ededi daxil edin:");
            //int n = int.Parse(Console.ReadLine());
            //int i = 0;
            //double x;
            //int cutyer;
            //do
            //{
            //    i++;
            //    //i ededin reqemlerinin sayidir.
            //    x = n / Math.Pow(10, i);
            //} while (x >= 1);
            //if (i % 2 == 0)
            //{
            //    for (int z = i; z > 0; z = z - 2)
            //    {
            //        int d = z - 1;
            //        cutyer = n / (int)Math.Pow(10, d);
            //        int b = z - 2;
            //        n = n % (int)Math.Pow(10, b);
            //        cutyer = (int)Math.Pow(cutyer, 2);
            //        Console.WriteLine(cutyer);
            //    }
            //}
            //else
            //{
            //    for (int z = i - 1; z > 0; z = z - 2)
            //    {
            //        int d = z ;
            //        n = n % (int)Math.Pow(10, d);
            //        int b = z - 1;
            //        cutyer = n / (int)Math.Pow(10, b);
            //        cutyer = (int)Math.Pow(cutyer, 2);
            //        Console.WriteLine(cutyer);
            //    }
            //}
            #endregion
            #region task15
            //int x = 1;
            //for(int i = 1; i <= 8; i ++)
            //{
            //    x = (int)Math.Pow(2, i);
            //    Console.WriteLine($"{i*3}saat sonra:{x}");
            //}
            #endregion
        }
    }
}
