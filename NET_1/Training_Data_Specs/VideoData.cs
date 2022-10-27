using NET_1.Enums;

namespace NET_1.Training_Data_Specs
{
    public class VideoData : TrainingMaterial, IVersionable
    {
        private string _videoUri;
        public string ImageUri { get; set; }
        public VideoFormat VideoFormat { get; set; }

        byte[] version = new byte[8];


        public string Uri
        {
            get { return _videoUri; }
            set { _videoUri = value.Length != 0 ? value : "Your Video Uri is empty"; }
        }

        public override string ToString()
        {
            return base.ToString() + Description + VideoFormat + Uri + ImageUri;
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

        public override object Clone()
        {
            return new VideoData()
            {
                Id = this.Id,
                Description = this.Description,
                Uri = this.Uri,
                ImageUri = this.ImageUri,
                version = this.version,
                VideoFormat = this.VideoFormat

            };
        }
    }
}