using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class SkillSteps
    {
        SkillPage newSkill = new SkillPage();

        [Given(@"Logged into the Profile Page & Selected the Skills Button")]
        public void GivenLoggedIntoTheProfilePageSelectedTheSkillsButton()
        {
            newSkill.selectSkill(Driver.driver);
        }
        [When(@"Typed in skill text  box and chose skill level")]
        public void WhenTypedInSkillTextBoxAndChoseSkillLevel()
        {
            newSkill.addSkill(Driver.driver, "");
        }
        
        [Then(@"I should be able to see the updated skill on the profile page")]
        public void ThenIShouldBeAbleToSeeTheUpdatedSkillOnTheProfilePage()
        {
            newSkill.saveSkill(Driver.driver);
        }
    }
}
