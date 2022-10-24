namespace EAM_AccountsDebugger
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tbPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnChangePath = new System.Windows.Forms.Button();
            this.rtbOut = new System.Windows.Forms.RichTextBox();
            this.pRtb = new System.Windows.Forms.Panel();
            this.pRtb.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(13, 27);
            this.tbPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(394, 23);
            this.tbPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select your EAM.accounts file";
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Image = global::EAM_AccountsDebugger.Properties.Resources.icons8_forward_18px;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(13, 106);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(113, 27);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start process";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnChangePath
            // 
            this.btnChangePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePath.Image = global::EAM_AccountsDebugger.Properties.Resources.ic_folder_open_black_24dp;
            this.btnChangePath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePath.Location = new System.Drawing.Point(13, 56);
            this.btnChangePath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChangePath.Name = "btnChangePath";
            this.btnChangePath.Size = new System.Drawing.Size(113, 27);
            this.btnChangePath.TabIndex = 1;
            this.btnChangePath.Text = "Change Path";
            this.btnChangePath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangePath.UseVisualStyleBackColor = true;
            this.btnChangePath.Click += new System.EventHandler(this.btnChangePath_Click);
            // 
            // rtbOut
            // 
            this.rtbOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbOut.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOut.Location = new System.Drawing.Point(0, 0);
            this.rtbOut.Name = "rtbOut";
            this.rtbOut.ReadOnly = true;
            this.rtbOut.Size = new System.Drawing.Size(392, 351);
            this.rtbOut.TabIndex = 3;
            this.rtbOut.Text = "";
            // 
            // pRtb
            // 
            this.pRtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pRtb.Controls.Add(this.rtbOut);
            this.pRtb.Location = new System.Drawing.Point(13, 139);
            this.pRtb.Name = "pRtb";
            this.pRtb.Size = new System.Drawing.Size(394, 353);
            this.pRtb.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 504);
            this.Controls.Add(this.pRtb);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btnChangePath);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EAM Accounts Debugger by Maik8";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmMain_Paint);
            this.pRtb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangePath;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox rtbOut;
        private System.Windows.Forms.Panel pRtb;
    }
}

