using System;
using System.Data;

namespace SimplePwshInterpretorLib
{
    public class SimplePwshInterpretor : ISimplePwshInterpretor
    {
        private SimplePwshInterpretorSingleton _simplePwshInterpretorSingleton;

        public SimplePwshInterpretor()
        {
            _simplePwshInterpretorSingleton = SimplePwshInterpretorSingleton.Instance;
        }

        public DataTable Eval()
        {
            return new DataTable();
        }

        public bool AddScript(string expression)
        {
            return _simplePwshInterpretorSingleton.AddScript(expression);
        }
    }
}