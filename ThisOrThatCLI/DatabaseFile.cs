using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisOrThatCLI
{
    public class DatabaseFile
    {
        public string Contents { get; set; }
        public string Name { get; set; }

        public FileInfo fileInformation { get => new FileInfo(Name); }
        public MovieCollection Movies { get; set;}

        public DatabaseFile(string fileName)
        {
            Parse(fileName);
        }

        public Movie FindMovieFromTitle(string title)
        {
            return this.Movies.Find(i => i.Title.Equals(title));
        }

        public void RemoveMovie(Movie movie)
        {
            this.Movies.Remove(movie);
        }

        public void RemoveMovie(int index)
        {
            this.Movies.RemoveAt(index);
        }

        public void Parse(string fileName)
        {
            try
            {
                Name = fileName;
                Contents = System.IO.File.ReadAllText(Name);
                Movies = Newtonsoft.Json.JsonConvert.DeserializeObject<MovieCollection>(Contents);
            }
            catch(Exception e)
            {
                // do some thing
            }
        }

        public void Update()
        {
            try
            {
                string serializedContent = Newtonsoft.Json.JsonConvert.SerializeObject(Movies);
                File.WriteAllText(fileInformation.FullName, Contents);
            }
            catch(Exception e)
            {

            }
        }
    }
}
