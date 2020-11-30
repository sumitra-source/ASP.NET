namespace ASP.MVC.Controllers
{
    internal class SqlCommand
    {
        private string v;
        private SqlConnection sqlConnection;

        public SqlCommand(string v, SqlConnection sqlConnection)
        {
            this.v = v;
            this.sqlConnection = sqlConnection;
        }
    }
}