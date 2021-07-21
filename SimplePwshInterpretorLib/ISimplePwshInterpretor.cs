
using System.Data;

namespace SimplePwshInterpretorLib
{
    internal interface ISimplePwshInterpretor
    {
        bool AddScript(string script);
        DataTable Eval();
    }
}