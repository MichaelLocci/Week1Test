using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Test.Handler
{
    public class ManagerHandler : AbstractHandler
    {

        public override string ApprovazioneHandler(Spesa spesa)
        {
            if(spesa.Importo <= 400)
            {
                return Name;
            }
            return base.ApprovazioneHandler(spesa);
        }
    }
}
