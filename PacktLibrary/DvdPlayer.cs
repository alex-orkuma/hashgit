using static System.Console;

namespace Packt.Shared
{
    public class DvdPlayer : Iplayable
    {
        public void Play()
        {
            WriteLine("DVD is playing");
        }

        public void Pause()
        {
            WriteLine("DVD Paused");
        }
    }
}