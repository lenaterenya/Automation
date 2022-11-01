using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NET_1
{
    [TestClass]

    public class UnitTests
    {
        [TestMethod]
        public void VerifySquareMatrixChangeSubscription()
        {
            SquareMatrix<int> sqMatrix = new SquareMatrix<int>(5);
            sqMatrix[1, 1] = 6;
            Assert.IsFalse(false, "Subscription was applied");

            sqMatrix.IndexUpdate += Helper.NotifyMe;

            sqMatrix[2, 4] = 10;
            Assert.IsTrue(true, "Subscription was not applied");

            sqMatrix.IndexUpdate -= Helper.NotifyMe;

            sqMatrix[4, 4] = 3;
            Assert.IsFalse(false, "Subscription was applied");
        }

        [TestMethod]
        public void VerifyDiagonalMatrixChangeSubscription()
        {
            DiagonalMatrix<int> diagMatrix = new DiagonalMatrix<int>(5);
            diagMatrix[0, 0] = 45;
            Assert.IsFalse(false, "Subscription was applied");

            diagMatrix.IndexUpdate += Helper.NotifyMe;

            diagMatrix[1, 1] = 1;
            Assert.IsTrue(true, "Subscription was not applied");

            diagMatrix.IndexUpdate -= Helper.NotifyMe;

            diagMatrix[2, 2] = 13;
            Assert.IsFalse(false, "Subscription was applied");
        }
    }
}