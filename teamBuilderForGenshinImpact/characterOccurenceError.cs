using System;

public class CharacterOccurenceError: LogicError
{
	public CharacterOccurenceError()
	{
	}

    public override string getMessage()
    {
        return "You already add this character.";
    }
}
