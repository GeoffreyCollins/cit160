using System;

class Event 
{
    private string _title = "";
    private string _desc = "";
    private string _date = "";
    private string _time = "";
    private string _address = "";

    public Event()
    {

    }

    public Event(string title, string desc, string date, string time, string address)
    {
        _title = title;
        _desc = desc;
        _date = date;
        _time = time;
        _address = address;
    }
}