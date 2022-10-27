using NET_1.Enums;

namespace NET_1.Training_Data_Specs
{
    public class LinkData : TrainingMaterial
    {
        private string _contentUri;
        public LinkType LinkType { get; set; }


        public string Uri
        {
            get { return _contentUri; }
            set { _contentUri = value.Length != 0 ? value : "Your Content Uri is empty"; }
        }

        public override string ToString()
        {
            return base.ToString() + LinkType + Uri;
        }

        public override object Clone()
        {
            return new LinkData()
            {
                Id = this.Id,
                Description = this.Description,
                Uri = this.Uri

            };
        }
    }
}