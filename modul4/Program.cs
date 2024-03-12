// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

public class Program
{
    public enum KodePos
    {
        Batununggal,
        Kunjangsari,
        Mengger,
        Wates,
        Cijaura,
        Jatisari,
        Margasari,
        Sekejati,
        Kebonwaru,
        Maleer,
        Samoja
    }

    public static int getKodePos(KodePos pos)
    {
        int[] outputKode = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
        return outputKode[(int)pos];
    }

    public static void Main(string[] args)
    {
        KodePos Pos = KodePos.Jatisari;
        int kodepos = getKodePos(Pos);
        Console.WriteLine("Kode Pos pada kelurahan " + Pos + " aladah " + kodepos);
    }
}
