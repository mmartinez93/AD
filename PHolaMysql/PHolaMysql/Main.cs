using System;

using MySql.Data.MySqlClient;

namespace Serpis.Ad
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string connectionString =
				"Server=localhost;" +
				"Database=dbprueba;" +
				"User Id=root;" +
				"Password=sistemas";
			
			MySqlConnection mySqlConnection = new MySqlConnection(connectionString);		
			mySqlConnection.Open();
					
			//select * from categoria
			//crear variable MySqlCommand
			MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();			
			mySqlCommand.CommandText= "select * from categoria";
			
			//crear variable ExecuterReader
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			
			
			Console.WriteLine(string.Join("  ", getColumnNames(mySqlDataReader)));
			
			//Cerrar
			mySqlDataReader.Close();			
			mySqlConnection.Close();
			Console.WriteLine("-----OK-----");
		}
		
		private static string[] getColumnNames(MySqlDataReader mySqlDataReader) {
		
			string[] columnName = new string [mySqlDataReader.FieldCount];
			
//			int fieldCount = mySqlDataReader.FieldCount;
//					
//			for (int index = 0; index < fieldCount; index++) {
//			string nombre = mySqlDataReader.GetName(index);
//			Console.Write(nombre + "      ");
//			}
			
			for (int index = 0; index < columnName.Length; index++){
			Console.Write(columnName[index] + "    ");	
			}		
			Console.WriteLine();
			
			return columnName;
	}
}
}
