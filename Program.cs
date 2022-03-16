using System;
using System.Data.SqlClient;

namespace ActKoneksi
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Connecting();
        }

        public void Connecting()
        {
            using (
                SqlConnection con = new SqlConnection("data source=NITRO-AN715;Database=ProdiTI;User ID=sa;Password=123")
                )

            {
                con.Open();
                Console.WriteLine("Nerhasil Terhubung ke Database");
            }
        }

    }
}