using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Management.Automation;

namespace SimplePwshInterpretorLib
{

    internal sealed class SimplePwshInterpretorSingleton
    {
        PowerShell _powerShell = null;

        // THIS WILL THROW EXCECPTION IF CREATION FAILS
        private SimplePwshInterpretorSingleton()
        {
            _powerShell = PowerShell.Create();
        }
        private static readonly Lazy<SimplePwshInterpretorSingleton> lazy = new Lazy<SimplePwshInterpretorSingleton>(() => new SimplePwshInterpretorSingleton());
        public static SimplePwshInterpretorSingleton Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        public bool AddScript(string script)
        {
            _powerShell.AddScript(script);

            return true;
        }

        public DataTable Eval()
        {
            Collection<PSObject> results = _powerShell.Invoke();

            return results.ToDataTable();
        }
    }

}