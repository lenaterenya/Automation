using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NET_1.Enums;

namespace NET_1
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this TrainingMaterialType trainingMaterialType)
        {
            return trainingMaterialType switch
            {
                TrainingMaterialType.LinkData => "LinkData",
                TrainingMaterialType.VideoData => "VideoData",
                TrainingMaterialType.TextData => "TextData",
                _ => trainingMaterialType.ToString()
            };
        }
    }
}
