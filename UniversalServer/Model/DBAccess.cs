using MySql.Data.MySqlClient;
using System;

namespace DaimlerGmbHuCoKGServer.Model
{
    public delegate EventHandler ErrorEventHandler(string msg);
    public class DBAccess
    {
        public void InsertData(TempValue t, HumidValue h, PressureValue p, DateTime dt, string ipa)
        {

            using (MySqlConnection con = new MySqlConnection(@"Data Source=127.0.0.1;Database=homeserverproject;User Id=PARASIC;Password=Admin1702;SSL Mode=0"))
            {

                string insert = "INSERT INTO values_table (Temperature, HumidValue, PressureValue, Date_Time, IPA) VALUES(@temp, @humidity, @pressure, @dateTime, @ipa)";

                using (MySqlCommand command = new MySqlCommand(insert, con))
                {
                    command.Parameters.AddWithValue("@temp", t.Value + "°C");
                    command.Parameters.AddWithValue("@humidity", h.Value + " g/m³");
                    command.Parameters.AddWithValue("@pressure", p.Value + " hPa");
                    command.Parameters.AddWithValue("@dateTime", dt);
                    command.Parameters.AddWithValue("@ipa", ipa);

                    con.Open();
                    command.CommandText = insert;
                    command.Connection = con; 
                    int result = command.ExecuteNonQuery();
                }
            }
        }
    }
}
