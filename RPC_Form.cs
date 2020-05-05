using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;

namespace discord_custom_rpc
{
    public partial class RPC_Form : Form
    {
        private Dictionary<string, string> appids = new Dictionary<string, string>();
        private string curAID = "crpc";
        private RPC myrpc = new RPC();
        public RPC_Form()
        {
            appids.Add("rl", "478676645725732879");
            appids.Add("prog", "478734568854388737");
            appids.Add("sleep", "485439731824459811");
            appids.Add("crpc", "706818636127666229");
            InitializeComponent();
            myrpc.Init(appids[curAID], lb_usr, lb_detail);
            myrpc.setRPC("In Menu", "Choosing an Activity.", new Assets() { LargeImageKey = "cdrpc-logo"});
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            switch (gameBox.Text)
            {
                case "Real Life":
                    if (curAID.Equals("rl") && myrpc.client.IsInitialized)
                    {
                        myrpc.setRPC(tb_detail.Text, tb_state.Text, new Assets() { LargeImageKey = "irl-logo"});
                    } else
                    {
                        curAID = "rl";
                        myrpc.removeRPC();
                        myrpc = new RPC();
                        myrpc.Init(appids[curAID], lb_usr, lb_detail);
                        myrpc.setRPC(tb_detail.Text, tb_state.Text, new Assets() { LargeImageKey = "irl-logo" });
                    }
                    break;
                case "Programming":
                    if (curAID.Equals("prog") && myrpc.client.IsInitialized)
                    {
                        myrpc.setRPC(tb_detail.Text, tb_state.Text, new Assets() { LargeImageKey = "prog-logo"});
                    }
                    else
                    {
                        curAID = "prog";
                        myrpc.removeRPC();
                        myrpc = new RPC();
                        myrpc.Init(appids[curAID], lb_usr, lb_detail);
                        myrpc.setRPC(tb_detail.Text, tb_state.Text, new Assets() { LargeImageKey = "prog-logo" });
                    }
                        break;
                case "Sleeping":
                    if (curAID.Equals("sleep")&&myrpc.client.IsInitialized)
                    {
                        myrpc.setRPC(tb_detail.Text, tb_state.Text, new Assets() { LargeImageKey = "sleep-logo" });
                    }
                    else
                    {
                        curAID = "sleep";
                        myrpc.removeRPC();
                        myrpc = new RPC();
                        myrpc.Init(appids[curAID], lb_usr, lb_detail);
                        myrpc.setRPC(tb_detail.Text, tb_state.Text, new Assets() { LargeImageKey = "sleep-logo" });
                    }
                    break;
                case "CustomRPC":
                    if (curAID.Equals("crpc") && myrpc.client.IsInitialized)
                    {
                            myrpc.setRPC(tb_detail.Text, tb_state.Text, new Assets() { LargeImageKey = "cdrpc-logo" });
                    }
                    else
                    {
                        curAID = "crpc";
                        myrpc.removeRPC();
                        myrpc = new RPC();
                        myrpc.Init(appids[curAID], lb_usr, lb_detail);
                            myrpc.setRPC(tb_detail.Text, tb_state.Text, new Assets() { LargeImageKey = "cdrpc-logo" });  
                    }
                    break;
                default:
                    break;
            }
        }

        private void btn_rem_Click(object sender, EventArgs e)
        {
            myrpc.removeRPC();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lib.showWeb("https://github.com/KKreibich/.Net-Discord-RPC");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lib.showWeb("https://github.com/KKreibich/.Net-Discord-RPC/releases");
        }
    }
}
