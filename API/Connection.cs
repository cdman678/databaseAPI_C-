using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

class Connect
{

    //Class variables
    private MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;

    //Constructor
    public Connect()
    {
        Initialize();
    }

    //Initialize values
    private void Initialize()
    {

        server = "18.221.197.206"; //swithces to local host when on the server  |  Needs to be changed with each server launch
        database = "plants"; //This may need to change to a variable since we are using multiple databases
        uid = "ubuntu";
        password = "cornisgood";
        string connectionString;

        connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        connection = new MySqlConnection(connectionString);
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

    //Select statement
    public List<string>[] Select()
    {
        /***/
        string query = "SELECT * FROM masterPlants"; //hardcoded for now
        /***/

        //Create a list to store the result
        List<string>[] returnList = new List<string>[3];
        returnList[0] = new List<string>();
        returnList[1] = new List<string>();

        //Open connection
        if (this.OpenConnection() == true)
        {
            //Create Command
            MySqlCommand cmd = new MySqlCommand(query, connection);

            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //Read the data and store them in the list
            while (dataReader.Read())
            {
                returnList[0].Add(dataReader["plantID"] + "");
                returnList[1].Add(dataReader["name"] + "");
            }

            //close Data Reader
            dataReader.Close();

            /***/
            int sizeOfList = returnList[0].Count;
            Console.WriteLine("PlantID & PlantName");
            for (int i = 0; i < sizeOfList; i++)
            {
                string temp = returnList[0][i] + " : " + returnList[1][i];
                Console.WriteLine(temp);
            }
            /***/

            //close Connection
            CloseConnection();

            //return list to be displayed
            return returnList;
        }
        else
        {
            return returnList;
        }
    }

}
