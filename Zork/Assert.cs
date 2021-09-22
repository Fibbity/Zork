using System;
using System.Diagnostics;
using Zork;


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

}//END Assert
