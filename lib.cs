using DiscordRPC;
using DiscordRPC.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace discord_custom_rpc
{
	class RPC
	{
		public DiscordRpcClient client;
		private Label usr_lbl;
		private Label detail_lbl;
		public void Init(string appID, Label lbl_usr, Label lbl_detail)
		{
			client = new DiscordRpcClient(appID);
			client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
			usr_lbl = lbl_usr;
			detail_lbl = lbl_detail;
			client.OnReady += Client_OnConnectionEstablished;
			client.OnPresenceUpdate += Client_OnPresenceUpdate;
			client.Initialize();
		}

		private void Client_OnPresenceUpdate(object sender, DiscordRPC.Message.PresenceMessage args)
		{
			MethodInvoker inv = delegate
			{
				try
				{
					DiscordRpcClient rsender = (DiscordRpcClient)sender;
					detail_lbl.Text = "New Presence-Detail: " + rsender.CurrentPresence.Details;
				} catch (Exception e)
				{
					detail_lbl.Text = "Error reading new Presence.";
				}
			};
			detail_lbl.Invoke(inv);
		}

		private void Client_OnConnectionEstablished(object sender, DiscordRPC.Message.ReadyMessage args)
		{
			DiscordRpcClient rsender = (DiscordRpcClient)sender;
			MethodInvoker inv = delegate
			{
				usr_lbl.Text = "Found user: " + rsender.CurrentUser;
			};
			usr_lbl.Invoke(inv);
			
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
	class lib
	{
		public static void showWeb(string url)
		{
			try
			{
				System.Diagnostics.Process.Start(url);
			} catch (Exception e)
			{
				MessageBox.Show("Could not open URL.");
			}
		}
	}
}	