using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Manajemen_Hotel3
{
    
    class KelasReservasi
    {
        DBconnect connect = new DBconnect();
        public DataTable kamarByTipe (int tipe)
        {
            string selectQuery = "SELECT * FROM `kamar` WHERE `TipeKamar` = @tipe AND `StatusKamar` = 'Free'";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            command.Parameters.Add("@tipe", MySqlDbType.Int32).Value = tipe;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public int TipeByNoKamar(string NoKamar)
        {
            string selectQuery = "SELECT `TipeKamar` FROM `kamar` WHERE `IdKamar` = @NoKamar";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            command.Parameters.Add("@Nokamar", MySqlDbType.VarChar).Value = NoKamar;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return Convert.ToInt32(table.Rows[0][0].ToString());
        }

        public DataTable getReservasi()
        {
            string selectQuery = "SELECT * FROM `reservasi`";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        public bool setReservasiKamar(string no, string status)
        {
            string updateQuery = "UPDATE `kamar` SET `StatusKamar`=@status WHERE `IdKamar`=@no";
            MySqlCommand command = new MySqlCommand(updateQuery, connect.GetConnection());
            command.Parameters.Add("@no", MySqlDbType.VarChar).Value = no;
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

        public bool addReservasi(string IdTamu, string NoKamar, DateTime dateIn, DateTime dateOut)
        {
            string insertQuerry = "INSERT INTO `reservasi`(`IdTamu`, `NoKamar`, `DateIn`, `DateOut`) VALUES @IdTamu, @NoKamar, @DateIn, @DateOut)";
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
            //@IdTamu, @NoKamar, @DateIn, @DateOut
            command.Parameters.Add("@IdTamu", MySqlDbType.VarChar).Value = IdTamu;
            command.Parameters.Add("@Nokamar", MySqlDbType.VarChar).Value = NoKamar;
            command.Parameters.Add("@DateIn", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@DateOut", MySqlDbType.Date).Value = dateOut;

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

        public bool removeReservasi(int id)
        {
            string insertQuerry = "DELETE FROM `reservasi` WHERE `ReservId`= @id";
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

        public bool editReservasi(int ReservId, string IdTamu, string NoKamar, DateTime dateIn, DateTime dateOut)
        {
            string insertQuerry = "UPDATE `reservasi` SET `IdTamu`=@IdTamu,`NoKamar`=@NoKamar,`DateIn`=@DateIn,`DateOut`=@DateIn WHERE `ReservId`=@ReservId";
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
            //@rid, @IdTamu, @NoKamar, @DateIn, @DateOut
            command.Parameters.Add("@rid", MySqlDbType.VarChar).Value = ReservId;
            command.Parameters.Add("@IdTamu", MySqlDbType.VarChar).Value = IdTamu;
            command.Parameters.Add("@Nokamar", MySqlDbType.VarChar).Value = NoKamar;
            command.Parameters.Add("@DateIn", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@DateOut", MySqlDbType.Date).Value = dateOut;

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
