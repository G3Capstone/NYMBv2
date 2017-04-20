using System;

public class Binder : Item
{
    private string _size, _color, _manufacturer;   //holds size, color, and manufacturer respectively.

	/// <summary>
    /// no arg constructor
    /// </summary>
    public Binder()
        : base ("Item")
	{
        
	}

    /// <summary>
    /// constructor to initiate with values
    /// </summary>
    /// <param name="n"></param>
    /// <param name="s"></param>
    /// <param name="c"></param>
    /// <param name="m"></param>
    /// <param name="p"></param>
    public Binder(string s, string c, string m)
        : base ("Item")
    {
        _size = s;
        _color = c;
        _manufacturer = m;
    }

    
    //getters and setters
    public string Size
    {
        get { return size; }
        set { size = value; }
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public string Manufacturer
    {
        get { return manufacturer; }
        set { manufacturer = value; }
    }
}
