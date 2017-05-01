using System;

public class Event
{
    public string _name, _type, _description, _organizer, _reservedSpace, _time;
    public DateTime _date;    
        //holds name, type, description, organizer, and reservation space date and time respectively

	/// <summary>
    /// no arg constructor
    /// </summary>
    public Event()
	{
	}

    /// <summary>
    /// constructor to initiate with values 
    /// <param name="n">name</param>
    /// <param name="type"></param>
    /// <param name="desc"></param>
    /// <param name="o"></param>
    /// <param name="d"></param>
    /// <param name="time"></param>
    /// </summary>
    public Event(string name, string type, string desc, string organizer, DateTime date, DateTime time)
    {
        _name = name;
        _type = type;
        _description = desc;
        _organizer = organizer;
        _date = date.Date;
        _time = time.TimeOfDay.ToString();
    }

    //get/setters
    //public string Name
    //{
    //    get { return _name; }
    //    set { _name = value; }
    //}

    //public string Type
    //{
    //    get { return _type; }
    //    set { _type = value; }
    //}

    //public string Description
    //{
    //    get { return _description; }
    //    set { _description = value; }
    //} 

    //public string Organizer
    //{
    //    get { return _organizer; }
    //    set { _organizer = value; }
    //}

    //public string ReservedSpace
    //{
    //    get { return _reservedSpace; }
    //    set { _reservedSpace = value; }
    //}

    //public string Date
    //{
    //    get { return _date; }
    //    set { _date = value; }
    //}

    //public string Time
    //{
    //    get { return _time; }
    //    set { _time = value; }
    //}
}
