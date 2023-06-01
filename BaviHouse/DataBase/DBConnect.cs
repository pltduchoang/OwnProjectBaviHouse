using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using BaviHouse.Model;

namespace BaviHouse.DataBase
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
            Initialize();

            OpenConnection();
        }
        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "utilitymanagementdatabase";
            uid = "root";
            password = "password";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
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
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<Apartment> GetData()
        {
            string query = "SELECT * FROM appartmentunits";

            var list = new List<Apartment>();


            //Create Command
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //Read the data and store them in the list
            while (dataReader.Read())
            {
                int unitNum = dataReader.GetInt32(0);
                string fName = dataReader.GetString(1);
                string lName = dataReader.GetString(2);
                DateOnly beganDate = dataReader.GetDateOnly(3);
                double deposite = dataReader.GetDouble(4);
                string phone = dataReader.GetString(5);
                double rent = dataReader.GetDouble(6);
                double waterLaundry = dataReader.GetDouble(7);
                int lastPower = dataReader.GetInt32(8);
                int power = dataReader.GetInt32(9);
                Apartment apartment = new Apartment(unitNum, fName, lName, beganDate, deposite, phone, rent, waterLaundry, lastPower, power);
                //AppartmentCreator ac = new AppartmentCreator();
                //ac.appartmentList.Add(appartmentData);
                list.Add(apartment);
            }

            //close Data Reader
            dataReader.Close();

            //close Connection
            this.CloseConnection();

            //return list to be displayed
            return list;
        }
        public void UpdateAppartment(int unitNum, string fName, string lName, double deposite, string phone, double rent, double waterLaundry,  int power)
        {

            //create mysql command
            MySqlCommand cmd = new MySqlCommand();
            //Assign the query using CommandText
            cmd.CommandText = "UPDATE appartmentunits SET fName='" + fName + "', lName='" + lName + "', deposit= '" + deposite + "',phone = '"+ phone +"',rent= '" + rent + "', waterLaundry='" + waterLaundry + "', last_power=new_power" + ", new_power='" + power + "' WHERE unitNum='" + unitNum + "'";
            //Assign the connection using Connection
            cmd.Connection = connection;

            //MySqlCommand cmd = new MySqlCommand(query, connection);
            //Execute query
            cmd.ExecuteNonQuery();

            //close connection
            this.CloseConnection();

        }
        public void UpdateUtility(int unitNum, int power)
        {
            //create mysql command
            MySqlCommand cmd = new MySqlCommand();
            //Assign the query using CommandText
            cmd.CommandText = "UPDATE appartmentunits SET last_power=new_power" + ", new_power='" + power + "' WHERE unitNum='" + unitNum + "'";

            //Assign the connection using Connection
            cmd.Connection = connection;

            //MySqlCommand cmd = new MySqlCommand(query, connection);
            //Execute query
            cmd.ExecuteNonQuery();

            //close connection
            this.CloseConnection();
        }
    }

}

