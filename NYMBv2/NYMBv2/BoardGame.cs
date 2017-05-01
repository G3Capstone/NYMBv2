using System;

public class BoardGame : Item
{
    private string _publisher, _description;
    private int _id;

	#region constuctors
	public BoardGame() : base()
	{
	}

    public BoardGame(string p, string d, int i) : base()
    {
        _publisher = p;
        _description = d;
        _id = i;
    }
	#endregion

#region get/setters
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
#endregion
}
