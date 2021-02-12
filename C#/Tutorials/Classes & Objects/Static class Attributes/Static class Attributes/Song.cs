using System;
using System.Collections.Generic;
using System.Text;

namespace Static_class_Attributes
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;

        public static int songCount = 0;

        public Song(string aTittle, string aArtist, int aDuration)
        {
            title = aTittle;
            artist = aArtist;
            duration = aDuration;

            songCount++;

        }

        public int getSongCount()
        {
            return songCount;
        }
    }
}
