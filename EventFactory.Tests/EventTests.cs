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
}