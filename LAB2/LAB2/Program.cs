using System;

//////////////////////////////Zadanie 5//////////////////////////////////////////////
/*
class KontoBankowe
{
    private double saldo;

    public void Wplata(double kwota)
    {
        saldo += kwota;
        Console.WriteLine("Wpłata: " + kwota);
    }

    public double PobierzSaldo()
    {
        return saldo;
    }
    public void Wyplata(double kwota)
    {
        if (kwota <= saldo)
        {
            saldo -= kwota;
            Console.WriteLine("Wypłata udana: " + kwota);
        }
        else
        {
            Console.WriteLine("Za mało środków na koncie.");
        }
    }
}
*/
//////////////////////////////Zadanie 6//////////////////////////////////////////////
class Zwierze
{
    public void Jedz()
    {
        Console.WriteLine("Zwierzę je");
    }
}

class Pies : Zwierze
{
    public void Szczekaj()
    {
        Console.WriteLine("Hau hau!");
    }
}

class Kot : Zwierze
{
    public void Miaucz()
    {
        Console.WriteLine("Miau!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Test Zadanie 5
        var konto = new KontoBankowe();
        konto.Wplata(100);
        konto.Wyplata(50);   // OK
        konto.Wyplata(100);  // Za mało środków
        Console.WriteLine("Saldo: " + konto.PobierzSaldo());

        Console.WriteLine();

        // Test Zadanie 6
        var pies = new Pies();
        pies.Jedz();
        pies.Szczekaj();

        var kot = new Kot();
        kot.Jedz();
        kot.Miaucz();

        Console.WriteLine("\nKoniec. Naciśnij Enter...");
        Console.ReadLine();
    }
}