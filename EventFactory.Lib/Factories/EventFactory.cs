namespace EventFactory.Lib;

public class EventFactory
{
    public string RunEvent(Type eventType)
    {
        var theEvent = (IEventObject) Activator.CreateInstance(eventType);
        return theEvent.RunEvent();
    }

    public IEventObject GetEvent(Type eventType)
    {
        return (IEventObject) Activator.CreateInstance(eventType);
    }
}
