namespace NET_1.Training_Data_Specs
{
    public class TextData : TrainingMaterial
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

        public override object Clone()
        {
            return new TextData()
            {
                Id = this.Id,
                Description = this.Description,
                Text = this.Text
            };
        }
    }
}