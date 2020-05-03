using DiscordRPC;
using DiscordRPC.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discord_custom_rpc
{
	class RealLifeRPC
	{
		public DiscordRpcClient client;
		public void Init()
		{
			client = new DiscordRpcClient("478676645725732879");
			client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
			client.Initialize();
		}

		public void setRPC(string details, string state, Assets assets)
		{
			client.SetPresence(new RichPresence()
			{
				Details = details,
				State = state,
				Assets = assets
			});
		}
	}

	class ProgrammingRPC
	{
		public DiscordRpcClient client;
		public void Init()
		{
			client = new DiscordRpcClient("478734568854388737");
			client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
			client.Initialize();
		}

		public void setRPC(string details, string state, Assets assets)
		{
			client.SetPresence(new RichPresence()
			{
				Details = details,
				State = state,
				Assets = assets
			});
		}
	}

	class sleepRPC
	{
		public DiscordRpcClient client;
		public void Init()
		{
			client = new DiscordRpcClient("485439731824459811");
			client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
			client.Initialize();
		}

		public void setRPC(string details, string state, Assets assets)
		{
			client.SetPresence(new RichPresence()
			{
				Details = details,
				State = state,
				Assets = assets
			});
		}
	}
}	