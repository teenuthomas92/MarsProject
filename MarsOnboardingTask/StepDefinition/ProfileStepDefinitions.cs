using System;
using TechTalk.SpecFlow;

namespace MarsOnboardingTask.StepDefinition
{
    [Binding]
    public class ProfileStepDefinitions
    {
        [When(@"I checked whether the profile are created with valid details")]
        public void WhenICheckedWhetherTheProfileAreCreatedWithValidDetails()
        {
            throw new PendingStepException();
        }

        [Then(@"Profile are created successfully")]
        public void ThenProfileAreCreatedSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
