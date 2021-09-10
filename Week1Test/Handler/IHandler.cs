using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Test.Handler
{
    public interface IHandler
    {
        public string Name { get; set; }
        IHandler setNext(IHandler handler);
        string ApprovazioneHandler(Spesa spesa);
    }
}
