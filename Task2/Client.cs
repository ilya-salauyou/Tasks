using System;
using System.Collections.Generic;

namespace Task2
{
	class Client
	{

		public string FirstName { get; private set; }
		public string LastName { get; private set; }
		public ClientTypes ClientType { get; private set; }
		Dictionary<string, string> clientTypes;

		public Client() 
		{
			clientTypes = new Dictionary<string, string>
			{
				{"Премиум", "Premium" },
				{"Стандарт", "Standard" },
				{"Новый", "New" }
			};
		}


		public void Register(string firstName, string lastName, string clientType)
		{
			if (String.IsNullOrEmpty(firstName) || String.IsNullOrEmpty(lastName))
				throw new Exception("Имя и/или фамилия не введены");

			Enum.TryParse(clientTypes.GetValueOrDefault(clientType), out ClientType);
			try
			{
				FirstName = NameFormater(firstName);
				LastName = NameFormater(lastName);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			Console.WriteLine($"{FirstName} {LastName} {ClientType.ToString()}");
		}

		public string NameFormater(string name)
		{
			name = name.Replace(" ", "");
			return name[0].ToString().ToUpper() + name.Substring(1, name.Length - 1).ToLower();
		}
	}
	public enum ClientTypes
	{
		 Standard, Premium, New
	}


}
