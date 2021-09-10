using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Test.Handler
{
    public class CEOHandler : AbstractHandler
    {

        public override string ApprovazioneHandler(Spesa spesa)
        {
            if(spesa.Importo > 1001 && spesa.Importo <= 2499)
            {
                return Name;
            }
            return base.ApprovazioneHandler(spesa);
        }
    }
}
