using System;

public class Sleeves : Item
{
    private string _type, _size, _color, _manufacturer; //holds type, size, color, and manufacturer respectively

	/// <summary>
    /// no arg constuctor
    /// </summary>
    public Sleeves()
        : base ("Item")
	{
	}

    /// <summary>
    /// constructor to initiate with values
    /// </summary>
    /// <param name="t"></param>
    /// <param name="s"></param>
    /// <param name="c"></param>
    /// <param name="m"></param>
    public Sleeves(string t, string s, string c, string m)
        : base ("Item")
    {
        _type = t;
        _size = s;
        _color = c;
        _manufacturer = m;
    }

    //get/setters
    public string Type
    {
        get { return _type; }
        set { _type = value; }
    }

    public string Size
    {
        get { return _size; }
        set { _size = value; }
    }

    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }

    public string Manufacturer
    {
        get { return _manufacturer;}
        set { _manufacturer = value; }
    }
}
