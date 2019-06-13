using FastReport;
using FastReport.Data;
using FastReport.Data.ConnectionEditors;
using FastReport.Utils;
using RandomicGenerator;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;


namespace TestConnect
{
    public partial class MeGonnaBeRandom : DataConnectionBase
    {
        public MeGonnaBeRandom()
        {
            IsSqlBased = false;
        }
        public override string QuoteIdentifier(string value, DbConnection connection)
        {
            return value;
        }
        public override ConnectionEditorBase GetEditor()
        {
            return new NameConnectionEditor();
        }

        protected override void SetConnectionString(string value)
        {
            DisposeDataSet();
            base.SetConnectionString(value);
        }

        public override void CreateTable(TableDataSource source)
        {
            if (DataSet.Tables.Contains(source.TableName))
            {
                source.Table = DataSet.Tables[source.TableName];
                base.CreateTable(source);
            }
            else
                source.Table = null;
        }

        public override string[] GetTableNames()
        {
            
            string[] result = new string[DataSet.Tables.Count];
            for (int i = 0; i < DataSet.Tables.Count; i++)
            {
                result[i] = DataSet.Tables[i].TableName;
            }
            return result;
        }

        protected override DataSet CreateDataSet()
        {
            DataSet result = new DataSet();
            if (!String.IsNullOrEmpty(ConnectionString))
            {
                MeGonnaBeRandomConnectionStringBuilder sb = new MeGonnaBeRandomConnectionStringBuilder();
                sb.ConnectionString = ConnectionString;

                int count = sb.RowCount;

                List<IRandomGenerator> generators = new List<IRandomGenerator>();
                DataTable table = new DataTable("Table1");

                foreach (string str in sb.Generators)
                {
                    string[] args = str.Split(':').Select(t=>t.Trim()).ToArray();

                    IRandomGenerator generator = Utils.Get(args[1]);
                    if (generator != null)
                    {

                        generator = generator.Create();
                        generator.ColumnName = args[0];


                        table.Columns.Add(generator.ColumnName, generator.Type);

                        generators.Add(generator);
                    }
                }

                for (int i = 0; i < count; i++)
                {
                    DataRow row = table.NewRow();
                    foreach (IRandomGenerator generator in generators)
                    {
                        row[generator.ColumnName] = generator.Next();
                    }
                    table.Rows.Add(row);
                }

                

                result.Tables.Add(table);
                
            }

            return result;
        }
    }
}
