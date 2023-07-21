namespace EventFactory.Tests;

using EventFactory.Lib;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void UsingFactoryToDirectlyRunEvent()
    {
        var result = new EventFactory().RunEvent(typeof(RetirementParty));
        Assert.AreEqual("Have a happy retirement!", result);
    }

    [Test]
    public void UsingFactoryToGetAnEventAndRunEvent()
    {
        var eventObject = new EventFactory().GetEvent(typeof(BirthdayParty));
        var result = eventObject.RunEvent();
        Assert.IsNotNull(eventObject);
        Assert.AreEqual("Happy birthday to you!", result);
    }

    [Test]
    public void EventShouldFailWhenAnIncorrectTypeIsProvided()
    {
        Assert.Throws<InvalidCastException>(() => {
            var eventObject = new EventFactory().GetEvent(typeof(Exception));
        });
    }

    [Test]
    public void GettingAnEventAndPopulatingCausesExpectedValues()
    {
        var eventObject = new EventFactory().GetEvent(typeof(BirthdayParty));
        eventObject.DatabaseId = 3;
        eventObject.Populate();
        var result = eventObject.RunEvent();
        Assert.IsNotNull(eventObject);
        Assert.AreEqual("Happy fifteenth birthday to you Thomas3!", result);
    }
}