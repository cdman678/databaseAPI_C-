// Add MySql Library
using MySql.Data.MySqlClient;

class Connect{
	
    //Class variables
    private MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;

    //Constructor
    public Connect(){
        Initialize();
    }

    //Initialize values
    private void Initialize(){
		
        server = "localhost";
        database = "plants"; //This may need to change to a variable since we are using multiple connections
        uid = "ubuntu";
        password = "cornisgood";
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        connection = new MySqlConnection(connectionString);
    }

    //open connection to database
    private bool OpenConnection(){
		
	try{
		connection.Open();
		return true;
	}
	catch (MySqlException ex){
		//0: Connection with server can not be found   |   1045: Error with username or password
		switch (ex.Number){		
			case 0:
				MessageBox.Show("Cannot find connection");
				break;

			case 1045:
				MessageBox.Show("Invalid username/password");
				break;
		}
		return false;
	}
    }

    //Close connection
    private bool CloseConnection(){
	try{
		connection.Close();
		return true;
	}
	catch (MySqlException ex){
		//Should display the error message generated from mySQL
		MessageBox.Show(ex.Message);
		return false;
	}

    //Insert statement
    public void Insert(){
	//TODO
    }

    //Update statement
    public void Update(){
	//TODO
    }

    //Delete statement
    public void Delete(){
	//TODO
    }

    //Select statement
    public List <string> [] Select(){
	//TODO
    }

    //Count statement
    public int Count(){
	//TODO
    }

    //Backup
    public void Backup(){
	//TODO
    }

    //Restore
    public void Restore(){
	//TODO
    }
}
