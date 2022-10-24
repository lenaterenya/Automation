using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_1
{
    public interface IVersionable
    {
        byte[] GetVersion();
        void SetVersion(byte[] arr);
    }
}
