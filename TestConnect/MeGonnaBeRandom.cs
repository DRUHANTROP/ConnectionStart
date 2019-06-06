using FastReport;
using FastReport.Data;
using FastReport.Data.ConnectionEditors;
using FastReport.Utils;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;


namespace TestConnect
{
    public partial class MeGonnaBeRandom : DataConnectionBase
    {
        public override string QuoteIdentifier(string value, DbConnection connection)
        {
            return value+connection;
        }
        public override ConnectionEditorBase GetEditor()
        {
            return new NameConnectionEditor();
        }
    }
}
