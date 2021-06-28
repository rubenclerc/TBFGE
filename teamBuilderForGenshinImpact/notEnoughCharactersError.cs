using System;
using System.Windows.Forms;

public class NotEnoughCharactersError: LogicError
{
	public NotEnoughCharactersError()
	{
    }

    public override string getMessage()
    {
        return "You need to have at least 4 characters to create a team.";
    }
}
