


using System;
using System.Data;


namespace SimplePwshInterpretorLib
{

    public static class ExternalExtensionMethods
    {
        public static String ToDataTableString(this DataTable dt)
        {
            var table = dt.ToConsoleTable();

            return table.ToString();
        }
    }

}