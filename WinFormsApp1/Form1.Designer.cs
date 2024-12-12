namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonConnect = new Button();
            buttonStart = new Button();
            buttonFlipHor = new Button();
            buttonFlipVer = new Button();
            imageBoxLife = new Emgu.CV.UI.ImageBox();
            groupBox1 = new GroupBox();
            statusStripInfo = new StatusStrip();
            toolStripStatusDate = new ToolStripStatusLabel();
            toolStripStatusTime = new ToolStripStatusLabel();
            toolStripStatusCamera = new ToolStripStatusLabel();
            camRec = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            textTestPanel = new TextBox();
            ((System.ComponentModel.ISupportInitialize)imageBoxLife).BeginInit();
            statusStripInfo.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(7, 370);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(115, 136);
            buttonConnect.TabIndex = 0;
            buttonConnect.Text = "Connect";
            buttonConnect.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(284, 376);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(94, 130);
            buttonStart.TabIndex = 3;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            // 
            // buttonFlipHor
            // 
            buttonFlipHor.Location = new Point(628, 326);
            buttonFlipHor.Name = "buttonFlipHor";
            buttonFlipHor.Size = new Size(155, 87);
            buttonFlipHor.TabIndex = 5;
            buttonFlipHor.Text = "Horizontal Flip";
            buttonFlipHor.UseVisualStyleBackColor = true;
            // 
            // buttonFlipVer
            // 
            buttonFlipVer.Location = new Point(628, 419);
            buttonFlipVer.Name = "buttonFlipVer";
            buttonFlipVer.Size = new Size(155, 87);
            buttonFlipVer.TabIndex = 6;
            buttonFlipVer.Text = "Vertical Flip";
            buttonFlipVer.UseVisualStyleBackColor = true;
            // 
            // imageBoxLife
            // 
            imageBoxLife.InitialImage = (Image)resources.GetObject("imageBoxLife.InitialImage");
            imageBoxLife.Location = new Point(128, 91);
            imageBoxLife.Name = "imageBoxLife";
            imageBoxLife.Size = new Size(483, 234);
            imageBoxLife.TabIndex = 2;
            imageBoxLife.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(128, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(483, 259);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Camera";
            // 
            // statusStripInfo
            // 
            statusStripInfo.ImageScalingSize = new Size(20, 20);
            statusStripInfo.Items.AddRange(new ToolStripItem[] { toolStripStatusDate, toolStripStatusTime, toolStripStatusCamera, camRec });
            statusStripInfo.Location = new Point(0, 543);
            statusStripInfo.Name = "statusStripInfo";
            statusStripInfo.Size = new Size(795, 26);
            statusStripInfo.TabIndex = 8;
            statusStripInfo.Text = "statusStrip1";
            // 
            // toolStripStatusDate
            // 
            toolStripStatusDate.Name = "toolStripStatusDate";
            toolStripStatusDate.Size = new Size(41, 20);
            toolStripStatusDate.Text = "Date";
            // 
            // toolStripStatusTime
            // 
            toolStripStatusTime.Name = "toolStripStatusTime";
            toolStripStatusTime.Size = new Size(42, 20);
            toolStripStatusTime.Text = "Time";
            // 
            // toolStripStatusCamera
            // 
            toolStripStatusCamera.BackColor = SystemColors.Info;
            toolStripStatusCamera.Name = "toolStripStatusCamera";
            toolStripStatusCamera.Size = new Size(114, 20);
            toolStripStatusCamera.Text = "Camera running";
            // 
            // camRec
            // 
            camRec.BackColor = SystemColors.Info;
            camRec.Name = "camRec";
            camRec.Size = new Size(111, 20);
            camRec.Text = "Being recorded";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(795, 28);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            // 
            // textTestPanel
            // 
            textTestPanel.Location = new Point(628, 66);
            textTestPanel.Name = "textTestPanel";
            textTestPanel.Size = new Size(125, 27);
            textTestPanel.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 569);
            Controls.Add(textTestPanel);
            Controls.Add(statusStripInfo);
            Controls.Add(menuStrip1);
            Controls.Add(imageBoxLife);
            Controls.Add(buttonFlipVer);
            Controls.Add(buttonFlipHor);
            Controls.Add(buttonStart);
            Controls.Add(buttonConnect);
            Controls.Add(groupBox1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)imageBoxLife).EndInit();
            statusStripInfo.ResumeLayout(false);
            statusStripInfo.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonConnect;
        private Button buttonStart;
        private Button buttonFlipHor;
        private Button buttonFlipVer;
        private Emgu.CV.UI.ImageBox imageBoxLife;
        private GroupBox groupBox1;
        private StatusStrip statusStripInfo;
        private ToolStripStatusLabel toolStripStatusCamera;
        private ToolStripStatusLabel toolStripStatusTime;
        private ToolStripStatusLabel toolStripStatusDate;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TextBox textTestPanel;
        private ToolStripStatusLabel camRec;
    }
}
