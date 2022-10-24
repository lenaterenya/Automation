using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_1.Training_Data_Specs
{
    public class Video_Data : Training_Info, IVersionable
    {
        private string _videoUri;
        public string Image_Uri { get; set; }
        public VideoFormats VideoFormat { get; set; }

        byte[] version = {20, 21, 22, 23, 24, 25, 26, 27};


        public string Uri
        {
            get { return _videoUri; }
            set { _videoUri = value.Length != 0 ? value : "Your Video Uri is empty"; }
        }

        public override string ToString()
        {
            return base.ToString() + Description + VideoFormat + Uri + Image_Uri; 
        }

        byte[] IVersionable.GetVersion()
        {
            byte[] getVersion = new byte[8];
            version.CopyTo(getVersion, 0);
            return getVersion;
        }

        void IVersionable.SetVersion(byte[] arr)
        {
            version = arr;
        }
    }
}