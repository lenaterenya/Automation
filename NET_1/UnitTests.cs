using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using NET_1.Enums;
using NET_1.Training_Data_Specs;

namespace NET_1
{
    [TestClass]

    public class UnitTests
    {
        [TestMethod]
        public void VerifyLessonType()
        {
            var trainingLesson = new TrainingLesson();
            List <TrainingMaterial> trainingMaterials = new List<TrainingMaterial>();
            trainingMaterials.Add(new VideoData() { VideoFormat = VideoFormat.Avi });
            trainingMaterials.Add(new LinkData() { LinkType = LinkType.Image });

            var actualTrainingMaterial = trainingLesson.ReturnLessonType(trainingMaterials);
            Assert.AreEqual(TrainingMaterialType.VideoData.GetDisplayName(), actualTrainingMaterial.GetDisplayName());
        }

        [TestMethod]
        public void CompareTrainingMaterials()
        {
            List<TrainingMaterial> trainingMaterials1 = new List<TrainingMaterial>();
            trainingMaterials1.Add(new VideoData() { VideoFormat = VideoFormat.Avi, Id = Guid.NewGuid() });
            trainingMaterials1.Add(new LinkData() { LinkType = LinkType.Image, Id = Guid.NewGuid() });

            List<TrainingMaterial> trainingMaterials2 = new List<TrainingMaterial>();
            trainingMaterials2.Add(new TextData() { Text = MediaTypeNames.Text.Html, Id = Guid.NewGuid()});

           Assert.IsFalse(trainingMaterials1.Equals(trainingMaterials2));
        }

        [TestMethod]
        public void CloneLinkData()
        {
            var linkData = new LinkData() { Description = "This is Test link", Id = Guid.NewGuid(), LinkType = LinkType.Image, Uri = "www.mail.ru" };
            var clonedLinkData = linkData.Clone();

            Assert.AreEqual(linkData, clonedLinkData);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void VerifyException()
        {
            List<TrainingMaterial> trainingMaterials = new List<TrainingMaterial>();
            trainingMaterials.Add(new LinkData() {  LinkType = LinkType.Image, Id = Guid.NewGuid(), Uri = "http://www.sfsfsdfsgsdgsdgsdgsdgsdgsgsgsgsgsdgsdgdgsgghfgjfgfgffsdfsdfsddddddddddddddddddddd.com" });
        }
    }
}
