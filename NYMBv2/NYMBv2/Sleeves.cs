using System;

public class Sleeves : Item
{
    private string _type, _size, _color, _manufacturer; //holds type, size, color, and manufacturer respectively

#region constructors
	/// <summary>
	/// no arg constuctor
	/// </summary>
	public Sleeves() : base()
	{
	}

    /// <summary>
    /// constructor to initiate with values
    /// </summary>
    /// <param name="t"></param>
    /// <param name="s"></param>
    /// <param name="c"></param>
    /// <param name="m"></param>
    public Sleeves(string t, string s, string c, string m) : base()
    {
        _type = t;
        _size = s;
        _color = c;
        _manufacturer = m;
    }
#endregion

	#region get/setters
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
#endregion

}
