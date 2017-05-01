using System;

public class TradingCards : Item
{
    private string _game, _set, _is_foil, _condition; //holds game and set respectively

#region constructors
	/// <summary>
	/// no arg constructor
	/// </summary>
	public TradingCards() : base()
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
    public TradingCards(string g, string s, string i, string c) : base()
    {
        _game = g;
        _set = s;
        _is_foil = i;
        _condition = c;
    }
	#endregion

	#region get/setters
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

    public string IsFoil
    {
        get { return _is_foil; }
        set { _is_foil = value; }
    }

    public string Condition
    {
        get { return _condition; }
        set { _condition = value; }
    }
#endregion
}
