using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace QL_CuaHang.DAO
{
    internal class KetNoiCSDL
    {
        private static MySqlConnection cnn = new MySqlConnection();
        public static void MoKetNoi()
        {
            try
            {
                string sqlcon = @"Server=localhost;Database=ShopTraSua;Uid=root;Pwd=;";
                cnn.ConnectionString = sqlcon;
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kết nối không thành công!!");
            }
        }
        public static void DongKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }
        public static DataTable DocDuLieu(string sql, params object[] parameters)
        {
            MoKetNoi();
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            if (parameters != null && parameters.Length > 0)
            {
                for (int i = 0; i < parameters.Length; i += 2)
                {
                    cmd.Parameters.AddWithValue(parameters[i].ToString(), parameters[i + 1]);
                }
            }
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DongKetNoi();
            return dt;
        }

        // xử lý Dictionary
        public static DataTable DocDuLieu(string sql, Dictionary<string, object> parameters)
        {
            MoKetNoi();
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    cmd.Parameters.AddWithValue(param.Key, param.Value);
                }
            }
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DongKetNoi();
            return dt;
        }
        
        public static void ThucThiTruyVan(string sql, params object[] parameters)
        {
            MoKetNoi();
            MySqlCommand cmd = new MySqlCommand(sql, cnn);

            if (parameters != null && parameters.Length > 0)
            {
                for (int i = 0; i < parameters.Length; i += 2)
                {
                    cmd.Parameters.AddWithValue(parameters[i].ToString(), parameters[i + 1]);
                }
            }

            cmd.ExecuteNonQuery();
            DongKetNoi();
        }

        public static object ThucThiTruyVanLayGiaTri(string sql, params object[] parameters)
        {
            MoKetNoi(); 
            MySqlCommand cmd = new MySqlCommand(sql, cnn);

            if (parameters != null && parameters.Length > 0)
            {
                for (int i = 0; i < parameters.Length; i += 2)
                {
                    cmd.Parameters.AddWithValue(parameters[i].ToString(), parameters[i + 1]);
                }
            }

            object ketQua = cmd.ExecuteScalar(); 
            DongKetNoi(); 
            return ketQua;
        }

    }
}
