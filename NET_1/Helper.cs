using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_1
{
    public static class Helper
    {
        public static void GenerateGuid(this MainEntity mainEntity)
        {
            mainEntity.Id = new Guid();
        }
    }
}
