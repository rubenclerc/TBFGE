using System;
using System.Windows.Forms;

public abstract class LogicError : Exception
{
    public LogicError()
    {
        MessageBox.Show(this.getMessage(), this.ToString(), MessageBoxButtons.OK);
    }


    public override string ToString()
    {
        return "Logic Error";
    }

    public abstract string getMessage();
}

