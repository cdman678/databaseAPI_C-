using System;
using System.Collections.Generic;   //Strings
using MySql.Data.MySqlClient;

class Plants : Connect
{
    //Constructor call to base case - selecting 'plants' database
    public Plants() : base("plants")
    {
    }

    //public wrapper for 'Select * FROM plants'
    public List<string>[] ShowPlants()
    {
        return SelectAllPlants();
    }

    //Select statement
    private List<string>[] SelectAllPlants()
    {
        /***/
        string query = "SELECT * FROM masterPlants"; //hardcoded for now
        /***/

        //Create a list to store the result
        List<string>[] returnList = new List<string>[2];
        returnList[0] = new List<string>();
        returnList[1] = new List<string>();

        //Open connection
        if (Open() == true)
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
            Close();

            //return list to be displayed
            return returnList;
        }
        else
        {
            return returnList;
        }
    }
}
