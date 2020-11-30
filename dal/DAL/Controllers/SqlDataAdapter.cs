using System;
using System.Data;

namespace ASP.MVC.Controllers
{
    internal class SqlDataAdapter
    {
        private SqlCommand sqlCommand;

        public SqlDataAdapter(SqlCommand sqlCommand)
        {
            this.sqlCommand = sqlCommand;
        }

        internal void Fill(DataTable dataTable)
        {
            throw new NotImplementedException();
        }
    }
}