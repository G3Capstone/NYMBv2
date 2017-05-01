using System;

public class Event
{
    private string _name, _type, _description, _organizer, _reservation;    
        //holds name, type, description, organizer, and reservation respectively
    private int _month, _day, _hour, _minute;   //holds month, day, hour and time respectively

	/// <summary>
    /// no arg constructor
    /// </summary>
    public Event()
	{
	}

    /// <summary>
    /// constructor to initiate with values 
    /// </summary>
    /// <param name="n"></param>
    /// <param name="d"></param>
    /// <param name="o"></param>
    /// <param name="mo"></param>
    /// <param name="d"></param>
    /// <param name="h"></param>
    /// <param name="mi"></param>
    public Event(string n, string desc, string o, int mo, int d, int h, int mi)
    {
        _name = n;
        _description = desc;
        _organizer = o;
        _month = mo;
        _day = d;
        _hour = h;
        _minute = mi;
    }

    //get/setters
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Type
    {
        get { return _type; }
        set { _type = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    } 

    public string Organizer
    {
        get { return _organizer; }
        set { _organizer = value; }
    }

    public string Reservation
    {
        get { return _reservation; }
        set { _reservation = value; }
    }

    public int Month
    {
        get { return _month; }
        set { _month = value; }
    }

    public int Day
    {
        get { return _day; }
        set { _day = value; }
    }

    public int Hour
    {
        get { return _hour; }
        set { _hour = value; }
    }

    public int Minute
    {
        get { return _minute; }
        set { _minute = value; }
    }
}
