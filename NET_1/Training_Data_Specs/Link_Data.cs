using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_1.Training_Data_Specs
{
    public class Link_Data : Training_Info
    {
        private string _contentUri;
        public LinkTypes LinkType { get; set; }

        
        public string Uri
        {
            get { return _contentUri; }
            set { _contentUri = value.Length != 0 ? value : "Your Content Uri is empty"; }
        }

        public override string ToString()
        {
            return base.ToString() + LinkType + Uri;
        }
    }
}
