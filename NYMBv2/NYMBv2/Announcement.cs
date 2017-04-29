using System;

public class Announcement
{
    public string _headline { get; set; }

    public string _content { get; set; }

    private DateTime _start, _end;

	public Announcement()
	{
	}

    public Announcement(string h, string c)
    {
        _headline = h;
        _content = c;
    }

    public Announcement(string h, string c, DateTime s, DateTime e)
	{
		_headline = h;
		_content = c;
		_start = s;
		_end = e;
	}

    #region Accessors and Modifiers

#endregion


}
