using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceSepatu
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Sepatu : ISepatu
    {
        string constring = "Data Source=YAPART\\YOGA;Initial Catalog=Sepatu;Persist Security Info=True;User ID=sa;Password=Crandle1";
        SqlConnection connection;
        SqlCommand com;

        public string deleteBahan(int ID_Bahan)
        {
            string a = "gagal";
            try
            {
                string sql = "delete from dbo.Bahan where ID_Bahan = '" + ID_Bahan + "'";
                connection = new SqlConnection(constring);
                com = new SqlCommand(sql, connection);
                connection.Open();
                com.ExecuteNonQuery();
                connection.Close();
                a = "sukses";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return a;
        }

        public string deleteJenis(int ID_Jenis)
        {
            string a = "gagal";
            try
            {
                string sql = "delete from dbo.Jenis where ID_Jenis = '" + ID_Jenis + "'";
                connection = new SqlConnection(constring);
                com = new SqlCommand(sql, connection);
                connection.Open();
                com.ExecuteNonQuery();
                connection.Close();
                a = "sukses";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return a;
        }

        public string deleteMerek(int ID_Merek)
        {
            string a = "gagal";
            try
            {
                string sql = "delete from dbo.Merek where ID_Merek = '" + ID_Merek + "'";
                connection = new SqlConnection(constring);
                com = new SqlCommand(sql, connection);
                connection.Open();
                com.ExecuteNonQuery();
                connection.Close();
                a = "sukses";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return a;
        }

        public string deleteNota(string ID_Nota)
        {
            string a = "gagal";
            try
            {
                string sql = "delete from dbo.Nota where ID_Nota = '" + ID_Nota + "'";
                connection = new SqlConnection(constring);
                com = new SqlCommand(sql, connection);
                connection.Open();
                com.ExecuteNonQuery();
                connection.Close();
                a = "sukses";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return a;
        }

        public string deleteUkuran(int ID_Ukuran)
        {
            string a = "gagal";
            try
            {
                string sql = "delete from dbo.Ukuran where ID_Ukuran = '" + ID_Ukuran + "'";
                connection = new SqlConnection(constring);
                com = new SqlCommand(sql, connection);
                connection.Open();
                com.ExecuteNonQuery();
                connection.Close();
                a = "sukses";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return a;
        }

        public string deleteWarna(int ID_Warna)
        {
            string a = "gagal";
            try
            {
                string sql = "delete from dbo.Warna where ID_Warna = '" + ID_Warna + "'";
                connection = new SqlConnection(constring);
                com = new SqlCommand(sql, connection);
                connection.Open();
                com.ExecuteNonQuery();
                connection.Close();
                a = "sukses";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return a;
        }

        public string editBahan(int ID_Bahan, string Jenis_Bahan)
        {
            string a = "gagal";
            try
            {
                string sql = "update dbo.Bahan set Jenis_Bahan = '" + Jenis_Bahan + "' where ID_Bahan = '" + ID_Bahan + "' ";
                connection = new SqlConnection(constring);
                com = new SqlCommand(sql, connection);
                connection.Open();
                com.ExecuteNonQuery();
                connection.Close();

                a = "sukses";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return a;
        }

        public string editJenis(int ID_Jenis, string Nama_Jenis)
        {
            string a = "gagal";
            try
            {
                string sql = "update dbo.Jenis set Nama_Jenis = '" + Nama_Jenis + "' where ID_Jenis = '" + ID_Jenis + "' ";
                connection = new SqlConnection(constring);
                com = new SqlCommand(sql, connection);
                connection.Open();
                com.ExecuteNonQuery();
                connection.Close();

                a = "sukses";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return a;
        }

        public string editMerek(int ID_Merek, string Nama_Merek)
        {
            string a = "gagal";
            try
            {
                string sql = "update dbo.Merek set Nama_Merek = '" + Nama_Merek + "' where ID_Merek = '" + ID_Merek + "' ";
                connection = new SqlConnection(constring);
                com = new SqlCommand(sql, connection);
                connection.Open();
                com.ExecuteNonQuery();
                connection.Close();

                a = "sukses";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return a;
        }

        public string editNota(string ID_Nota, string Tanggal, string Bulan, string Tahun, string Jumlah)
        {
            string a = "gagal";
            try
            {
                string sql = "update dbo.Nota set Jumlah = '" + Jumlah + "' where ID_Nota = '" + ID_Nota + "' ";
                connection = new SqlConnection(constring);
                com = new SqlCommand(sql, connection);
                connection.Open();
                com.ExecuteNonQuery();
                connection.Close();

                a = "sukses";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return a;
        }

        public string editUkuran(int ID_Ukuran, string Ukuran)
        {
            string a = "gagal";
            try
            {
                string sql = "update dbo.Ukuran set Ukuran = '" + Ukuran + "' where ID_Ukuran = '" + ID_Ukuran + "' ";
                connection = new SqlConnection(constring);
                com = new SqlCommand(sql, connection);
                connection.Open();
                com.ExecuteNonQuery();
                connection.Close();

                a = "sukses";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return a;
        }

        public string editWarna(int ID_Warna, string Warna)
        {
            string a = "gagal";
            try
            {
                string sql = "update dbo.Warna set Warna = '" + Warna + "' where ID_Warna = '" + ID_Warna + "' ";
                connection = new SqlConnection(constring);
                com = new SqlCommand(sql, connection);
                connection.Open();
                com.ExecuteNonQuery();
                connection.Close();

                a = "sukses";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return a;
        }

        public string TambahBahan(int ID_Bahan, string Jenis_Bahan)
        {
            string a = "Sukses";
            try
            {
                string sql = "insert into dbo.Bahan values ('" + ID_Bahan + "','" + Jenis_Bahan + "')";
                connection = new SqlConnection(constring);
                com = new SqlCommand(sql, connection);
                connection.Open();
                com.ExecuteNonQuery();
                connection.Close();

                a = "Sukses";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return a;
        }

        public List<TambahBahann> ListBahan()
        {
            List<TambahBahann> TambahBahann = new List<TambahBahann>(); // proses utk mendeclare nama list yang sudah dibuat
            try
            {
                string sql = "select ID_Bahan, Jenis_Bahan from Bahan";
                connection = new SqlConnection(constring);
                com = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    TambahBahann data = new TambahBahann();
                    data.ID_Bahan = reader.GetInt32(0);
                    data.Jenis_Bahan = reader.GetString(1);
                    TambahBahann.Add(data);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return TambahBahann;
        }

        public string TambahJeniss(int ID_Jenis, string Nama_Jenis)
        {
            string a = "Sukses";
            try
            {
                string sql = "insert into dbo.Jenis values ('" + ID_Jenis + "','" + Nama_Jenis + "')";
                connection = new SqlConnection(constring);
                com = new SqlCommand(sql, connection);
                connection.Open();
                com.ExecuteNonQuery();
                connection.Close();

                a = "Sukses";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return a;
        }

        public List<TambahJenis> ListJenis()
        {
            List<TambahJenis> TambahJenis = new List<TambahJenis>(); // proses utk mendeclare nama list yang sudah dibuat
            try
            {
                string sql = "select ID_Jenis, Nama_Jenis from Jenis";
                connection = new SqlConnection(constring);
                com = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    TambahJenis data = new TambahJenis();
                    data.ID_Jenis = reader.GetInt32(0);
                    data.Nama_Jenis = reader.GetString(1);
                    TambahJenis.Add(data);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return TambahJenis;
        }

        public string TambahMerekk(int ID_Merek, string Nama_Merek)
        {
            string a = "Sukses";
            try
            {
                string sql = "insert into dbo.Merek values ('" + ID_Merek + "','" + Nama_Merek + "')";
                connection = new SqlConnection(constring);
                com = new SqlCommand(sql, connection);
                connection.Open();
                com.ExecuteNonQuery();
                connection.Close();

                a = "Sukses";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return a;
        }

        public List<TambahMerek> ListMerek()
        {
            List<TambahMerek> TambahMerek = new List<TambahMerek>(); // proses utk mendeclare nama list yang sudah dibuat
            try
            {
                string sql = "select ID_Merek, Nama_Merek from Merek";
                connection = new SqlConnection(constring);
                com = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    TambahMerek data = new TambahMerek();
                    data.ID_Merek = reader.GetInt32(0);
                    data.Nama_Merek = reader.GetString(1);
                    TambahMerek.Add(data);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return TambahMerek;
        }

        public string TambahNotaa(string ID_Nota, string Tanggal, string Bulan, string Tahun, string Jumlah)
        {
            string a = "Sukses";
            try
            {
                string sql = "insert into dbo.Nota values ('" + ID_Nota + "','" + Tanggal + "','" + Bulan + "',"
                    + "" + Tahun + ",'" + Jumlah + "')";
                connection = new SqlConnection(constring);
                com = new SqlCommand(sql, connection);
                connection.Open();
                com.ExecuteNonQuery();
                connection.Close();

                a = "Sukses";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return a;
        }

        public List<TambahNota> ListNota()
        {
            List<TambahNota> TambahNota = new List<TambahNota>(); // proses utk mendeclare nama list yang sudah dibuat
            try
            {
                string sql = "select ID_Nota, Tanggal, Bulan, Tahun, Jumlah  from Nota";
                connection = new SqlConnection(constring);
                com = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    TambahNota data = new TambahNota();
                    data.ID_Nota = reader.GetString(0);
                    data.Tanggal = reader.GetString(1);
                    data.Bulan = reader.GetString(2);
                    data.Tahun = reader.GetString(3);
                    data.Jumlah = reader.GetString(4);
                    TambahNota.Add(data);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return TambahNota;
        }

        public string TambahUkurann(int ID_Ukuran, string Ukuran)
        {
            string a = "Sukses";
            try
            {
                string sql = "insert into dbo.Ukuran values ('" + ID_Ukuran + "','" + Ukuran + "')";
                connection = new SqlConnection(constring);
                com = new SqlCommand(sql, connection);
                connection.Open();
                com.ExecuteNonQuery();
                connection.Close();

                a = "Sukses";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return a;

        }

        public List<TambahUkuran> ListUkuran()
        {
            List<TambahUkuran> TambahUkuran = new List<TambahUkuran>(); // proses utk mendeclare nama list yang sudah dibuat
            try
            {
                string sql = " select ID_Ukuran, Ukuran from dbo.Ukuran ";
                connection = new SqlConnection(constring);
                com = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    /*nama class*/
                    TambahUkuran data = new TambahUkuran(); // deklarasi data, mengambil 1persatu dari database
                    //bentuk array
                    data.ID_Ukuran = reader.GetInt32(0);
                    data.Ukuran = reader.GetString(1);
                    TambahUkuran.Add(data);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return TambahUkuran;
        }

        public string TambahWarnaa(int ID_Warna, string Warna)
        {

            string a = "Sukses";
            try
            {
                string sql = "insert into dbo.Warna values ('" + ID_Warna + "','" + Warna + "')";
                connection = new SqlConnection(constring);
                com = new SqlCommand(sql, connection);
                connection.Open();
                com.ExecuteNonQuery();
                connection.Close();

                a = "Sukses";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return a;
        }

        public List<TambahWarna> ListWarna()
        {
            List<TambahWarna> TambahWarna = new List<TambahWarna>(); // proses utk mendeclare nama list yang sudah dibuat
            try
            {
                string sql = "select ID_Warna, Warna from Warna";
                connection = new SqlConnection(constring);
                com = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    TambahWarna data = new TambahWarna();
                    data.ID_Warna = reader.GetInt32(0);
                    data.Warna = reader.GetString(1);
                    TambahWarna.Add(data);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return TambahWarna;
        }
    }
}
