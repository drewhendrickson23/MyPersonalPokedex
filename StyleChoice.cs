using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace MyPersonalPokedex
{
    public class StyleChoice
    {
  
        public void PlayAnimeWow()
        {

#pragma warning disable CA1416 // Validate platform compatibility
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Drew Hendrickson\source\repos\MyPersonalPokedex\MyAudios\animewow.wav");
#pragma warning restore CA1416 // Validate platform compatibility
#pragma warning disable CA1416 // Validate platform compatibility
            simpleSound.Play();
#pragma warning restore CA1416 // Validate platform compatibility
        }

        public void PlayZaWarudo()
        {
#pragma warning disable CA1416 // Validate platform compatibility
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Drew Hendrickson\source\repos\MyPersonalPokedex\MyAudios\zawarudo.wav");
#pragma warning restore CA1416 // Validate platform compatibility
#pragma warning disable CA1416 // Validate platform compatibility
            simpleSound.Play();
#pragma warning restore CA1416 // Validate platform compatibility
        }

        public void PlayBye()
        {
#pragma warning disable CA1416 // Validate platform compatibility
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Drew Hendrickson\source\repos\MyPersonalPokedex\MyAudios\bye.wav");
#pragma warning restore CA1416 // Validate platform compatibility
#pragma warning disable CA1416 // Validate platform compatibility
            simpleSound.Play();
#pragma warning restore CA1416 // Validate platform compatibility
        }

        public void IChooseYou()
        {
#pragma warning disable CA1416 // Validate platform compatibility
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Drew Hendrickson\source\repos\MyPersonalPokedex\MyAudios\ichooseyou.wav");
#pragma warning restore CA1416 // Validate platform compatibility
#pragma warning disable CA1416 // Validate platform compatibility
            simpleSound.Play();
#pragma warning restore CA1416 // Validate platform compatibility
        }

    }
}
