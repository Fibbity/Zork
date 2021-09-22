using Zork;
using System.Diagnostics;
using System;

//--------------------------//
public static class Assert
//--------------------------//
{
    [Conditional("DEBUG")]

    //--------------------------//
    public static void IsTrue(bool expression, string message = null)
    //--------------------------//
    {
        if (expression == false)
        {
            throw new Exception(message);
        }

    }//END IsTrue
}
