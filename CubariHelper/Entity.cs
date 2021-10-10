using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubariHelper
{
    public class Entity
    {
        public string title { get; set; } = "";
        public string description { get; set; } = "";
        public string artist { get; set; } = "";
        public string author { get; set; } = "";
        public string cover { get; set; } = "";

        public Dictionary<string, ChapterDetails> chapters { get; set; }
    }

    public class ChapterDetails
    {
        public string title { get; set; } = "";
        public string volume { get; set; } = "";
        public Dictionary<string, string> groups { get; set; }
        public string last_updated { get; set; } = "";
    }
}
