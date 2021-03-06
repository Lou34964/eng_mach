using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eng_mach
{
    public static class settings
    {
        public static Rotor SelectedRotors = null;
        public static Reflector SelectedReflector = null;
        public static Plugboard PlugBoard = new Plugboard();

        public static string int_to_string      = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //                                        "01234567890123456789012345"
        public static string RotorPattern_1     = "ERYZAGFPXTMOKWLHUBVJQSNICD";
        public static string RotorPattern_2     = "FJQHKAZDWBERXSYUCLNVPTIMOG";
        public static string RotorPattern_3     = "OZUYSGFTRVNWQKAXMIEHCJLPDB";
        public static string RotorPattern_4     = "GFWRTBAZOYLKNMIVXDUESPCQJH";
        public static string RotorPattern_5     = "POMIZHVFDWQYCXBAKUTSRGJNLE";

        public static string ReflectorPattern_1 = "ZYXWVUTSRQPONMLKJIHGFEDCBA";
        public static string ReflectorPattern_2 = "QZWXRVTYUSPNOLMKAEJGIFCDHB";
        public static string ReflectorPattern_3 = "TGFQSCBZIXWUVRPODNEALMKJYH";

        public static class Rotors
        {
            public static Rotor Rotor1 = new Rotor(RotorPattern_1, 0, 8, "rot1");
            public static Rotor Rotor2 = new Rotor(RotorPattern_2, 0, 12, "rot2");
            public static Rotor Rotor3 = new Rotor(RotorPattern_3, 0, 2, "rot3");
            public static Rotor Rotor4 = new Rotor(RotorPattern_4, 0, 19,"rot4");
            public static Rotor Rotor5 = new Rotor(RotorPattern_5, 0, 23,"rot5");
        }
        public static class Reflectors
        {
            public static Reflector Reflector1 = new Reflector(ReflectorPattern_1, "ref1");
            public static Reflector Reflector2 = new Reflector(ReflectorPattern_2, "ref2");
            public static Reflector Reflector3 = new Reflector(ReflectorPattern_3, "ref3");
        }
        public static class PlugBoardColors
        {
            public static List<Color> avc = new List<Color>();
            public static List<Color> svc = new List<Color>();
        }
        public static void SetRottors(string r1,string r2,string r3,int off1,int off2, int off3)
        {
            SelectedRotors = GetRotorByFormName(r1);
            SelectedRotors.Next = GetRotorByFormName(r2);
            SelectedRotors.Next.Next = GetRotorByFormName(r3);
            SelectedRotors.Offset = off1;
            SelectedRotors.Next.Offset = off2;
            SelectedRotors.Next.Next.Offset = off3;
        }
        public static void SetReflector(int Ref)
        {
            switch (Ref)
            {
                case 0:
                    SelectedReflector = Reflectors.Reflector1;
                    return;
                case 1:
                    SelectedReflector = Reflectors.Reflector2;
                    return;
                case 2:
                    SelectedReflector = Reflectors.Reflector3;
                    return;
                default:
                    SelectedReflector = Reflectors.Reflector1;
                    return;
            }
        }
        private static Rotor GetRotorByFormName(string r)
        {
            if (r == "Rotor 1")
            {
                return new Rotor(Rotors.Rotor1);
            }
            else if (r == "Rotor 2")
            {
                return new Rotor(Rotors.Rotor2);
            }
            else if (r == "Rotor 3")
            {
                return new Rotor(Rotors.Rotor3);
            }
            else if (r == "Rotor 4")
            {
                return new Rotor(Rotors.Rotor4);
            }
            else if (r == "Rotor 5")
            {
                return new Rotor(Rotors.Rotor5);
            }
            else
            {
                return null;
            }
        }
    }

    public class Rotor
    {
        public Rotor(Rotor r)
        {
            this.Convertion = r.Convertion;
            this.Pattern = r.Pattern;
            this.Name = r.Name;
        }
        public Rotor(string pattern, int offset, int notch, string name)
        {
            //use this to set static rotor
            //set pattern, offset, notch and name
            this.Pattern = pattern;
            this.Offset = offset;
            this.Notch = notch;
            this.Name = name;
            //using the pattern set the conversion setting
            for (int i = 0; i < pattern.Length; i++)
            {
                this.Convertion[i] = settings.int_to_string.IndexOf(pattern[i]);
            }
        }
        public Rotor(Rotor r, Rotor next)
        {
            //set this roter to the same values as another rotter and next rotter for linked list roter
            this.Convertion = r.Convertion;
            this.Pattern = r.Pattern;
            this.Next = next;
            this.Name = r.Name;
        }
        public Rotor(Rotor r, Rotor next, Rotor prev)
        {
            //set this roter to the same values as another rotter and next and previous rotter for double-linked list roter
            this.Convertion = r.Convertion;
            this.Pattern = r.Pattern;
            this.Next = next;
            this.Prev = prev;
            this.Name = r.Name;
        }
        public string Name = null;
        public int[] Convertion = new int[26];
        public string Pattern { get; private set; }
        public Rotor Next = null;
        public Rotor Prev = null;
        public int Offset = 0;
        public int Notch = 0;
        public void Rotate()
        {
            //simulate rotating the rotor

            //if the offset is the same as notch rotate next rotor
            if (Offset == Notch)
            {
                //only rotate next rotor if next rotor exsists
                if (Next != null)
                {
                    this.Next.Rotate();
                }
            }
            //if rotor is at last letter goto first letter
            if(Offset == 25)
            {
                Offset = 0;
                return;
            }
            //"else" rotate forward one letter
            Offset++;
        }
        public int GetConvertion(int In)
        {
            //add offset to In
            int _In = In + Offset;
            //if _In is greater than 25 subtract 25
            if(_In > 25)
            {
                _In -= 25;
            }
            return Convertion[_In];
        }
    }

    public class Reflector
    {
        public Reflector(string pattern, string name)
        {
            //set pattern and name
            this.Pattern = pattern;
            this.Name = name;
            //set converion based on pattern.
            for (int i = 0; i < pattern.Length; i++)
            {
                this.Convertion[i] = settings.int_to_string.IndexOf(pattern[i]);
            }
        }
        public Reflector(Reflector r)
        {
            //set pattern and convertion and name
            this.Pattern = r.Pattern;
            this.Convertion = r.Convertion;
            this.Name = r.Name;
        }
        int[] Convertion = new int[26];
        public string Name { get; private set; }
        public string Pattern { get; private set; }
        public int GetConvertion(int In)
        {
            return Convertion[In];
        }
    }

    public class Plugboard
    {
        int[] Default = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
        public int[] Plugs { get; private set; } = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
        public Color[] Colors = new Color[26];
        public void Reset()
        {
            Plugs = Default;
        }
        public void SetPlug(int Plug1, int Plug2)
        {
            Plugs[Plug1] = Plug2;
            Plugs[Plug2] = Plug1;
        }
        public int GetPlugConvertion(int plug)
        {
            return this.Plugs[plug];
        }
    }

    
}
