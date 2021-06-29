using System;

public class ExistingCharacterError: LogicError
{

	public ExistingCharacterError()
	{
	}

    public override string getMessage()
    {
        return "You already added this character";
    }
}
