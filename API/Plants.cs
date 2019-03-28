using System;
using MySql.Data.MySqlClient;

class Plants : Connect
{
    //Constructor call to base case - selecting 'plants' database
    public Plants() : base("plants") { }

    //This function needs to be called after each query function to close the connection
    public new void Close() { base.Close(); }

    //public wrapper for 'Select * FROM __' in SelectALL in Connection
    public MySqlDataReader ShowAll(string tableName) { return SelectAll(tableName); }

}
