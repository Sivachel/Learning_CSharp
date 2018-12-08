using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_StaticClassAttributes
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0; //this is an static attribute. An attribute about the class and not the object itself


        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }
    }
}
