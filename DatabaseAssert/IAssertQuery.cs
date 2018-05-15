namespace DatabaseAssert
{
    internal interface IAssertQuery
    {
        void setTable(string table);
        void setColumn(string column);
        void setColumnType(string type);
        void executeQuery();
    }
}