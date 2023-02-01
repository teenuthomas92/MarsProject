using System;
using TechTalk.SpecFlow;

namespace MarsOnboardingTask.StepDefinition
{
    [Binding]
    public class HoursStepDefinitions
    {
        [When(@"I checked whether the Hours in Profile details can be edited")]
        public void WhenICheckedWhetherTheHoursInProfileDetailsCanBeEdited()
        {
            throw new PendingStepException();
        }

        [Then(@"Hours are edited successfully")]
        public void ThenHoursAreEditedSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
