# databaseAPI_C-
NOTE:
  This code needs to be changed each time the ec2 is restarted to include the new IP.
  When this code is moved inside the ec2, we need to change server = localhost
  
  There is a .dll file that I am referencing inside my Visual Studios project that will most likely need to be added at some point
  
  
  
  [Functions]    
    Class Plants:
    
      Constructor:  Plants() - creates a connection to our mySQL server using 'plants' database
      
      Close(): This function must be used after you are done interacting with the MySqlDataReader that the query functions return
                If this function is not called, you can not do anything else within the mySQL server.
                Once this function is called, the MySqlDataReader will be essentially become NULL
                
      ShowAll(String tableName): This function accepts a table name as an input and returns the result of 'SELECT * FROM tableName' 
                Acceptable tableName inside 'plants' : description, friends_enemies , plantData, masterPlants  

    Class Gardens:
    
      Constructor:  Gardens() - creates a connection to our mySQL server using 'plants' database
      
      Close(): This function must be used after you are done interacting with the MySqlDataReader that the query functions return
                If this function is not called, you can not do anything else within the mySQL server.
                Once this function is called, the MySqlDataReader will be essentially become NULL
                
      ShowAll(String tableName): This function accepts a table name as an input and returns the result of 'SELECT * FROM tableName'
                Acceptable tableName inside 'u_gardens' : gardenGroups, gardens, plants
