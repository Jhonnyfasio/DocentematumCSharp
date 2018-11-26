using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace DocentematumCSharp
{
	class ConnectionSql
	{
		MySqlConnection connection;
		public ConnectionSql()
		{
			connection = new MySqlConnection("server = localhost; password =;" + "database = docentematum; " +
					"User Id = root;");
		}

		public MySqlCommand getCommand(string sentence)
		{
		MySqlCommand command = new MySqlCommand(sentence, connection);
		connection.Open();
			return command;
		}

		public void closeConnection()
		{

		}

	}
}
