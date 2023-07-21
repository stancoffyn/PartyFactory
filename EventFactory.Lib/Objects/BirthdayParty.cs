public class BirthdayParty : SharedEventProperties, IEventObject
{
    private long birthdayPartyId;
    public string BirthdayYear { get; set; } = default!;

    public long DatabaseId { get => birthdayPartyId; set => birthdayPartyId = value; }

    public string RunEvent()
    {
        return $"Happy{BirthdayYear} birthday to you{Name}!";
    }

    public void Populate()
    {
        // we can assume some database settings or changes may be performed here,
        // but for now we are just setting an internal class value.
        Name = $" Thomas{DatabaseId}";
        BirthdayYear = " fifteenth";
    }
}