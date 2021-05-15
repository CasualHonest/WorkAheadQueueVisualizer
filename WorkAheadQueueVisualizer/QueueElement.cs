using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkAheadQueueVisualizer
{
    public class QueueElement
    {
        public object Element;
        public object Value;

        public QueueElement(object Element, object Value)
        {
            this.Element = Element;
            this.Value = Value;
        }

        public override string ToString()
        {
            return string.Concat(Element, " - ", Value);
        }

    }
}
