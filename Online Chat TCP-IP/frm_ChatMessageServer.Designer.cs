namespace Online_Chat_TCP_IP
{
    partial class frm_ChatMessageServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ChatMessageServer));
            this.btnClientDisconnect = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSendMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnPeopleConnected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientDisconnect
            // 
            this.btnClientDisconnect.BackColor = System.Drawing.Color.Red;
            this.btnClientDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientDisconnect.Font = new System.Drawing.Font("Halant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientDisconnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClientDisconnect.Location = new System.Drawing.Point(366, 49);
            this.btnClientDisconnect.Name = "btnClientDisconnect";
            this.btnClientDisconnect.Size = new System.Drawing.Size(47, 39);
            this.btnClientDisconnect.TabIndex = 12;
            this.btnClientDisconnect.Text = "X";
            this.btnClientDisconnect.UseVisualStyleBackColor = false;
            this.btnClientDisconnect.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Halant", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(26, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(269, 89);
            this.lblTitle.TabIndex = 10;
            // 
            // txtSendMessage
            // 
            this.txtSendMessage.Font = new System.Drawing.Font("Halant", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSendMessage.Location = new System.Drawing.Point(33, 683);
            this.txtSendMessage.Multiline = true;
            this.txtSendMessage.Name = "txtSendMessage";
            this.txtSendMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSendMessage.Size = new System.Drawing.Size(281, 52);
            this.txtSendMessage.TabIndex = 9;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Black;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Halant", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnSend.Location = new System.Drawing.Point(320, 683);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(93, 52);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Halant", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(33, 118);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(380, 540);
            this.txtMessage.TabIndex = 7;
            // 
            // btnPeopleConnected
            // 
            this.btnPeopleConnected.BackColor = System.Drawing.Color.Transparent;
            this.btnPeopleConnected.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPeopleConnected.BackgroundImage")));
            this.btnPeopleConnected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPeopleConnected.FlatAppearance.BorderSize = 0;
            this.btnPeopleConnected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeopleConnected.Font = new System.Drawing.Font("Halant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeopleConnected.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPeopleConnected.Location = new System.Drawing.Point(301, 49);
            this.btnPeopleConnected.Name = "btnPeopleConnected";
            this.btnPeopleConnected.Size = new System.Drawing.Size(47, 39);
            this.btnPeopleConnected.TabIndex = 13;
            this.btnPeopleConnected.UseVisualStyleBackColor = false;
            this.btnPeopleConnected.Click += new System.EventHandler(this.btnPeopleConnected_Click);
            // 
            // frm_ChatMessageServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(438, 759);
            this.Controls.Add(this.btnPeopleConnected);
            this.Controls.Add(this.btnClientDisconnect);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtSendMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ChatMessageServer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chat Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientDisconnect;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSendMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnPeopleConnected;
    }
}