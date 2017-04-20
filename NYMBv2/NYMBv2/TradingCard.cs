using System;

public class TradingCards : Item
{
    private string _game, _set; //holds game and set respectively
    private bool _is_foil;      //holds whether it's foil or not
    private int _condition;     //holds condition

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
    /// <param name="g"></param>
    /// <param name="s"></param>
    /// <param name="i"></param>
    /// <param name="c"></param>
    public TradingCards(string g, string s, bool i, int c)
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
