using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseAssert
{
    public class SQLServerAssertQuery : IAssertQuery
    {
        private string Table = null;
        private string Column = null;
        private string ColumnType = null;

        public void executeQuery()
        {
            string query = @"SELECT *
                            FROM INFORMATION_SCHEMA.COLUMNS
                            WHERE TABLE_CATALOG='test'
                            AND COLUMN_NAME='bla'
                            AND DATA_TYPE='bla'";
        }

        public void setColumn(string column)
        {
            Column = column;
        }

        public void setColumnType(string type)
        {
            ColumnType = type;
        }

        public void setTable(string table)
        {
            Table = table;
        }
    }
}
