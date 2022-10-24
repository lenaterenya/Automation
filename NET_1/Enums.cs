using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_1
{
    public enum TrainingInfos
    {
        TextData,
        VideoData,
        LinkData
    }

    public enum VideoFormats
    {
        Unknown,
        Avi,
        Mp4,
        Flv
    }

    public enum LinkTypes
    {
        Unknown,
        Html,
        Image,
        Audio,
        Video
    }
}
