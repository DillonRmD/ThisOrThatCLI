using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisOrThatCLI
{
    public class Movie
    {
        public string Title { get; set; }
        public int Elo { get; set; }

        public Movie(string title, int elo)
        {
            Title = title;
            Elo = elo;
        }

    }
}
