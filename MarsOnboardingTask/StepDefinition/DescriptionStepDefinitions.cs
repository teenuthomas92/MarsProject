using System;
using TechTalk.SpecFlow;

namespace MarsOnboardingTask.StepDefinition
{
    [Binding]
    public class DescriptionStepDefinitions
    {
        [When(@"I checked whether the Description in Profile details can be edited")]
        public void WhenICheckedWhetherTheDescriptionInProfileDetailsCanBeEdited()
        {
            throw new PendingStepException();
        }

        [Then(@"Description are edited successfully")]
        public void ThenDescriptionAreEditedSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
