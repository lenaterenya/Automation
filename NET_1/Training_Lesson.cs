using NET_1.Training_Data_Specs;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NET_1
{
    public class Training_Lesson : Training_Info, IVersionable, ICloneable
    {
        public List <Training_Info> trainingInfo { get; set; }

        byte[] version = new byte[8];

        public string ReturnLessonType(List<Training_Info> trainingInfo)
        {
            if (trainingInfo.Any(x => x is Video_Data))
            {
                return "Lesson Type is VideoLesson";
            }
            else
            {
                return "Lesson Type is TextLesson";
            }
        }

        byte[] IVersionable.GetVersion()
        {
            byte[] getVersion = new byte[8];
            version.CopyTo(getVersion,0);
            return getVersion;
        }

        void IVersionable.SetVersion(byte[] arr)
        {
            version = arr;
        }

        public object Clone()
        {
            return new Training_Lesson()
            { 
                Id = this.Id,
                Description = this.Description,
                trainingInfo = this.trainingInfo,
                version = this.version
            };
        }
    }
}
