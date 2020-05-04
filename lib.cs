using DiscordRPC;
using DiscordRPC.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discord_custom_rpc
{
	class RPC
	{
		public DiscordRpcClient client;
		public void Init(string appID)
		{
			client = new DiscordRpcClient(appID);
			client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
			client.Initialize();
		}

		public void setRPC(string details, string state, Assets assets)
		{
			client.ClearPresence();
			client.SetPresence(new RichPresence()
			{
				Details = details,
				State = state,
				Assets = assets
			});
		}

		public void removeRPC()
		{
			if (client.IsInitialized)
			{
				client.ClearPresence();
				client.Deinitialize();
			}
		}
	}
}	