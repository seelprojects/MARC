using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameNetOnline
{
    public class Sentence
    {
        public string conll { get; set; }
        public string text { get; set; }
        public List<List<object>> relations { get; set; }
        public List<string> tokens { get; set; }
        public List<List<object>> entities { get; set; }
        public List<Frame> frames { get; set; }
    }
}
