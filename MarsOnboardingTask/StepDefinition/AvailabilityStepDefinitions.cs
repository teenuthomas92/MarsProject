using System;
using TechTalk.SpecFlow;

namespace MarsOnboardingTask.StepDefinition
{
    [Binding]
    public class AvailabilityStepDefinitions
    {
        [When(@"I checked whether the Avaiability in Profile details can be edited")]
        public void WhenICheckedWhetherTheAvaiabilityInProfileDetailsCanBeEdited()
        {
            throw new PendingStepException();
        }

        [Then(@"Availability are edited successfully")]
        public void ThenAvailabilityAreEditedSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
