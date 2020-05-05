namespace discord_custom_rpc
{
    partial class RPC_Form
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPC_Form));
            this.tb_detail = new System.Windows.Forms.TextBox();
            this.tb_state = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gameBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.version_label = new System.Windows.Forms.Label();
            this.btn_rem = new System.Windows.Forms.Button();
            this.lb_usr = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.lb_detail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_detail
            // 
            this.tb_detail.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_detail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_detail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_detail.Location = new System.Drawing.Point(102, 148);
            this.tb_detail.Name = "tb_detail";
            this.tb_detail.Size = new System.Drawing.Size(240, 20);
            this.tb_detail.TabIndex = 0;
            this.tb_detail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_state
            // 
            this.tb_state.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_state.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_state.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_state.Location = new System.Drawing.Point(102, 174);
            this.tb_state.Name = "tb_state";
            this.tb_state.Size = new System.Drawing.Size(240, 20);
            this.tb_state.TabIndex = 1;
            this.tb_state.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(222, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gameBox
            // 
            this.gameBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameBox.ForeColor = System.Drawing.SystemColors.Window;
            this.gameBox.Items.AddRange(new object[] {
            "Real Life",
            "Programming",
            "Sleeping",
            "CustomRPC"});
            this.gameBox.Location = new System.Drawing.Point(102, 121);
            this.gameBox.Name = "gameBox";
            this.gameBox.Size = new System.Drawing.Size(240, 21);
            this.gameBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(61, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(61, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Detail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(61, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "State";
            // 
            // version_label
            // 
            this.version_label.AutoSize = true;
            this.version_label.BackColor = System.Drawing.Color.Transparent;
            this.version_label.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.version_label.Location = new System.Drawing.Point(12, 303);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(59, 13);
            this.version_label.TabIndex = 8;
            this.version_label.Text = "v1.2-stable";
            // 
            // btn_rem
            // 
            this.btn_rem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_rem.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_rem.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_rem.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_rem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_rem.Location = new System.Drawing.Point(141, 200);
            this.btn_rem.Name = "btn_rem";
            this.btn_rem.Size = new System.Drawing.Size(75, 23);
            this.btn_rem.TabIndex = 11;
            this.btn_rem.Text = "Remove";
            this.btn_rem.UseVisualStyleBackColor = false;
            this.btn_rem.Click += new System.EventHandler(this.btn_rem_Click);
            // 
            // lb_usr
            // 
            this.lb_usr.AutoSize = true;
            this.lb_usr.BackColor = System.Drawing.Color.Transparent;
            this.lb_usr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_usr.Location = new System.Drawing.Point(138, 286);
            this.lb_usr.Name = "lb_usr";
            this.lb_usr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_usr.Size = new System.Drawing.Size(92, 13);
            this.lb_usr.TabIndex = 12;
            this.lb_usr.Text = "No user detected.";
            this.lb_usr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.MediumTurquoise;
            this.linkLabel1.Location = new System.Drawing.Point(12, 277);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "GitHub";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.LinkColor = System.Drawing.Color.MediumTurquoise;
            this.linkLabel2.Location = new System.Drawing.Point(12, 290);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(51, 13);
            this.linkLabel2.TabIndex = 14;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Releases\r\n";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // lb_detail
            // 
            this.lb_detail.AutoSize = true;
            this.lb_detail.BackColor = System.Drawing.Color.Transparent;
            this.lb_detail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_detail.Location = new System.Drawing.Point(138, 299);
            this.lb_detail.Name = "lb_detail";
            this.lb_detail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_detail.Size = new System.Drawing.Size(117, 13);
            this.lb_detail.TabIndex = 15;
            this.lb_detail.Text = "No Presence detected.";
            this.lb_detail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RPC_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::discord_custom_rpc.Properties.Resources.crdc_background;
            this.ClientSize = new System.Drawing.Size(427, 321);
            this.Controls.Add(this.lb_detail);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lb_usr);
            this.Controls.Add(this.btn_rem);
            this.Controls.Add(this.version_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_state);
            this.Controls.Add(this.tb_detail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RPC_Form";
            this.Text = "Custom Discord-RPC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_detail;
        private System.Windows.Forms.TextBox tb_state;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox gameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label version_label;
        private System.Windows.Forms.Button btn_rem;
        private System.Windows.Forms.Label lb_usr;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label lb_detail;
    }
}

