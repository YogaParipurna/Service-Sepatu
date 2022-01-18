using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceSepatu
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ISepatu
    {
        [OperationContract]
        string TambahBahan(int ID_Bahan, string Jenis_Bahan);
        [OperationContract]
        string TambahJeniss(int ID_Jenis, string Nama_Jenis);
        [OperationContract]
        string TambahMerekk(int ID_Merek, string Nama_Merek);
        [OperationContract]
        string TambahNotaa(string ID_Nota, string Tanggal, string Bulan, string Tahun, string Jumlah);
        [OperationContract]
        string TambahUkurann(int ID_Ukuran, string Ukuran);
        [OperationContract]
        string TambahWarnaa(int ID_Warna, string Warna);
        [OperationContract]
        string editBahan(int ID_Bahan, string Jenis_Bahan);
        [OperationContract]
        string editJenis(int ID_Jenis, string Nama_Jenis);
        [OperationContract]
        string editMerek(int ID_Merek, string Nama_Merek);
        [OperationContract]
        string editNota(string ID_Nota, string Tanggal, string Bulan, string Tahun, string Jumlah);
        [OperationContract]
        string editUkuran(int ID_Ukuran, string Ukuran);
        [OperationContract]
        string editWarna(int ID_Warna, string Warna);
        [OperationContract]
        string deleteBahan(int ID_Bahan);
        [OperationContract]
        string deleteJenis(int ID_Jenis);
        [OperationContract]
        string deleteMerek(int ID_Merek);
        [OperationContract]
        string deleteNota(string ID_Nota);
        [OperationContract]
        string deleteUkuran(int ID_Ukuran);
        [OperationContract]
        string deleteWarna(int ID_Warna);

        [OperationContract]
        List<TambahBahann> ListBahan();
        [OperationContract]
        List<TambahJenis> ListJenis();
        [OperationContract]
        List<TambahMerek> ListMerek();
        [OperationContract]
        List<TambahNota> ListNota();
        [OperationContract]
        List<TambahUkuran> ListUkuran();
        [OperationContract]
        List<TambahWarna> ListWarna();

    }

    [DataContract]
    public class TambahBahann
    {
        [DataMember]
        public int ID_Bahan { get; set; }
        [DataMember]
        public string Jenis_Bahan { get; set; }
    }

    [DataContract]
    public class TambahJenis
    {
        [DataMember]
        public int ID_Jenis { get; set; }
        [DataMember]
        public string Nama_Jenis { get; set; }
    }

    [DataContract]
    public class TambahMerek
    {
        [DataMember]
        public int ID_Merek { get; set; }
        [DataMember]
        public string Nama_Merek { get; set; }
    }

    [DataContract]
    public class TambahNota
    {
        [DataMember]
        public string ID_Nota { get; set; }
        [DataMember]
        public string Tanggal { get; set; }
        [DataMember]
        public string Bulan { get; set; }
        [DataMember]
        public string Tahun { get; set; }
        [DataMember]
        public string Jumlah { get; set; }
    }

    [DataContract]
    public class TambahUkuran
    {
        [DataMember]
        public int ID_Ukuran { get; set; }
        [DataMember]
        public string Ukuran { get; set; }
    }

    [DataContract]
    public class TambahWarna
    {
        [DataMember]
        public int ID_Warna { get; set; }
        [DataMember]
        public string Warna { get; set; }
    }

}
