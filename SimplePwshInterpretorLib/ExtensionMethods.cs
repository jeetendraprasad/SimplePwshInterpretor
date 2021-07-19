

using System.Collections.ObjectModel;
using System.Data;
using System.Management.Automation;

namespace SimplePwshInterpretorLib
{
    internal static class ExtensionMethods
    {
        // fn to convert to DataTable.
        // PENDING OPTIMIZATION
        public static DataTable ToDataTable(this Collection<PSObject> psObjects)
        {
            DataTable dt = new DataTable();

            foreach (PSObject result in psObjects)
            {
                if (result == null)
                    continue;

                bool valuesFound = false;

                DataRow row = dt.NewRow();

                foreach (PSPropertyInfo prop in result.Properties)
                {
                    if (prop.MemberType == PSMemberTypes.AliasProperty)
                    {
                        var propName = prop.Name;
                        var propValue = prop.Value;

                        if (!dt.Columns.Contains(propName))
                            dt.Columns.Add(propName);

                        row[propName] = propValue;
                        valuesFound = true;
                    }
                    else
                    {
                        // System.Console.WriteLine(Convert.ToString(result));
                    }
                }

                if (!valuesFound)
                {
                    const string columnResult = "Result";

                    if (!dt.Columns.Contains(columnResult))
                        dt.Columns.Add(columnResult);

                    row[columnResult] = result.ToString(); // OR Convert.ToString(result)
                }

                dt.Rows.Add(row);
            }

            return dt;
        }
    }
}