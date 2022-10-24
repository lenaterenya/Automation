using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NET_1.Training_Data_Specs
{
    public class Text_Data : Training_Info
    {
        private string _text;

        public string Text
        {
            get { return _text; }
            set { _text = value.Length < 10000 ? value : String.Empty; }
        }

        public override string ToString()
        {
            return base.ToString() + Text;
        }
    }
}

