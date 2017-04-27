using System;

public class Announcement
{
	private string _headline, _content;

	private DateTime _start, _end;

	public Announcement()
	{
	}

	public Announcement(string h, string c, DateTime s, DateTime e)
	{
		_headline = h;
		_content = c;
		_start = s;
		_end = e;
	}
}
