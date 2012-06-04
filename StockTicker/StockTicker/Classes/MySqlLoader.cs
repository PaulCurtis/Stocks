using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

/*
 *  stocksim.signaturepens.ca
 *  username: stockbot
 *  password: SBHelloWorld
 *  database: signaturepens_stocksim
 *  server:   lute:yarber
 */

namespace StockTicker.Classes
{
    public class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            //Init();
        }

       
        public void Init(String serverName, String databaseName, String uid, String password)
        {
            this.server = serverName;
            this.database = databaseName;
            this.uid = uid;
            this.password = password;

            string connectionString;
            connectionString =    "SERVER=" + this.server + ";"
                                + "DATABASE=" + this.database + ";"
                                + "UID=" + this.uid + ";"
                                + "PASSWORD=" + this.password + ";";
            this.connection = new MySqlConnection(connectionString);
            this.connection.Open();
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
        public void Insert()
        {
        }

        //Update statement
        public void Update()
        {
        }

        //Delete statement
        public void Delete()
        {
        }

        //Select statement
        public List<string>[] Select()
        {
            // TODO: populate list with results.

            return null;
        }

        //Count statement
        public int Count()
        {
            return -1;
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
