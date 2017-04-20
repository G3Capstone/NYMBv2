using System;

public class TabletopGame : Item
{
    private string _game, _publisher;   //holds game, and publisher respectively
    private int _game_id;   //holds game id

	/// <summary>
    /// no arg constuctor
    /// </summary>
    public TabletopGame()
        : base ("Item")
	{
	}

    /// <summary>
    /// constructor to initiate with values
    /// </summary>
    /// <param name="g"></param>
    /// <param name="p"></param>
    /// <param name="g"></param>
    public TabletopGame(string g, string p, int g)
        : base ("Item")
    {
        _game = g;
        _publisher = p;
        _game = g;
    }

    //get/setters
    public string Game
    {
        get { return _game; }
        set { _game = value; }
    }

    public string Publisher
    {
        get { return _publisher; }
        set { _publisher = value; }
    }
}
