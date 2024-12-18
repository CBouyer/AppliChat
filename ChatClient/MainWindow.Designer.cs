namespace ChatClient
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            ipAddressControl1 = new OutilsChat.IPAddressControl();
            labelUtilisateur = new Label();
            textAlias = new TextBox();
            buttonStop = new Button();
            label2 = new Label();
            numericPort = new NumericUpDown();
            label1 = new Label();
            buttonStart = new Button();
            richMessages = new RichTextBox();
            textMessage = new TextBox();
            statusBar = new StatusStrip();
            statusBarInfo = new ToolStripStatusLabel();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            pictureBoxEnvoie = new PictureBox();
            pictureBoxSuppr = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericPort).BeginInit();
            statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEnvoie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSuppr).BeginInit();
            SuspendLayout();
            // 
            // ipAddressControl1
            // 
            ipAddressControl1.BackColor = SystemColors.Control;
            ipAddressControl1.IPAddress = "0.0.0.0";
            ipAddressControl1.IsSubnetMask = false;
            ipAddressControl1.Location = new Point(894, 33);
            ipAddressControl1.Margin = new Padding(4, 3, 4, 3);
            ipAddressControl1.Name = "ipAddressControl1";
            ipAddressControl1.Size = new Size(195, 38);
            ipAddressControl1.TabIndex = 6;
            // 
            // labelUtilisateur
            // 
            labelUtilisateur.AutoSize = true;
            labelUtilisateur.Location = new Point(0, 116);
            labelUtilisateur.Margin = new Padding(4, 0, 4, 0);
            labelUtilisateur.Name = "labelUtilisateur";
            labelUtilisateur.Size = new Size(66, 15);
            labelUtilisateur.TabIndex = 5;
            labelUtilisateur.Text = "Utilisateur :";
            // 
            // textAlias
            // 
            textAlias.Location = new Point(69, 112);
            textAlias.Margin = new Padding(4);
            textAlias.Name = "textAlias";
            textAlias.Size = new Size(116, 23);
            textAlias.TabIndex = 4;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(1001, 140);
            buttonStop.Margin = new Padding(4);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(88, 26);
            buttonStop.TabIndex = 3;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Visible = false;
            buttonStop.Click += buttonStop_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(840, 47);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 2;
            label2.Text = "Serveur";
            // 
            // numericPort
            // 
            numericPort.Location = new Point(998, 93);
            numericPort.Margin = new Padding(4);
            numericPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numericPort.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericPort.Name = "numericPort";
            numericPort.Size = new Size(91, 23);
            numericPort.TabIndex = 1;
            numericPort.TextAlign = HorizontalAlignment.Right;
            numericPort.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(951, 96);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "Port : ";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(1001, 140);
            buttonStart.Margin = new Padding(4);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(88, 26);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // richMessages
            // 
            richMessages.BackColor = SystemColors.ButtonFace;
            richMessages.Location = new Point(237, 116);
            richMessages.Margin = new Padding(4);
            richMessages.Name = "richMessages";
            richMessages.ReadOnly = true;
            richMessages.Size = new Size(649, 332);
            richMessages.TabIndex = 1;
            richMessages.Text = "";
            // 
            // textMessage
            // 
            textMessage.Enabled = false;
            textMessage.Location = new Point(330, 466);
            textMessage.Margin = new Padding(4);
            textMessage.Multiline = true;
            textMessage.Name = "textMessage";
            textMessage.ScrollBars = ScrollBars.Both;
            textMessage.Size = new Size(463, 104);
            textMessage.TabIndex = 2;
            // 
            // statusBar
            // 
            statusBar.ImageScalingSize = new Size(20, 20);
            statusBar.Items.AddRange(new ToolStripItem[] { statusBarInfo });
            statusBar.Location = new Point(0, 574);
            statusBar.Name = "statusBar";
            statusBar.Padding = new Padding(1, 0, 17, 0);
            statusBar.Size = new Size(1102, 22);
            statusBar.TabIndex = 5;
            statusBar.Text = "statusStrip1";
            // 
            // statusBarInfo
            // 
            statusBarInfo.Name = "statusBarInfo";
            statusBarInfo.Size = new Size(0, 17);
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(484, 556);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(75, 23);
            axWindowsMediaPlayer1.TabIndex = 6;
            axWindowsMediaPlayer1.Visible = false;
            // 
            // pictureBoxEnvoie
            // 
            pictureBoxEnvoie.Image = Properties.Resources.logo_send__1_;
            pictureBoxEnvoie.Location = new Point(821, 497);
            pictureBoxEnvoie.Name = "pictureBoxEnvoie";
            pictureBoxEnvoie.Size = new Size(65, 48);
            pictureBoxEnvoie.TabIndex = 6;
            pictureBoxEnvoie.TabStop = false;
            pictureBoxEnvoie.Click += pictureBoxEnvoie_Click;
            pictureBoxEnvoie.MouseEnter += pictureBoxEnvoie_MouseEnter;
            pictureBoxEnvoie.MouseLeave += pictureBoxEnvoie_MouseLeave;
            // 
            // pictureBoxSuppr
            // 
            pictureBoxSuppr.Image = Properties.Resources.btn_suppr;
            pictureBoxSuppr.Location = new Point(298, 476);
            pictureBoxSuppr.Name = "pictureBoxSuppr";
            pictureBoxSuppr.Size = new Size(25, 27);
            pictureBoxSuppr.TabIndex = 7;
            pictureBoxSuppr.TabStop = false;
            pictureBoxSuppr.Click += pictureBoxSuppr_Click;
            pictureBoxSuppr.MouseEnter += pictureBoxSuppr_MouseEnter;
            pictureBoxSuppr.MouseLeave += pictureBoxSuppr_MouseLeave;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1102, 596);
            Controls.Add(pictureBoxSuppr);
            Controls.Add(buttonStart);
            Controls.Add(buttonStop);
            Controls.Add(ipAddressControl1);
            Controls.Add(numericPort);
            Controls.Add(label1);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(labelUtilisateur);
            Controls.Add(label2);
            Controls.Add(pictureBoxEnvoie);
            Controls.Add(textAlias);
            Controls.Add(statusBar);
            Controls.Add(textMessage);
            Controls.Add(richMessages);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "MainWindow";
            Text = "VirtueChat";
            FormClosing += MainWindow_FormClosing;
            Load += MainWindow_Load;
            ((System.ComponentModel.ISupportInitialize)numericPort).EndInit();
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEnvoie).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSuppr).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label2;
        
        private System.Windows.Forms.RichTextBox richMessages;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusBarInfo;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelUtilisateur;
        private System.Windows.Forms.TextBox textAlias;
        private OutilsChat.IPAddressControl ipAddressControl1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private PictureBox pictureBoxEnvoie;
        private PictureBox pictureBoxSuppr;
    }
}

