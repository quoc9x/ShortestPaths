namespace ShortestPaths
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbOutput = new System.Windows.Forms.GroupBox();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.mniOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniReset = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grbSelectEngine = new System.Windows.Forms.GroupBox();
            this.txtNumberYen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoYen = new System.Windows.Forms.RadioButton();
            this.rdoDijkstra = new System.Windows.Forms.RadioButton();
            this.rdoFordBellman = new System.Windows.Forms.RadioButton();
            this.rdoBFS = new System.Windows.Forms.RadioButton();
            this.grbInput.SuspendLayout();
            this.grbOutput.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grbSelectEngine.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.lbTime);
            this.grbInput.Controls.Add(this.btnExecute);
            this.grbInput.Controls.Add(this.txtDest);
            this.grbInput.Controls.Add(this.txtSource);
            this.grbInput.Controls.Add(this.label2);
            this.grbInput.Controls.Add(this.label1);
            this.grbInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbInput.Location = new System.Drawing.Point(0, 185);
            this.grbInput.Name = "grbInput";
            this.grbInput.Size = new System.Drawing.Size(634, 77);
            this.grbInput.TabIndex = 1;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Nhập vào 2 điểm cần tìm đường đi";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(16, 49);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(233, 16);
            this.lbTime.TabIndex = 4;
            this.lbTime.Text = "Thời gian thực hiện chương trình: ";
            // 
            // btnExecute
            // 
            this.btnExecute.Enabled = false;
            this.btnExecute.Location = new System.Drawing.Point(368, 17);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "Tính";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // txtDest
            // 
            this.txtDest.Enabled = false;
            this.txtDest.Location = new System.Drawing.Point(246, 19);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(100, 20);
            this.txtDest.TabIndex = 2;
            // 
            // txtSource
            // 
            this.txtSource.Enabled = false;
            this.txtSource.Location = new System.Drawing.Point(71, 19);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(100, 20);
            this.txtSource.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Điểm đến:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điểm đi: ";
            // 
            // grbOutput
            // 
            this.grbOutput.Controls.Add(this.rtbResult);
            this.grbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbOutput.Location = new System.Drawing.Point(0, 262);
            this.grbOutput.Name = "grbOutput";
            this.grbOutput.Size = new System.Drawing.Size(634, 249);
            this.grbOutput.TabIndex = 1;
            this.grbOutput.TabStop = false;
            this.grbOutput.Text = "Đường đi ngắn nhất";
            // 
            // rtbResult
            // 
            this.rtbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbResult.Location = new System.Drawing.Point(3, 16);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.ReadOnly = true;
            this.rtbResult.Size = new System.Drawing.Size(628, 230);
            this.rtbResult.TabIndex = 0;
            this.rtbResult.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMain});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuMain
            // 
            this.mnuMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniOpenFile,
            this.mniReset,
            this.mniExit});
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(50, 20);
            this.mnuMain.Text = "Menu";
            // 
            // mniOpenFile
            // 
            this.mniOpenFile.Name = "mniOpenFile";
            this.mniOpenFile.Size = new System.Drawing.Size(124, 22);
            this.mniOpenFile.Text = "Open File";
            this.mniOpenFile.Click += new System.EventHandler(this.mniOpenFile_Click);
            // 
            // mniReset
            // 
            this.mniReset.Name = "mniReset";
            this.mniReset.Size = new System.Drawing.Size(124, 22);
            this.mniReset.Text = "Reset";
            this.mniReset.Click += new System.EventHandler(this.mniReset_Click);
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(124, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // grbSelectEngine
            // 
            this.grbSelectEngine.Controls.Add(this.txtNumberYen);
            this.grbSelectEngine.Controls.Add(this.label3);
            this.grbSelectEngine.Controls.Add(this.rdoYen);
            this.grbSelectEngine.Controls.Add(this.rdoDijkstra);
            this.grbSelectEngine.Controls.Add(this.rdoFordBellman);
            this.grbSelectEngine.Controls.Add(this.rdoBFS);
            this.grbSelectEngine.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbSelectEngine.Location = new System.Drawing.Point(0, 24);
            this.grbSelectEngine.Name = "grbSelectEngine";
            this.grbSelectEngine.Size = new System.Drawing.Size(634, 161);
            this.grbSelectEngine.TabIndex = 0;
            this.grbSelectEngine.TabStop = false;
            this.grbSelectEngine.Text = "Chọn cách tính";
            // 
            // txtNumberYen
            // 
            this.txtNumberYen.Enabled = false;
            this.txtNumberYen.Location = new System.Drawing.Point(159, 125);
            this.txtNumberYen.Name = "txtNumberYen";
            this.txtNumberYen.Size = new System.Drawing.Size(75, 20);
            this.txtNumberYen.TabIndex = 2;
            this.txtNumberYen.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số đường đi ngắn nhất\r\nmuốn tìm:";
            // 
            // rdoYen
            // 
            this.rdoYen.AutoSize = true;
            this.rdoYen.Location = new System.Drawing.Point(19, 97);
            this.rdoYen.Name = "rdoYen";
            this.rdoYen.Size = new System.Drawing.Size(229, 17);
            this.rdoYen.TabIndex = 0;
            this.rdoYen.Text = "Tìm k đường đi ngắn nhất - Yen\'s Algorithm";
            this.rdoYen.UseVisualStyleBackColor = true;
            this.rdoYen.CheckedChanged += new System.EventHandler(this.rdoYen_CheckedChanged);
            // 
            // rdoDijkstra
            // 
            this.rdoDijkstra.AutoSize = true;
            this.rdoDijkstra.Checked = true;
            this.rdoDijkstra.Location = new System.Drawing.Point(19, 71);
            this.rdoDijkstra.Name = "rdoDijkstra";
            this.rdoDijkstra.Size = new System.Drawing.Size(183, 17);
            this.rdoDijkstra.TabIndex = 0;
            this.rdoDijkstra.TabStop = true;
            this.rdoDijkstra.Text = "Tìm đường đi ngắn nhất - Dijkstra";
            this.rdoDijkstra.UseVisualStyleBackColor = true;
            // 
            // rdoFordBellman
            // 
            this.rdoFordBellman.AutoSize = true;
            this.rdoFordBellman.Location = new System.Drawing.Point(19, 44);
            this.rdoFordBellman.Name = "rdoFordBellman";
            this.rdoFordBellman.Size = new System.Drawing.Size(209, 17);
            this.rdoFordBellman.TabIndex = 0;
            this.rdoFordBellman.Text = "Tìm đường đi ngắn nhất - Ford-Bellman";
            this.rdoFordBellman.UseVisualStyleBackColor = true;
            // 
            // rdoBFS
            // 
            this.rdoBFS.AutoSize = true;
            this.rdoBFS.Location = new System.Drawing.Point(19, 19);
            this.rdoBFS.Name = "rdoBFS";
            this.rdoBFS.Size = new System.Drawing.Size(168, 17);
            this.rdoBFS.TabIndex = 0;
            this.rdoBFS.Text = "Tìm đường đi ngắn nhất - BFS";
            this.rdoBFS.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 511);
            this.Controls.Add(this.grbOutput);
            this.Controls.Add(this.grbInput);
            this.Controls.Add(this.grbSelectEngine);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đường đi ngắn nhất";
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            this.grbOutput.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbSelectEngine.ResumeLayout(false);
            this.grbSelectEngine.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.GroupBox grbOutput;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mniOpenFile;
        private System.Windows.Forms.ToolStripMenuItem mniReset;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.GroupBox grbSelectEngine;
        private System.Windows.Forms.TextBox txtNumberYen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoYen;
        private System.Windows.Forms.RadioButton rdoDijkstra;
        private System.Windows.Forms.RadioButton rdoFordBellman;
        private System.Windows.Forms.RadioButton rdoBFS;
    }
}

