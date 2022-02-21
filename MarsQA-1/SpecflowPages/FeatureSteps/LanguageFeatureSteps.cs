using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowPages.FeatureSteps
{
    [Binding]

    
    public class LanguageFeatureSteps

    {
      
        Language language = new Language();

        [Given(@"Logged into the Profile Page & Selected the Language Button")]
        public void GivenLoggedIntoTheProfilePageSelectedTheLanguageButton()
        {

            language.selectLanguage(Driver.driver);
            
        }

        [When(@"Typed language and chose language level")]
        public void WhenTypedLanguageAndChoseLanguageLevel()
        {
            language.addLanguage(Driver.driver, "");
        }

        [Then(@"I should be able to see the updated language on the profile page")]
        public void ThenIShouldBeAbleToSeeTheUpdatedLanguageOnTheProfilePage()
        {
            language.saveLanguage(Driver.driver);
        }


    }
}
