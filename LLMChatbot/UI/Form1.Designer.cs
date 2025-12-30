namespace LLMChatbot.UI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lstChat = new ListBox();
            panelBottom = new Panel();
            btnSend = new Button();
            txtMessage = new TextBox();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // lstChat
            // 
            lstChat.BackColor = Color.WhiteSmoke;
            lstChat.BorderStyle = BorderStyle.None;
            lstChat.Dock = DockStyle.Fill;
            lstChat.FormattingEnabled = true;
            lstChat.IntegralHeight = false;
            lstChat.Location = new Point(0, 0);
            lstChat.Name = "lstChat";
            lstChat.Size = new Size(1067, 530);
            lstChat.TabIndex = 0;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.LightGray;
            panelBottom.Controls.Add(btnSend);
            panelBottom.Controls.Add(txtMessage);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 530);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(10);
            panelBottom.Size = new Size(1067, 70);
            panelBottom.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSend.BackColor = Color.FromArgb(37, 99, 235);
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(945, 13);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(110, 27);
            btnSend.TabIndex = 1;
            btnSend.Text = "Gönder ➤";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // txtMessage
            // 
            txtMessage.BorderStyle = BorderStyle.FixedSingle;
            txtMessage.Location = new Point(0, 13);
            txtMessage.Name = "txtMessage";
            txtMessage.PlaceholderText = "Mesaj yaz...";
            txtMessage.Size = new Size(945, 27);
            txtMessage.TabIndex = 0;
            txtMessage.Click += btnSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1067, 600);
            Controls.Add(lstChat);
            Controls.Add(panelBottom);
            MinimumSize = new Size(900, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LLM Chatbot";
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox lstChat;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
    }
}

