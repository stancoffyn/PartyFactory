public interface IEventObject 
{
    long DatabaseId{ get; set; }

    void Populate();

    string RunEvent();   
}