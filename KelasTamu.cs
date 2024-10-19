using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Manajemen_Hotel3
{

    class KelasTamu
    {
        DBconnect connect = new DBconnect();
        public bool insertTamu(string id, string namalengkap, string notelp, string email)
        {
            string insertQuerry = "INSERT INTO `tamu`(`TamuId`, `TamuNamaLengkap`, `TamuNoTelepon`, `TamuEmail`) VALUES (@id, @namalengkap, @notelp, @email)";
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
            //@id, @namalengkap, @notelp, @email
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@namalengkap", MySqlDbType.VarChar).Value = namalengkap;
            command.Parameters.Add("@notelp", MySqlDbType.VarChar).Value = notelp;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;

            connect.OpenCon();
            if(command.ExecuteNonQuery() == 1)
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

        public DataTable getTamu()
        {
            string selectQuery = "SELECT * FROM `tamu`";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();  

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        public bool editTamu(string id, string namalengkap, string notelp, string email)
        {
            string editQuerry = "UPDATE `tamu` SET `TamuNamaLengkap`=@namalengkap,`TamuNoTelepon`=@notelp,`TamuEmail`=@email WHERE `TamuId`=@id";
            MySqlCommand command = new MySqlCommand(editQuerry, connect.GetConnection());
            //@id, @namalengkap, @notelp, @email
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@namalengkap", MySqlDbType.VarChar).Value = namalengkap;
            command.Parameters.Add("@notelp", MySqlDbType.VarChar).Value = notelp;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;

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
        
        public bool removeTamu (string id)
        {
            string insertQuerry = "DELETE FROM `tamu` WHERE `TamuId` = @id";
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
