using System;
//using System.Collections.Generic;   //Strings - wont need for final product
using MySql.Data.MySqlClient;

class Plants : Connect
{
    //Constructor call to base case - selecting 'plants' database
    public Plants() : base("plants") { }

    //This function needs to be called after each query  function to close the connection
    public new void Close() { base.Close(); }

    //public wrapper for 'Select * FROM plants' in SelectALLPlants
    public MySqlDataReader ShowAll(string tableName) { return SelectAll(tableName); }

    //Select statement
    private MySqlDataReader SelectAll(string tableName)
    {
        //constructing query
        string queryTemp = "SELECT * FROM ";
        string query = queryTemp + tableName; 

        //Open connection
        Open();

        //Create Command
        MySqlCommand cmd = new MySqlCommand(query, connection);

        //Create a data reader and Execute the command
        MySqlDataReader dataReader = cmd.ExecuteReader();

        //return the MySqlDataReader to be used
        return (dataReader); 

    }
}
