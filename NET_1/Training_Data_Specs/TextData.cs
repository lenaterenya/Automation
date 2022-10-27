namespace NET_1.Training_Data_Specs
{
    public class TextData : TrainingMaterial
    {
        private string _text;

        private const int _textLength = 10000;

        public string Text
        {
            get { return _text; }
            set { _text = value.Length < _textLength ? value : throw new ArgumentOutOfRangeException(); }
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