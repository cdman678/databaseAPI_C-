using System;
using MySql.Data.MySqlClient;

class Connect
{

    //Class variables
    protected MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;

    //Constructor
    protected Connect(string database)
    {
        Initialize(database);
    }

    //Initialize values
    private void Initialize(string inputDatabase)
    {

        server = "3.17.67.60"; //swithces to local host when on the server  |  Needs to be changed with each server launch
        database = inputDatabase;
        uid = "ubuntu";
        password = "cornisgood";
        string connectionString;

        connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        connection = new MySqlConnection(connectionString);
    }

    protected bool Open()
    {
        return OpenConnection();
    }

    //open connection to database
    private bool OpenConnection()
    {

        try
        {
            connection.Open();
            Console.WriteLine("Connection success"); //for testing
            return true;
        }
        catch (MySqlException ex)
        {
            //0: Connection with server can not be found   |   1045: Error with username or password
            Console.WriteLine(ex.Number); //for testing
            return false;
        }
    }

    protected bool Close()
    {
        return CloseConnection();
    }

    //Close connection
    private bool CloseConnection()
    {
        try
        {
            Console.WriteLine("Close success"); //for testing
            connection.Close();
            return true;
        }
        catch (MySqlException ex)
        {
            Console.WriteLine(ex); //for testing
            return false;
        }
    }

}
