using System;

// class KontoBankowe
// {
//     private double saldo;
//     public void Wplata(double k)
//     {
//         saldo += k;
//         Console.WriteLine("wplata: " + k);
//     }
//     public void Wyplata(double k)
//     {
//         if (k <= saldo)
//         {
//             saldo -= k;
//             Console.WriteLine("wyplata: " + k);
//         }
//         else
//         {
//             Console.WriteLine("za malo srodkow");
//         }
//     }
//     public double PobierzSaldo()
//     {
//         return saldo;
//     }
// }
// var konto = new KontoBankowe();
// konto.Wplata(100);
// konto.Wyplata(40);
// Console.WriteLine(konto.PobierzSaldo());

//6


// class Zwierze
// {
//     public void Jedz()
//     {
//         Console.WriteLine("zwierze je");
//     }
// }
// class Pies : Zwierze
// {
//     public void Szczekaj()
//     {
//         Console.WriteLine("hau hau");
//     }
// }
// class Kot : Zwierze
// {
//     public void Miaucz()
//     {
//         Console.WriteLine("miau");
//     }
// }
// Pies p = new Pies();
// p.Jedz();
// p.Szczekaj();
// Kot k = new Kot();
// k.Jedz();
// k.Miaucz();


//7


// class ZwierzePoli
// {
//     public virtual void DajGlos()
//     {
//         Console.WriteLine("jakis dzwiek");
//     }
// }
// class PiesPoli : ZwierzePoli
// {
//     public override void DajGlos()
//     {
//         Console.WriteLine("hau");
//     }
// }
// class KotPoli : ZwierzePoli
// {
//     public override void DajGlos()
//     {
//         Console.WriteLine("miau");
//     }
// }
// ZwierzePoli[] arr = {
//     new PiesPoli(),
//     new KotPoli(),
//     new ZwierzePoli()
// };
// foreach (var z in arr)
// {
//     z.DajGlos();
// }


// 


class Pojazd
{
    public virtual void Start()
    {
        Console.WriteLine("pojazd start");
    }
}
class Samochod : Pojazd
{
    public void Jedz()
    {
        Console.WriteLine("samochod jedzie");
    }
}
class ElektrycznySamochod : Samochod
{
    public void Laduj()
    {
        Console.WriteLine("ladowanie baterii...");
    }
}


class Program
{
    static void Main(string[] args)
    {
        ElektrycznySamochod e = new ElektrycznySamochod();
        e.Start();
        e.Jedz();
        e.Laduj();
    }
}
