using System;

public class Item
{

    private string _name;   //holds name
    private string _price;  //holds price
	private string _qty;	//holds quantity

	#region constuctors
    /// <summary>
    /// constructor to initiate with values
    /// </summary>
    /// <param name="n"></param>
    /// <param name="p"></param>
    public Item(string n, string p, string q)
    {
        _name = n;
        _price = p;
		_qty = q;
    }

	/// <summary>
	/// no arg constuctor
	/// </summary>
	public Item()
	{
        _name = null;
        _price = null;
		_qty = null;
	}
#endregion

	#region get/setters
	//get/setters
	public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Price
    {
        get { return _price; }
        set { _price = value; }
    }

	public string Qty
	{
		get { return _qty; }
		set { _qty = value; }
	}
#endregion
}
