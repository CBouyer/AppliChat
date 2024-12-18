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
            groupBox1 = new GroupBox();
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericPort).BeginInit();
            statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEnvoie).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ipAddressControl1);
            groupBox1.Controls.Add(labelUtilisateur);
            groupBox1.Controls.Add(textAlias);
            groupBox1.Controls.Add(buttonStop);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numericPort);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonStart);
            groupBox1.Location = new Point(14, 14);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(536, 94);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configuration";
            // 
            // ipAddressControl1
            // 
            ipAddressControl1.BackColor = SystemColors.Control;
            ipAddressControl1.IPAddress = "0.0.0.0";
            ipAddressControl1.IsSubnetMask = false;
            ipAddressControl1.Location = new Point(61, 23);
            ipAddressControl1.Margin = new Padding(4, 3, 4, 3);
            ipAddressControl1.Name = "ipAddressControl1";
            ipAddressControl1.Size = new Size(177, 23);
            ipAddressControl1.TabIndex = 6;
            // 
            // labelUtilisateur
            // 
            labelUtilisateur.AutoSize = true;
            labelUtilisateur.Location = new Point(218, 59);
            labelUtilisateur.Margin = new Padding(4, 0, 4, 0);
            labelUtilisateur.Name = "labelUtilisateur";
            labelUtilisateur.Size = new Size(66, 15);
            labelUtilisateur.TabIndex = 5;
            labelUtilisateur.Text = "Utilisateur :";
            // 
            // textAlias
            // 
            textAlias.Location = new Point(287, 55);
            textAlias.Margin = new Padding(4);
            textAlias.Name = "textAlias";
            textAlias.Size = new Size(116, 23);
            textAlias.TabIndex = 4;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(414, 24);
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
            label2.Location = new Point(7, 28);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 2;
            label2.Text = "Serveur";
            // 
            // numericPort
            // 
            numericPort.Location = new Point(312, 25);
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
            label1.Location = new Point(265, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "Port : ";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(414, 24);
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
            richMessages.Location = new Point(14, 114);
            richMessages.Margin = new Padding(4);
            richMessages.Name = "richMessages";
            richMessages.ReadOnly = true;
            richMessages.Size = new Size(536, 332);
            richMessages.TabIndex = 1;
            richMessages.Text = "";
            // 
            // textMessage
            // 
            textMessage.Enabled = false;
            textMessage.Location = new Point(14, 454);
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
            statusBar.Size = new Size(566, 22);
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
            pictureBoxEnvoie.Location = new Point(484, 482);
            pictureBoxEnvoie.Name = "pictureBoxEnvoie";
            pictureBoxEnvoie.Size = new Size(65, 48);
            pictureBoxEnvoie.TabIndex = 6;
            pictureBoxEnvoie.TabStop = false;
            pictureBoxEnvoie.Click += pictureBoxEnvoie_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(564, 596);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(pictureBoxEnvoie);
            Controls.Add(statusBar);
            Controls.Add(textMessage);
            Controls.Add(richMessages);
            Controls.Add(groupBox1);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "MainWindow";
            Text = "VirtueChat";
            FormClosing += MainWindow_FormClosing;
            Load += MainWindow_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericPort).EndInit();
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEnvoie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}

