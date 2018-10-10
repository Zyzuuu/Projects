using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class WARTOSCI
{

    private string nazwa_postaci;
    private int zycie_postaci;
    private int sila_postaci;
    public WARTOSCI(string nazwa_postaci = " ", int zycie_postaci = 100, int sila_postaci = 0)
    {
        this.nazwa_postaci = nazwa_postaci;
        this.zycie_postaci = zycie_postaci;
        this.sila_postaci = sila_postaci;
    }

    public virtual int atak()
    {
        return 0;
    }

    public int modyfikuj_zycie(int a)
    {
        zycie_postaci = zycie_postaci + a;


        if (zycie_postaci > 100)
        {
            zycie_postaci = 100;
            return 100;
        }
        else if (zycie_postaci < 0)

        {
            zycie_postaci = 0;
            return 0;
        }

        return zycie_postaci;

    }
    public void n_postaci(string nazwa_postaci)
    {
        this.nazwa_postaci = nazwa_postaci;
    }
    public void s_postaci(int sila_postaci)
    {
        this.sila_postaci = sila_postaci;
    }
    public int zycie
    {
        get { return zycie_postaci; }
    }
    public int sila
    {
        get { return sila_postaci; }
    }
    

    public override string ToString()
    {
        return nazwa_postaci.ToString() + " " + zycie_postaci.ToString() + " " + sila_postaci.ToString() ;
    }
}
    
    class MAG : WARTOSCI
      {
        private int punkty_magii;

    public MAG()
    {
        modyfikuj_zycie(100);
        n_postaci("Xardas");
        Random rand = new Random();
        s_postaci(rand.Next(1, 7));
        this.punkty_magii = rand.Next(1, 7) + rand.Next(1, 7);
    }
    public MAG(string nazwa_postaci, int sila_postaci, int amodyfikuj_zycie, int punkty_magii)
    {
        n_postaci(nazwa_postaci);
        s_postaci(sila_postaci);
        modyfikuj_zycie(amodyfikuj_zycie);
        this.punkty_magii = punkty_magii;

    }

    public override int atak()
    {
        return (punkty_magii + sila) * zycie;
    }
    public override string ToString()
    {
        return base.ToString() + " " + punkty_magii + " ";
    }

}


class WOJOWNIK : WARTOSCI
{
    public WOJOWNIK()
    {
        modyfikuj_zycie(100);
        n_postaci("Geralt");
        Random rand = new Random();
        s_postaci(rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7));
    }

    public WOJOWNIK(string nazwa_postaci, int sila_postaci, int amodyfikuj_zycie)
    {
        n_postaci(nazwa_postaci);
        s_postaci(sila_postaci);
        modyfikuj_zycie(amodyfikuj_zycie);
    }

    public override int atak()
    {
        if (zycie < 5)
            return sila;

        return sila * zycie;

    }

}

class DruzynaPierscienia : ICloneable
{
    private string nazwa_druzyny;

    List<WARTOSCI> party = new List<WARTOSCI>();
    public DruzynaPierscienia(string nazwa_druzyny)
    {

        this.nazwa_druzyny = nazwa_druzyny;

    }

    public object Clone()
    {
        DruzynaPierscienia druzynaA = new DruzynaPierscienia(nazwa_druzyny);

        for (int i = 0; i < party.Count; i++)
        {
            druzynaA.party.Add(party.ElementAt(i));
        }

        return druzynaA;    
    }
    public void nowa_postac(WARTOSCI a)
    {
        party.Add(a);
    }
    public WARTOSCI this [int i]
    {
        get { return party.ElementAt(i); }
    }

    public int at_zwr()
    {
        int sumuj = 0;

        for (int i = 0; i < party.Count; i++)
            sumuj += party.ElementAt(i).atak();

        return sumuj;
    }

    public override string ToString()
    {
        string nmp = nazwa_druzyny + " " + at_zwr() + " ";

        for (int i = 0; i < party.Count; i++)
            nmp += party.ElementAt(i).ToString();

        return nmp;
    }
}

class Program
{
    static void Main(string[] args)
    {


        WOJOWNIK postac_wojownika = new WOJOWNIK();
        Console.WriteLine(postac_wojownika);
        MAG postac_maga = new MAG();
        Console.WriteLine(postac_maga);
        postac_maga.modyfikuj_zycie(20);
        DruzynaPierscienia nowaDruzyna = new DruzynaPierscienia("Drużyna Pierscienia:");
        nowaDruzyna.nowa_postac(postac_maga);
        nowaDruzyna.nowa_postac(postac_wojownika);
        Console.WriteLine(nowaDruzyna.at_zwr());
        Console.WriteLine(nowaDruzyna);


        DruzynaPierscienia druzynaA = (DruzynaPierscienia)nowaDruzyna.Clone();
        Console.ReadLine();


    }

    
}


