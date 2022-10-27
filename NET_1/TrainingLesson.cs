using NET_1.Enums;
using NET_1.Training_Data_Specs;

namespace NET_1
{
    public class TrainingLesson : TrainingMaterial, IVersionable, ICloneable
    {
        public List<TrainingMaterial> trainingMaterial { get; set; }

        byte[] version = new byte[IVersionable.ArraySize];

        public TrainingMaterialType ReturnLessonType(List<TrainingMaterial> trainingMaterial)
        {
            if (trainingMaterial.Any(x => x is VideoData))
            {
                return TrainingMaterialType.VideoData;
            }
            else
            {
                return TrainingMaterialType.TextData;
            }
        }

        byte[] IVersionable.GetVersion()
        {
            byte[] getVersion = new byte[IVersionable.ArraySize];
            version.CopyTo(getVersion, 0);
            return getVersion;
        }

        void IVersionable.SetVersion(byte[] arr)
        {
            version = arr;
        }

        public object Clone()
        {
            List<TrainingMaterial> clonedInfo = new List<TrainingMaterial>();

            foreach (var info in trainingMaterial)
            {
                clonedInfo.Add((TrainingMaterial)info.Clone());
            }
            return new TrainingLesson()
            {
                Id = this.Id,
                Description = this.Description,
                version = this.version,
                trainingMaterial = clonedInfo
            };
        }
    }
}