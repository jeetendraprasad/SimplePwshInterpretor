
using System.Data;

namespace SimplePwshInterpretorLib
{
    interface ISimplePwshInterpretor
    {
        bool AddScript(string script);
        DataTable Eval();
    }
}