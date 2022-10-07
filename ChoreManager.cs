using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadChoresMain
{
   class ChoreManager
    {
        
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=chores";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }
        
        public static void AddChore(ChoreItem item)
        {
            string sql = "INSERT INTO chore VALUES(NULL,@ChoreName, @Amount, NULL, @Approved)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@ChoreName", MySqlDbType.VarChar).Value = item.ChoreName;
            cmd.Parameters.Add("@Amount", MySqlDbType.Double).Value = item.Amount;
            cmd.Parameters.Add("@Approved", MySqlDbType.VarChar).Value = false;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Chore not added \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();

        }

        public List<ChoreItem> AllChores()
        {
            
                List<ChoreItem> choresList = new List<ChoreItem>();
                ChoreItem item;
                string sql = "SELECT * FROM chore";
                MySqlConnection con = GetConnection();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = System.Data.CommandType.Text;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int Id = (int)reader[0];
                    string name = reader[1].ToString();
                    double amount = (double)reader[2];
                    DateTime date = (DateTime)reader[3];
                    Boolean approved = (Boolean)reader[4];
                    item = new ChoreItem(Id, name, amount, date, approved);

                    choresList.Add(item);
                }

                con.Close();
                return choresList;
            
            }

        public List<ChoreItem> UnapprovedChores()
        {

            List<ChoreItem> choresList = new List<ChoreItem>();
            ChoreItem item;
            string sql = "SELECT * FROM chore WHERE Approved = false";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int Id = (int)reader[0];
                string name = reader[1].ToString();
                double amount = (double)reader[2];
                DateTime date = (DateTime)reader[3];
                Boolean approved = (Boolean)reader[4];
                item = new ChoreItem(Id, name, amount, date, approved);

                choresList.Add(item);
            }

            con.Close();
            return choresList;

        }

        public List<ChoreItem> ApprovedChores()
        {

            List<ChoreItem> choresList = new List<ChoreItem>();
            ChoreItem item;
            string sql = "SELECT * FROM chore WHERE Approved = true";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int Id = (int)reader[0];
                string name = reader[1].ToString();
                double amount = (double)reader[2];
                DateTime date = (DateTime)reader[3];
                Boolean approved = (Boolean)reader[4];
                item = new ChoreItem(Id, name, amount, date, approved);

                choresList.Add(item);
            }

            con.Close();
            return choresList;

        }

        public Double UnpaidChores()
        {

            Double unpaidTotal = 0.00;

            string sql = "SELECT * FROM chore WHERE Approved = false";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int Id = (int)reader[0];
                string name = reader[1].ToString();
                double amount = (double)reader[2];
                DateTime date = (DateTime)reader[3];
                Boolean approved = (Boolean)reader[4];

                unpaidTotal += amount;
            }

            con.Close();
            return unpaidTotal;

        }

        public Double PaidChores()
        {

            Double paidTotal = 0.00;

            string sql = "SELECT * FROM chore WHERE Approved = true";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int Id = (int)reader[0];
                string name = reader[1].ToString();
                double amount = (double)reader[2];
                DateTime date = (DateTime)reader[3];
                Boolean approved = (Boolean)reader[4];

                paidTotal += amount;
            }

            con.Close();
            return paidTotal;

        }

        public List<ChoreItem> DateSearchChores(DateTime date1, DateTime date2)
        {

            List<ChoreItem> choresList = new List<ChoreItem>();
            ChoreItem item;
            string sql = "SELECT * FROM chore WHERE Date BETWEEN @date1 AND @date2";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@date1", MySqlDbType.DateTime).Value = date1;
            cmd.Parameters.Add("@date2", MySqlDbType.DateTime).Value = date2;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int Id = (int)reader[0];
                string name = reader[1].ToString();
                double amount = (double)reader[2];
                DateTime date = (DateTime)reader[3];
                Boolean approved = (Boolean)reader[4];
                item = new ChoreItem(Id, name, amount, date, approved);

                choresList.Add(item);
            }

            con.Close();
            return choresList;

        }

        public void approveAll()
        {
            string sql = "UPDATE chore SET Approved = true WHERE Approved = false";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Chores not able to approve \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();

        }

        public void approveSelected(ChoreItem item)
        {
            string sql = "UPDATE chore SET Approved = true WHERE Approved = false AND ChoreName = @name AND Date = @date";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = item.ChoreName;
            cmd.Parameters.Add("@date", MySqlDbType.DateTime).Value = item.Date;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Chores not able to approve \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();

        }

        public void deleteSelected(ChoreItem item)
        {
            string sql = "DELETE FROM chore WHERE ChoreName = @name AND Date = @date";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = item.ChoreName;
            cmd.Parameters.Add("@date", MySqlDbType.DateTime).Value = item.Date;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Chores not able to approve \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();

        }



    }
}
