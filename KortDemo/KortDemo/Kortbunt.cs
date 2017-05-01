using System;
using System.Collections.Generic;

public class Kortbunt
{
    List<Kort> bunten = new List<Kort>();
    static Random rand = new Random();

    public void LäggÖverst(Kort k)
    {
        bunten.Insert(0, k);    //lägg in Kort k som första element i listan
    }

    public Kort TaBortÖversta()
    {
        Kort k = bunten[0];
        bunten.RemoveAt(0);     //Raderar det översta/första elementet i listan
        return k;               //Returner det kort som låg överst
    }

    //En property, inte en metod eftersom den inte har ()
    public int AntalKort
    {
        get                         //get är en så kallad accessor
        {
            return bunten.Count;    //Antal kort/element i listan
        }
    }

    //En indexerare, av typen property med nyckelordet this
    //this har indexoperatorn [] som bihang eftersom vi vill veta
    //vilket Kort/nummer vi vill ha tillbaka/returnerat
    //Hade kunna lösts med en metod men det här är ett alternativ
    public Kort this[int nr]
    {
        get
        {
            return bunten[nr];
        }
    }

    public void SlängKorten()
    {
        bunten.Clear();             //Tömmer listan  på innehåll/element/kort
    }

    public Kort TaBort(int nr)
    {
        Kort k = bunten[nr];
        bunten.RemoveAt(nr);
        return k;
    }

    public int Sök(KortFärg f, KortValör v)
    {
        int i = 0;
        for (i = 0; i < bunten.Count; i++)
            if (bunten[i].Färg == f && bunten[i].Valör == v)
                return i;
        return -1;
    }

    public void NyKortlek()
    {
        bunten.Clear();
        for (KortFärg f = KortFärg.KLÖVER; f <= KortFärg.SPADER; f++)
            for (KortValör v = KortValör.TVÅ; v <= KortValör.ESS; v++)
                bunten.Add(new Kort(f, v));
    }

    public void Blanda()
    {
        for (int i = 0; i < 100; i++)
        {
            // Låter två slumpmässiga kort byta plats med varandra
            int a = rand.Next(bunten.Count); //slumpar fram ett tal mellan [0, antal kort i bunten]
            int b = rand.Next(bunten.Count);
            Kort k = bunten[a];
            bunten[a] = bunten[b];
            bunten[b] = k;
        }
    }
}