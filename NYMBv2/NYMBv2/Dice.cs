using System;

public class Dice : Item
{
    private string color, publisher; //holds color, manufactuerer, and description respectively.

	#region constructors
	/// <summary>
	/// no arg constuctor
	/// </summary>
	public Dice() : base()
	{
	}

    /// <summary>
    /// constructor to initiate with values
    /// </summary>
    /// <param name="c"></param>
    /// <param name="m"></param>
    public Dice(string c, string p) : base()
    {
        color = c;
		publisher = p;		
        ;
    }
	#endregion

	#region get/setters
	//get/setters
	public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public string Publisher
    {
        get { return publisher; }
        set { publisher = value; }
    }
#endregion
}
