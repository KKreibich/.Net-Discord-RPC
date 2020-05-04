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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_rem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_detail
            // 
            this.tb_detail.Location = new System.Drawing.Point(110, 291);
            this.tb_detail.Name = "tb_detail";
            this.tb_detail.Size = new System.Drawing.Size(240, 20);
            this.tb_detail.TabIndex = 0;
            // 
            // tb_state
            // 
            this.tb_state.Location = new System.Drawing.Point(110, 317);
            this.tb_state.Name = "tb_state";
            this.tb_state.Size = new System.Drawing.Size(240, 20);
            this.tb_state.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gameBox
            // 
            this.gameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameBox.Items.AddRange(new object[] {
            "Real Life",
            "Programming",
            "Sleeping",
            "CustomRPC"});
            this.gameBox.Location = new System.Drawing.Point(110, 264);
            this.gameBox.Name = "gameBox";
            this.gameBox.Size = new System.Drawing.Size(240, 21);
            this.gameBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Detail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "State";
            // 
            // version_label
            // 
            this.version_label.AutoSize = true;
            this.version_label.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.version_label.Location = new System.Drawing.Point(340, 399);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(105, 13);
            this.version_label.TabIndex = 8;
            this.version_label.Text = "v0.1.1-alpha (debug)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::discord_custom_rpc.Properties.Resources.bullshit_meter;
            this.pictureBox1.Location = new System.Drawing.Point(58, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 246);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btn_rem
            // 
            this.btn_rem.Location = new System.Drawing.Point(149, 343);
            this.btn_rem.Name = "btn_rem";
            this.btn_rem.Size = new System.Drawing.Size(75, 23);
            this.btn_rem.TabIndex = 11;
            this.btn_rem.Text = "Remove";
            this.btn_rem.UseVisualStyleBackColor = true;
            this.btn_rem.Click += new System.EventHandler(this.btn_rem_Click);
            // 
            // RPC_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 421);
            this.Controls.Add(this.btn_rem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.version_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_state);
            this.Controls.Add(this.tb_detail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RPC_Form";
            this.Text = "Custom Discord-RPC";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_rem;
    }
}

