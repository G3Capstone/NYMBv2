using System;

public class Binder : Item
{
    private string _size, _color, _manufacturer;   //holds size, color, and manufacturer respectively.

#region constuctor
	/// <summary>
	/// no arg constructor
	/// </summary>
	public Binder() : base()
	{
        
	}

    /// <summary>
    /// constructor to initiate with values
    /// </summary>
    /// <param name="s"></param>
    /// <param name="c"></param>
    /// <param name="m"></param>
    public Binder(string s, string c, string m) : base()
	{
		_size = s;
        _color = c;
        _manufacturer = m;
    }
	#endregion

#region get/setters
	//getters and setters
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
        get { return _manufacturer; }
        set { _manufacturer = value; }
    }
#endregion
}
