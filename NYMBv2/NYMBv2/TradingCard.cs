using System;

public class TradingCards : Item
{
    private string _game, _set, _is_foil, condition; //holds game and set respectively

	/// <summary>
    /// no arg constructor
    /// </summary>
    public TradingCards()
        : base ("Item")
	{
	}

    /// <summary>
    /// constructor to initiate with values
    /// </summary>
	/// <param name="n"></param>
    /// <param name="g"></param>
    /// <param name="s"></param>
    /// <param name="i"></param>
    /// <param name="c"></param>
    public TradingCards(string g, string s, string i, string c)
        : base ("Item")
    {
        _game = g;
        _set = s;
        _is_foil = i;
        _condition = c;
    }

    //get/setters
    public string Game
    {
        get { return _game; }
        set { _game = value; }
    }

    public string Set
    {
        get { return _set; }
        set { _set = value; }
    }

    public bool IsFoil
    {
        get { return _is_foil; }
        set { _is_foil = value; }
    }

    public int Condition
    {
        get { return _condition; }
        set { _condition = value; }
    }
}
