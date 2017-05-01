////Uppräkningstyper. Betyder att typen/Konstanten innehålller endast fördefinerade medlemmar
////Vi tilldelar TVÅ värdet 2 (default 0), vilket automatiskt innebär att tre får föregående värde +1 osv.
//public enum KortFärg { KLÖVER, RUTER, HJÄRTER, SPADER};
//public enum KortValör { TVÅ = 2, TRE, FYRA, FEM, SEX, SJU, ÅTTA, NIO, TIO, KNEKT, DAM, KUNG, ESS };

//public class KortOrig
//{
//    public KortFärg f;
//    public KortValör v;
//    static string[] färgTab = { "Kl", "Ru", "Hj", "Sp" };
//    static string[] valörTab = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Kn", "D", "K", "E" };

//    public KortOrig(KortFärg fä, KortValör va)
//    {
//        f = fä;
//        v = va;
//    }

//    public KortFärg Färg
//    {
//        get
//        {
//            return f;
//        }
//    }

//    public KortValör Valör
//    {
//        get
//        {
//            return v;
//        }
//    }

//    public int Värde
//    {
//        get
//        {
//            return (int) v;
//        }
//    }

//    //Döljer superklasssens ToString-metod
//    public override string ToString()
//    {
//        return färgTab[(int)f] + " " + valörTab[Värde - 2];
//    }
//}
