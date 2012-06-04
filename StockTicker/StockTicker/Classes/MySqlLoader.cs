using System;
using MySql.Data.MySqlClient;
using System;
using System.IO;


namespace StockTicker.Classes
{

    class InputParser
    {

        private StreamReader sr;
 

        public InputParser(Sting InputFile)
        {
            sr = new StreamReader(InputFile); 

        }

        public void parseFile ()
        {
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                // parse each component of the line
                // after the parse call the insert
            
            
            
            
            
            }// Closes the !EOF while


        }// Closes the ParseFile

    }// Closes the InputParser



    
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Init();
        }

       
        private void Init(String serverName, String databaseName,String uid, String password)
        {
            server = serverName;
            database = databaseName;
            uid = uid;
            password = password;
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";"
            + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }




        //open connection to database
        private bool OpenConnection()
        {
            try
            {
             connection.Open();
             return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }// Closes OpenConnection()

        //Close connection
        private bool CloseConnection()
        {
        
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }// Closes CloseConnection()

        //Insert statement
        public void InsertStock(Sting tableName, String date, String symbol, Decimal open, Decimal close, Decimal high, Decimal low, Decimal volume, Decimal AdjClose )
        {
        }


        //Update statement
        public void Update(String TableName, String Column, String Value)
        {

        }

        //Delete statement
        public void Delete()
        {
        }

        //Select statement
        public List<string>[] Select()
        {
        }

        //Count statement
        public int Count()
        {
        }

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }

    }    
} // Ends the StockTicker Classes name space
