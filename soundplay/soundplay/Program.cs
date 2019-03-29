using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace soundplay
{
    class Program
    {
        static void Main(string[] args)
        {
            string sound = @"C:\Users\emil8398\Desktop\Wave\M1.wav";

            SoundPlayer sp = new SoundPlayer();

            sp.SoundLocation = sound;
            sp.Load();
            sp.PlaySync();

        }
    }
}
