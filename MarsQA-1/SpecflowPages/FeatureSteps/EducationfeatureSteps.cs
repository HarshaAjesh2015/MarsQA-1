using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class EducationSteps
    {
        Education education = new Education();

        [Given(@"Logged into the Profile Page & Selected the Education Button")]
        public void GivenLoggedIntoTheProfilePageSelectedTheEducationButton()
        {
            education.selectEducation(Driver.driver); 
        }

        [When(@"Filled-in all the fields")]
        public void WhenFilled_InAllTheFields()
        {
            education.addEducation(Driver.driver, "", "", "", "","");

        }

        [Then(@"I should be able to see newly added education details on the profile page")]
        public void ThenIShouldBeAbleToSeeNewlyAddedEducationDetailsOnTheProfilePage()
        {
            education.saveEducation(Driver.driver);
        }

    }
}
