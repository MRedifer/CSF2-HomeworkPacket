using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Artist
    {

        public List<Song> ListSong { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        public Artist(string title, string genre, List<Song> listSong)
        {
            Title = title;
            Genre = genre;
            ListSong = listSong;
        }

        public override string ToString()
        {
            string songsNeeded = "";
            foreach (Song s in ListSong)
            {
                songsNeeded += s + "\n";
            }
            return string.Format("\nTitle: {0}\n" +
                "Genre: {1}\n" +
                "Songs: {2}", Title, Genre, songsNeeded);
        }




    }//end class
}//end namespace
