using System; 

namespace Main{
  class test { 
    public static void Main( string[] args ){ 
      Connect testconn = new Connect();
      testconn.OpenConnection;
      testconn.CloseConnection;
  }
}
