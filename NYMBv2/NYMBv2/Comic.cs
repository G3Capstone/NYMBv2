using System;

public class Comic
{
    private string _title, _publisher;  //holds title and publisher respectively.
    private int _isbn, _issue;          //holds isbn and issue# respectively

	/// <summary>
    /// no arg constuctor
    /// </summary>
    public Comic()
        : base ("Item")
	{
	}

    /// <summary>
    /// constructor to initiate with values
    /// </summary>
    /// <param name="t"></param>
    /// <param name="p"></param>
    /// <param name="isbn"></param>
    /// <param name="issue"></param>
    public Comic(string t, string p, int isbn, int issue)
        : base ("Item")
    {
        _title = t;
        _publisher = p;
        _isbn = isbn;
        _issue = issue;
    }

    // get/setters
    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Publisher
    {
        get { return _publisher; }
        set { _publisher = value; }
    }

    public int ISBN
    {
        get { return _isbn; }
        set { _isbn = value; }
    }

    public int Issue
    {
        get { return _issue; }
        set { _issue = value; }
    }
}
