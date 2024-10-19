using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Manajemen_Hotel3
{
    class KelasKamar
    {
        DBconnect connect = new DBconnect();

        public DataTable getTipeKamar()
        {
            string selectQuery = "SELECT * FROM `kategori`";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public bool addKamar(string no, int tipe, string status)
        {
            string insertQuerry = "INSERT INTO `kamar`(`IdKamar`, `TipeKamar`, `StatusKamar`) VALUES (@no, @tipe, @status)";
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
            //@no, @tipe, @status
            command.Parameters.Add("@no", MySqlDbType.VarChar).Value = no;
            command.Parameters.Add("@tipe", MySqlDbType.Int32).Value = tipe;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = status;

            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }
        }
        public DataTable getKamarList()
        {
            string selectQuery = "SELECT * FROM `kamar`";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public bool editKamar(string no, int tipe, string status)
        {
            string editQuerry = "UPDATE `kamar` SET `TipeKamar`=@tipe,`StatusKamar`=@status WHERE `IdKamar`=@no";
            MySqlCommand command = new MySqlCommand(editQuerry, connect.GetConnection());
            //@no, @tipe, @status
            command.Parameters.Add("@no", MySqlDbType.VarChar).Value = no;
            command.Parameters.Add("@tipe", MySqlDbType.Int32).Value = tipe;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = status;

            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }
        }
        public bool removeKamar(string id)
        {
            string insertQuerry = "DELETE FROM `kamar` WHERE `IdKamar`= @id";
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
            //@id
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }
        }

    }
}
