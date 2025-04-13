using hmw.src.DATA.DATA.SQL.Entities;
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using Npgsql;

namespace hmw.src.DATA.DATA.SQL.Services.Implementation
{
    public class MessageService : IMessageService
    {
        private static string connectionString = "Host=localhost;Username=postgres;Password=yourpassword;Database=eng";

        public void saveMessage(Message message)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("INSERT INTO message (text, timestamp) VALUES (@text, @timestamp)", conn))
                {
                    cmd.Parameters.AddWithValue("item", message.text);
                    cmd.Parameters.AddWithValue("timestamp", message.time);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
