using System;
using System.Data.SQLite;
using System.IO;

namespace SQL_20._03._20
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (!File.Exists(@"C:\Users\stupi\OneDrive\Desktop\Test.db"))
            {
                SQLiteConnection.CreateFile(@"C:\Users\stupi\OneDrive\Desktop\Test.db");
                Console.WriteLine("База данных создана");
            }
            else Console.WriteLine("База данных уже есть");
            SQLiteConnection connect = new SQLiteConnection(@"Data source = C:\Users\stupi\OneDrive\Desktop\Test.db; Version = 3;");
            connect.Open();

            SQLiteCommand command;
            command = new SQLiteCommand("CREATE TABLE IF NOT EXISTS \"Employees\" (\"id\" INTEGER PRIMARY KEY AUTOINCREMENT," + "\"name\" TEXT, \"info\" TEXT)", connect);
            command.ExecuteNonQuery();
            command = new SQLiteCommand("INSERT INTO Employees(name, info) VALUES ('Kolobok', 'ochen krutoy')", connect);
            command.ExecuteNonQuery();
            command = new SQLiteCommand("SELECT * FROM \"Employees\"", connect);

            SQLiteDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                Console.WriteLine("ID " + reader["id"] + " NAME " + reader["name"] + " INFO " + reader["info"]);
            }
            reader.Close();
            
            connect.Close();
            Console.ReadKey();
        }
    }
}