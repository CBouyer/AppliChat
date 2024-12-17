namespace ChatServer
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
            groupBox1 = new GroupBox();
            buttonStop = new Button();
            numericPort = new NumericUpDown();
            label1 = new Label();
            buttonStart = new Button();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericPort).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonStop);
            groupBox1.Controls.Add(numericPort);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonStart);
            groupBox1.Location = new Point(14, 14);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(359, 67);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configuration";
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(255, 22);
            buttonStop.Margin = new Padding(4, 3, 4, 3);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(88, 27);
            buttonStop.TabIndex = 4;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Visible = false;
            buttonStop.Click += buttonStop_Click;
            // 
            // numericPort
            // 
            numericPort.Location = new Point(55, 25);
            numericPort.Margin = new Padding(4, 3, 4, 3);
            numericPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numericPort.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericPort.Name = "numericPort";
            numericPort.Size = new Size(91, 23);
            numericPort.TabIndex = 3;
            numericPort.TextAlign = HorizontalAlignment.Right;
            numericPort.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "Port : ";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(255, 22);
            buttonStart.Margin = new Padding(4, 3, 4, 3);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(88, 27);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(14, 88);
            listBox1.Margin = new Padding(4, 3, 4, 3);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(359, 124);
            listBox1.TabIndex = 1;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 223);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "MainWindow";
            Text = "VirtueServ";
            FormClosing += MainWindow_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericPort).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericPort;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.ListBox listBox1;
    }
}

