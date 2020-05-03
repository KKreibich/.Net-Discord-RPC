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
        public RPC_Form()
        {
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
                    RealLifeRPC rlrpc = new RealLifeRPC();
                    rlrpc.Init();
                    rlrpc.setRPC(tb_detail.Text, tb_state.Text, null);
                    break;
                case "Programming":
                    ProgrammingRPC rrpc = new ProgrammingRPC();
                    rrpc.Init();
                    rrpc.setRPC(tb_detail.Text, tb_state.Text, null);
                    break;
                case "Sleeping":
                    sleepRPC lrpc = new sleepRPC();
                    lrpc.Init();
                    lrpc.setRPC(tb_detail.Text, tb_state.Text, null);
                    break;
                default:
                    break;
            }
        }
    }
}
