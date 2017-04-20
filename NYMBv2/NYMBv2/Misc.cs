using System;

public class Misc : Item
{
    private string _descrip; //holds description

	/// <summary>
    /// no arg constructor
    /// </summary>
    public Misc()
	{
	}

    /// <summary>
    /// constructor to initiate with description
    /// </summary>
    /// <param name="d"></param>
    public Misc(string d)
        : base ("Item")
    {
        _descrip = d;
    }
}
