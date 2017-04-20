using System;

public class Item
{

    private string _name;   //holds name
    private double _price;  //holds price

    /// <summary>
    /// constructor to initiate with values
    /// </summary>
    /// <param name="n"></param>
    /// <param name="p"></param>
    public Item(string n, double p)
    {
        _name = n;
        _price = p;
    }

    
    /// <summary>
    /// no arg constuctor
    /// </summary>
    public Item()
	{
        _name = null;
        _price = null;
	}

    //get/setters
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public double Price
    {
        get { return _price; }
        set { _price = value; }
    }
}
