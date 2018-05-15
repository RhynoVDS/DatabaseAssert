namespace DatabaseAssert
{
    public class TableAssert
    {
        private string tableName;

        public TableAssert(string tableName)
        {
            this.tableName = tableName;
        }

        public ColumnAssert HasColumn(string columnName)
        {
            return new ColumnAssert();
        }
        public void Exists() {
        }
    }
}