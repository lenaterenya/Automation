namespace NET_1
{
    public class MainEntity
    {
        private string _description;
        private const int _descriptionLength = 256;

        public Guid Id { get; set; }

        public string Description
        {
            get { return _description; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length <= _descriptionLength)
                {
                    _description = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public override string ToString()
        {
            return Description + Id;
        }

        public override bool Equals(object? obj)
        {
            return obj is MainEntity temp &&
                   Id.ToString() == temp.Id.ToString();
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
