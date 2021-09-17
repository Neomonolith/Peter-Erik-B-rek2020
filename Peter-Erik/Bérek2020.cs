using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Peter_Erik
{
  class Program
  {
    static List<adatok> szamolasok = new List<adatok>();
    static void Main(string[] args)
    {
      //néven mentés Elsofeladat();
      Masodikfeladat();
      Harmadikfeladat();
      Negyedikfeladat();
      Otodikfeladat();
      Hatodikfeladat();
      Hetedikfeladat();


      Console.ReadLine();
    }

    private static void Hetedikfeladat()
    {
     
    }

    private static void Hatodikfeladat()
    {
     
    }

    private static void Otodikfeladat()
    {
      


      string[] a;
      Console.Write("5. feladat: Kérem egy részleg nevét: ");
      a = Console.ReadLine().Split();
      
      foreach (var l in szamolasok)
      {

       
      }
    }

    private static void Negyedikfeladat()
    {

      /*
      double osztas = 0;
      int osszeg = 0;
      foreach (var l in szamolasok)
      {
        if (l.Belepes == 2020)
        {
          osszeg = l.Ber / osszeg;
          //osszeg = osszeg + l.Ber;
          //osztas = (double)osszeg + l.Ber / 1000;
          Console.WriteLine($"4. feladat: Bérek átlaga:{osztas}");
          
        
          //Math.round()
         
        }
      }

      */
    }



    private static void Harmadikfeladat()
    {
      Console.WriteLine($"3. Feladat: Dolgozók száma:{szamolasok.Count()}");
    }

   
    

  private static void Masodikfeladat()
  {
      Console.WriteLine("2. feladat: adatok beolvasása");
      
      StreamReader be = new StreamReader("berek2020.txt");
      be.ReadLine();
      while (!be.EndOfStream)
        {
        string[] a = be.ReadLine().Split(';');

        szamolasok.Add(new adatok(a[0], a[1], a[2], int.Parse(a[3]), int.Parse(a[4]))
          );



      }
        be.Close();
      }
  }
}
