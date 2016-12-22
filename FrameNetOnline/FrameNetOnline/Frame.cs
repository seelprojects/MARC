using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameNetOnline
{
    public class Frame
    {
        public Target target { get; set; }
        public List<AnnotationSet> annotationSets { get; set; }
    }
}
