using System;

namespace DatabaseAssert
{
    public class AssertThat
    {
        private IAssertQuery assertQuery;
        public static TableAssert Table(string tableName)
        {
            return new TableAssert(tableName);
        }
    }
}
