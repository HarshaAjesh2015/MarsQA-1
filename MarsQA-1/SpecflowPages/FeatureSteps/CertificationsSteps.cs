using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowPages.FeatureSteps
{
    [Binding]
    public class CertificationsSteps
    {
        Certification certification = new Certification();

        [Given(@"Given Logged into the Profile Page & Selected the Certification Button")]
        public void GivenGivenLoggedIntoTheProfilePageSelectedTheCertificationButton()
        {
            certification.selectCertification(Driver.driver);
        }
        
        [When(@"Fill-in all the certification details")]
        public void WhenFill_InAllTheCertificationDetails()
        {
            certification.addCertification(Driver.driver, "", "", "");  
        }
        
        [Then(@"I should be able see my certification details on the profile page\.")]
        public void ThenIShouldBeAbleSeeMyCertificationDetailsOnTheProfilePage_()
        {
            certification.saveCertification(Driver.driver);
        }
    }
}
