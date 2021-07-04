using System;

public class ResonanceError: LogicError
{
	public ResonanceError()
	{
	}

    public override string getMessage()
    {
        return "This elementary resonance is not possible.";
    }
}
