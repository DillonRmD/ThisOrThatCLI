using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisOrThatCLI
{
    public class DatabaseFile
    {
        public string Contents { get; set; }
        public string Name { get; set; }

        public MovieCollection Movies { get; set;}

        public DatabaseFile(string fileName)
        {
            Parse(fileName);
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
    }
}
