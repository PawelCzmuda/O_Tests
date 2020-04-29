using Microsoft.VisualStudio.TestTools.UnitTesting;
using Omada_TestData.HomePage;
using Omada_TestModels;

namespace Omada_AutomatedTests
{
    [TestClass]
    public class HeaderItemsTest : BaseTest
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
        public void HomePage_CheckIfHeaderMenuItemsDisplayed_ItemsDisplayed()
        {
            // arrange
            HomePage mainPage = new HomePage(driver);

            // assert
            Assert.IsTrue(mainPage.ENLink.Displayed);
            Assert.IsTrue(mainPage.DELink.Displayed);
            Assert.IsTrue(mainPage.DKLink.Displayed);
            Assert.IsTrue(mainPage.AboutUsLink.Displayed);
            Assert.IsTrue(mainPage.PartnersLink.Displayed);
            Assert.IsTrue(mainPage.ContactLink.Displayed);
            Assert.IsTrue(mainPage.StayPostedLink.Displayed);
        }

        [TestMethod]
        public void HomePage_CheckIfHeaderNavigationItemsDisplayed_ItemsDisplayed()
        {
            // arrange
            HomePage mainPage = new HomePage(driver);

            // assert
            Assert.IsTrue(mainPage.Logo.Displayed);
            Assert.IsTrue(mainPage.SoulutionLink.Displayed);
            Assert.IsTrue(mainPage.BusinessValueLink.Displayed);
            Assert.IsTrue(mainPage.ServicesLink.Displayed);
            Assert.IsTrue(mainPage.IndustriesLink.Displayed);
            Assert.IsTrue(mainPage.MoreLink.Displayed);
            Assert.IsTrue(mainPage.SearchField.Displayed);
        }

        [TestMethod]
        public void HomePage_CheckHeaderMenuItemsText_ItemsTextCorrect()
        {
            // arrange
            HomePage mainPage = new HomePage(driver);

            // assert
            Assert.AreEqual(Header.EN.GetName(), mainPage.ENLink.Text);
            Assert.AreEqual(Header.DE.GetName(), mainPage.DELink.Text);
            Assert.AreEqual(Header.DK.GetName(), mainPage.DKLink.Text);
            Assert.AreEqual(Header.AboutUs.GetName(), mainPage.AboutUsLink.Text);
            Assert.AreEqual(Header.Partners.GetName(), mainPage.PartnersLink.Text);
            Assert.AreEqual(Header.Contact.GetName(), mainPage.ContactLink.Text);
            Assert.AreEqual(Header.StayPosted.GetName(), mainPage.StayPostedLink.Text);
        }

        [TestMethod]
        public void HomePage_CheckHeaderNavigationItemsText_ItemsTextCorrect()
        {
            // arrange
            HomePage mainPage = new HomePage(driver);

            // assert
            Assert.AreEqual(Header.Solutions.GetName(), mainPage.SoulutionLink.Text);
            Assert.AreEqual(Header.BusinessValue.GetName(), mainPage.BusinessValueLink.Text);
            Assert.AreEqual(Header.Services.GetName(), mainPage.ServicesLink.Text);
            Assert.AreEqual(Header.Industries.GetName(), mainPage.IndustriesLink.Text);
            Assert.AreEqual(Header.More.GetName(), mainPage.MoreLink.Text);
        }
    }
}
