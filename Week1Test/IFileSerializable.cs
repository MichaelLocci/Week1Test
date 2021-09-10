using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Test
{
    public interface IFileSerializable
    {

        void SaveToFile(string fileName);
        List<Spesa> LoadFromFile(string fileName);
    }
}
