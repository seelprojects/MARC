using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameNetOnline
{

    public class AnnotationSet
    {
        public List<FrameElement> frameElements { get; set; }
        public double score { get; set; }
        public int rank { get; set; }
    }
}
