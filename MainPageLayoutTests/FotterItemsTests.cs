using Microsoft.VisualStudio.TestTools.UnitTesting;
using Omada_TestModels;

namespace Omada_AutomatedTests
{
    [TestClass]
    public class FooterTests : BaseTest
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            BaseClassInitialize();

        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            QuitDriver();
        }


        [TestMethod]
        public void HomePage_CheckIfFotterrMenuItemsDisplayed_ItemsDisplayed()
        {
            // arrange
            HomePage mainPage = new HomePage(driver);

            // assert
            Assert.IsTrue(mainPage.SeeOfficeLocationsLink.Displayed);
            Assert.IsTrue(mainPage.FBLink.Displayed);
            Assert.IsTrue(mainPage.InLink.Displayed);
            Assert.IsTrue(mainPage.TwitterLink.Displayed);
            Assert.IsTrue(mainPage.XingLink.Displayed);
            Assert.IsTrue(mainPage.SolutionLink.Displayed);
            Assert.IsTrue(mainPage.ResourcesLink.Displayed);
            Assert.IsTrue(mainPage.CompanyLink.Displayed);
            Assert.IsTrue(mainPage.LegalLink.Displayed);
        }
    }
}
