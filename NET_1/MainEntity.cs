using NET_1.Training_Data_Specs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NET_1
{
    public class MainEntity
    {
        private string _description;


        public Guid Id { get; set; }

        public string Description
        {
            get { return _description; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length <= 256)
                {
                    _description = value;
                }
                else
                {
                    throw new Exception("Description is incorrect");
                }
            }
        }

        public override string ToString()
        {
            return Description + Id;
        }

        public override bool Equals(object obj)
        {
            if (obj is MainEntity && obj != null)
            {
                MainEntity temp;
                temp = (MainEntity)obj;
                if (temp.Id == this.Id)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
