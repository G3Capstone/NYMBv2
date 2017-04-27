using System;

public class BoardGame : Item
{
    private string _publisher, _description;
    private int _id;
    
	public BoardGame()
        : base ("Item")
	{
	}

    public BoardGame(string p, string d, int i)
        : base ("Item")
    {
        _publisher = p;
        _description = d;
        _id = i;
    }

    public string Publisher
    {
        get { return _publisher; }
        set { _publisher = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public int ID
    {
        get { return _id; }
        set { _id = value; }
    }
}
