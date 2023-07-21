public class RetirementParty : SharedEventProperties, IEventObject 
{
    private long retirementPartyId;

    public long DatabaseId { get => retirementPartyId; set => retirementPartyId = value; }

    public string RunEvent()
    {
        return $"Have a happy retirement{Name}!";
    }

    public void Populate()
    {
        // we can assume some database settings or changes may be performed here,
        // but for now we are just setting an internal class value
        Name = $" Floyd{DatabaseId}";
    }
}