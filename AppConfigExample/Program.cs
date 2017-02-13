using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConfigExample
{
	class Program
	{
		static void Main(string[] args)
		{
			/////////////////////////////////////////////////////////
			// Display all of the values added through the app.config file.
			/////////////////////////////////////////////////////////
			
			Console.WriteLine("\nDatabase Servers:");
			foreach (var databaseServer in SimpleExamplesData.DatabaseServers.DatabaseServersList)
			{
				Console.WriteLine(databaseServer);
			}
			
			Console.WriteLine("\nEndpoints:");
			foreach (var endpoint in AdvancedExamplesData.Endpoints.EndpointsList)
			{
				string securityGroups = string.Join(",", endpoint.ServerInfo.SecurityGroupsAllowedToSaveChanges);
				Console.WriteLine(string.Format("Name = '{0}', Address = '{1}', UseSSL = '{2}', SecurityGroups = '{3}'.", endpoint.Name, endpoint.ServerInfo.Address, endpoint.ServerInfo.UseSsl, securityGroups));
			}

			Console.WriteLine("\nEnvironments:");
			foreach (var environment in AdvancedExamplesData.Environments.EnvironmentsList)
			{
				Console.WriteLine(environment);
			}

			Console.WriteLine("\nData Centers:");
			foreach (var dataCenter in AdvancedExamplesData.DataCenters.DataCentersList)
			{
				Console.WriteLine(string.Format("Name = '{0}', Value = '{1}'.", dataCenter.Name, dataCenter.Value));
			}


			/////////////////////////////////////////////////////////
			// We can also add more values to these lists in code. 
			/////////////////////////////////////////////////////////

			SimpleExamplesData.DatabaseServers.AddDatabaseServer("TrainingDbServer.YourDomain.local");
			Console.WriteLine("\nDatabase Servers (after adding Training server through code):");
			foreach (var databaseServer in SimpleExamplesData.DatabaseServers.DatabaseServersList)
			{
				Console.WriteLine(databaseServer);
			}

			AdvancedExamplesData.Environments.AddEnvironment("Training");
			Console.WriteLine("\nEnvironments (after adding Training environment through code):");
			foreach (var environment in AdvancedExamplesData.Environments.EnvironmentsList)
			{
				Console.WriteLine(environment);
			}

			Console.WriteLine("\nPress any key to exit...");
			Console.ReadKey();
		}
	}
}
