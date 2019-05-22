using FastReport.Data.ConnectionEditors;
using System.Text;

namespace TestConnect
{
    internal class NameConnectionEditor : ConnectionEditorBase
    {
        private void Localize()
        {

        }
        protected override string GetConnectionString()
        {
            StringBuilder builder = new StringBuilder();
            
            return builder.ToString();
        }
    }
}