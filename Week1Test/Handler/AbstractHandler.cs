using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Test.Handler
{
    public abstract class AbstractHandler : IHandler
    {
        public string Name { get; set; }
        private IHandler _nextHandler;

        public virtual string ApprovazioneHandler(Spesa spesa)
        {
            if(_nextHandler != null)
            {
                return _nextHandler.ApprovazioneHandler(spesa);
            }
            return null;
        }

        public IHandler setNext(IHandler handler)
        {
            _nextHandler = handler;
            return _nextHandler;
        }
    }
}
