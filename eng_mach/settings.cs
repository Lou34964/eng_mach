using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eng_mach
{
    public static class settings
    {



        public static string int_to_string      = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                                                 //01234567890123456789012345
        public static string RotorPattern_1     = "ERYZAGFPXTMOKWLHUBVJQSNICD";
        public static string RotorPattern_2     = "FJQHKAZDWBERXSYUCLNVPTIMOG";
        public static string RotorPattern_3     = "OZUYSGFTRVNWQKAXMIEHCJLPDB";
        public static string RotorPattern_4     = "GFWRTBAZOYLKNMIVXDUESPCQJH";
        public static string RotorPattern_5     = "POMIZHVFDWQYCXBAKUTSRGJNLE";

        public static string ReflectorPattern_1 = "ZYXWVUTSRQPONMLKJIHGFEDCBA";
        public static string ReflectorPattern_2 = "QZWXRVTYUSPNOLMKAEJGIFCDHB";
        public static string ReflectorPattern_3 = "TGFQSCBZIXWUVRPODNEALMKJYH";

    }

    public class Rotor
    {
        Rotor(Rotor r)
        {
            this.Convertion = r.Convertion;
            this.Pattern = r.Pattern;
        }
        Rotor(string pattern, int offset, int notch)
        {
            
            this.Pattern = pattern;
            this.Offset = offset;
            this.Notch = notch;
            for (int i = 0; i < pattern.Length; i++)
            {
                this.Convertion[i] = settings.int_to_string.IndexOf(pattern[i]);
            }
        }
        Rotor(Rotor r, Rotor next)
        {
            this.Convertion = r.Convertion;
            this.Pattern = r.Pattern;
            this.Next = next;
        }
        Rotor(Rotor r, Rotor next, Rotor prev)
        {
            this.Convertion = r.Convertion;
            this.Pattern = r.Pattern;
            this.Next = next;
            this.Prev = prev;
        }
        int[] Convertion = new int[26];
        public string Pattern { get; private set; }
        Rotor Next = null;
        Rotor Prev = null;
        int Offset = 0;
        int Notch = 0;
        void Rotate()
        {
            if (Offset == Notch)
            {
                if (Next != null)
                {
                    this.Next.Rotate();
                }
            }
            if(Offset == 25)
            {
                Offset = 0;
                return;
            }
            Offset++;
        }
        int Send_to_Next_Rotor(int pin)
        {
            return Next.Convertion[pin]; 
        }
        int Send_to_Prev_Rotor(int pin)
        {
            return Prev.Convertion[pin];
        }
    }

    public class Reflector
    {
        Reflector(string pattern)
        {
            this.Pattern = pattern;
            for (int i = 0; i < pattern.Length; i++)
            {
                this.Convertion[i] = settings.int_to_string.IndexOf(pattern[i]);
            }
        }
        int[] Convertion = new int[26];

        public string Pattern { get; private set; }
    }

    public class Plugboard
    {
        string 
            A="A",
            B="B",
            C="C",
            D="D",
            E="E",
            F="F",
            G="G",
            H="H",
            I="I",
            J="J",
            K="K",
            L="L",
            M="M",
            N="N",
            O="O",
            P="P",
            Q="Q",
            R="R",
            S="S",
            T="T",
            U="U",
            V="V",
            W="W",
            X="X",
            Y="Y",
            Z="Z";
    }

    public class defs
    {

    }

    
}
