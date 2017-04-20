using System;

public class Dice : Item
{
    private string _color, _manufacturer, _description; //holds color, manufactuerer, and description respectively.

	/// <summary>
    /// no arg constuctor
    /// </summary>
    public Dice()
        : base ("Item")
	{
	}

    /// <summary>
    /// constructor to initiate with values
    /// </summary>
    /// <param name="c"></param>
    /// <param name="m"></param>
    /// <param name="d"></param>
    public Dice(string c, string m, string d)
        :base ("Item")
    {
        _color = c;
        _manufacturer = m;
        _description = d;
    }

    //get/setters
    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }

    public string Manufaturer
    {
        get { return _manufacturer; }
        set { _manufacturer = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }
}
