using System.Windows.Forms;
using System.Drawing;

//Uppräkningstyper. Betyder att typen/Konstanten innehålller endast fördefinerade medlemmar
//Vi tilldelar TVÅ värdet 2 (default 0), vilket automatiskt innebär att tre får föregående värde +1 osv.
public enum KortFärg { KLÖVER, RUTER, HJÄRTER, SPADER };
public enum KortValör { TVÅ = 2, TRE, FYRA, FEM, SEX, SJU, ÅTTA, NIO, TIO, KNEKT, DAM, KUNG, ESS };

public class Kort : Button
{
    public KortFärg f;
    public KortValör v;
    bool synligt;
    Image framsida;
    static Image baksida;
    static string[] färgTab = { "Kl", "Ru", "Hj", "Sp" };
    static string[] valörTab = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Kn", "D", "K", "E" };
    public static string BildMapp = @"C:\Users\Andre\Dropbox\#Prog\C#\GitRepo\Bilder\";

    //Konstruktor med tre parametrar. Anropar automatiskt superklassens konstruktor
    public Kort(KortFärg fä, KortValör va, bool synl)
    {
        f = fä;
        v = va;
        framsida = Image.FromFile(BildMapp + färgTab[(int)f] + valörTab[Värde - 2] + ".png");

        if (baksida == null) //Hämtas bara en gång
            baksida = Image.FromFile(BildMapp + "Bak.png");

        Size = framsida.Size;      //System.Windows.Forms.Controls.Size
        Synligt = synl;
    }

    //Konstruktor med två parametrar. : this anropar den egna konstruktorn -ovan- med tre parametrar
    public Kort(KortFärg fä, KortValör va) : this(fä, va, false)
    {
    }

    public KortFärg Färg
    {
        get
        {
            return f;
        }
    }

    public KortValör Valör
    {
        get
        {
            return v;
        }
    }

    public int Värde
    {
        get
        {
            return (int)v;
        }
    }

    //Property med både avläsare/get och ändrare/set acsessorer 
    public bool Synligt
    {
        get
        {
            return synligt;
        }
        set
        {
            synligt = value;
            if (synligt)
                Image = framsida;
            else
                Image = baksida;
        }
    }


    //Döljer/tar över, superklasssens ToString-metod
    public override string ToString()
    {
        return färgTab[(int)f] + " " + valörTab[Värde - 2];
    }
}
