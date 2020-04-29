using Microsoft.VisualStudio.TestTools.UnitTesting;
using Omada_TestModels;
using Omada_TestData;
using OpenQA.Selenium;
using Omada_TestModels.HeaderMeanu;

namespace Omada_AutomatedTests.HeaderMenuTests
{
    [TestClass]
    public class SearchFunctionalityTests : BaseTest
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            BaseClassInitialize();
            HomePage mainPage = new HomePage(driver);
            mainPage.SearchField.SendKeys(Keys.Enter);

        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            QuitDriver();
        }



        [TestMethod]
        [DynamicData("TestData", typeof(Search))]
        public void SearchFunctionality_InputSearchStringAndSearch_SearchPerformed(Search expectedValue)
        {
            // arrange
            SearchPage searchPage = new SearchPage(driver);
            searchPage.SearchField.SendKeys(expectedValue.GetName() + Keys.Enter);

            // assert
            Assert.IsTrue(searchPage.SearchField.Displayed);
            Assert.IsTrue(searchPage.SearchButton.Displayed);
            Assert.IsTrue(searchPage.SearchResults.Displayed);

            // cleanup
            searchPage.SearchField.Clear();
        }

        [TestMethod]
        public void SearchFunctionality_CheckSearchField_SearchResultsDisplayed()
        {
            // arrange
            SearchPage searchPage = new SearchPage(driver);
            searchPage.SearchField.SendKeys(Search.OmadaString.ToString() + Keys.Enter);

            // assert
            Assert.IsTrue(searchPage.SearchResults.Text.Contains(Search.OmadaString.ToString()));

            // cleanup
            searchPage.SearchField.Clear();
        }
    }
}
