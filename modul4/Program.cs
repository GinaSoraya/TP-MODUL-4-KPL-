// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

public class Program
{
/*    public enum KodePos
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
    }*/

   

    class DoorMachine
    {
        public enum DoorState
        {
            TERKUNCI,
            TERBUKA
        }
        public enum Trigger
        {
            KunciPintu,
            BukaPintu
        }
        public class Transition
        {
            public DoorState StateAwal;
            public DoorState StateAkhir;
            public Trigger trigger;

            public Transition(DoorState stateAwal, DoorState stateAkhir, Trigger trigger)
            {
                this.StateAwal = stateAwal;
                this.StateAkhir = stateAkhir;
                this.trigger = trigger;
            }
        }

        Transition[] transisi =
        {
            new Transition(DoorState.TERKUNCI, DoorState.TERKUNCI, Trigger.KunciPintu),
            new Transition(DoorState.TERKUNCI, DoorState.TERBUKA, Trigger.BukaPintu),
            new Transition(DoorState.TERBUKA, DoorState.TERBUKA, Trigger.BukaPintu),
            new Transition(DoorState.TERBUKA, DoorState.TERKUNCI, Trigger.KunciPintu)
        };

        public DoorState currentState = DoorMachine.DoorState.TERKUNCI;
        

        public DoorState getNextState(DoorState stateAwal, Trigger trigger) 
        {
            DoorState stateAkhir = stateAwal;
            for (int i = 0; i < transisi.Length; i++)
            {
                Transition perubahan = transisi[i];
                if (stateAwal == perubahan.StateAwal && trigger == perubahan.trigger)
                {
                    stateAkhir = perubahan.StateAkhir;
                }
            }
            return stateAkhir;
        }

        public void ActiveTrigger(Trigger trigger)
        {
            currentState = getNextState(currentState, trigger);
            Console.WriteLine("State anda sekarang adalah: " + currentState);
            if (currentState == DoorMachine.DoorState.TERKUNCI)
            {
                Console.WriteLine("Pintu Terkunci");
            } else
            {
                Console.WriteLine("Pintu Tidak Terkunci");
            }
        }

        public static void Main(string[] args)
        {
            DoorMachine pintu = new DoorMachine();
            pintu.ActiveTrigger(Trigger.KunciPintu);
            pintu.ActiveTrigger(Trigger.BukaPintu);
        }
    }
}
