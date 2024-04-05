public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

     public string GetStandardDetails()
     {
        return $"\n{_date} at {_time}\n{_title}: {_description}\nAddress: {_address.GetFullAddress()}.";
     }
    
    public virtual string GetFullDetails()
    {
        string standardDetails = $"\n{this.GetType()}{GetStandardDetails()}";
        return standardDetails;
    }
    public string GetShortDescription()
    {
        return $"\n{this.GetType()}\n{_date} - {_title}";
    }

}