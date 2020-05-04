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
            myrpc.Init(appids[curAID]);
            myrpc.setRPC("In Menu", "Choosing an Activity.", null);
            InitializeComponent();
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
                        myrpc.setRPC(tb_detail.Text, tb_state.Text, null);
                    } else
                    {
                        curAID = "rl";
                        myrpc.removeRPC();
                        myrpc = new RPC();
                        myrpc.Init(appids[curAID]);
                        myrpc.setRPC(tb_detail.Text, tb_state.Text, null);
                    }
                    break;
                case "Programming":
                    if (curAID.Equals("prog") && myrpc.client.IsInitialized)
                    {
                        myrpc.setRPC(tb_detail.Text, tb_state.Text, null);
                    }
                    else
                    {
                        curAID = "prog";
                        myrpc.removeRPC();
                        myrpc = new RPC();
                        myrpc.Init(appids[curAID]);
                        myrpc.setRPC(tb_detail.Text, tb_state.Text, null);
                    }
                        break;
                case "Sleeping":
                    if (curAID.Equals("sleep")&&myrpc.client.IsInitialized)
                    {
                        myrpc.setRPC(tb_detail.Text, tb_state.Text, null);
                    }
                    else
                    {
                        curAID = "sleep";
                        myrpc.removeRPC();
                        myrpc = new RPC();
                        myrpc.Init(appids[curAID]);
                        myrpc.setRPC(tb_detail.Text, tb_state.Text, null);
                    }
                    break;
                case "CustomRPC":
                    if (curAID.Equals("crpc") && myrpc.client.IsInitialized)
                    {
                        myrpc.setRPC(tb_detail.Text, tb_state.Text, null);
                    }
                    else
                    {
                        curAID = "crpc";
                        myrpc.removeRPC();
                        myrpc = new RPC();
                        myrpc.Init(appids[curAID]);
                        myrpc.setRPC(tb_detail.Text, tb_state.Text, null);
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
    }
}
