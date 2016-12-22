using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameNetOnline
{
    public class RootObject
    {
        public DebugInfo debug_info { get; set; }
        public List<Sentence> sentences { get; set; }
    }
}
