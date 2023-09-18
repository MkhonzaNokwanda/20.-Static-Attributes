using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Static_Attributes
{
    internal class Songs
    {
        public string title;
        public string artist;
        public int duration;

        //declaring a static attribute
        public static int songCount;
        //constructor
        public Songs(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }
    }
}
