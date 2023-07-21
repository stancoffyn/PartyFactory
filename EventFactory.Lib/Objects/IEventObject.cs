public interface IEventObject 
{
    long DatabaseId{ get; set; }

    void Populate(long id);

    string RunEvent();   
}