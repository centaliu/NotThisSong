namespace NotThisSong
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
			this.lblFolder = new System.Windows.Forms.Label();
			this.txtFolder = new System.Windows.Forms.TextBox();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.lblStatus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblFolder
			// 
			this.lblFolder.AutoSize = true;
			this.lblFolder.Location = new System.Drawing.Point(12, 9);
			this.lblFolder.Name = "lblFolder";
			this.lblFolder.Size = new System.Drawing.Size(39, 13);
			this.lblFolder.TabIndex = 0;
			this.lblFolder.Text = "Folder:";
			// 
			// txtFolder
			// 
			this.txtFolder.Location = new System.Drawing.Point(57, 6);
			this.txtFolder.Name = "txtFolder";
			this.txtFolder.Size = new System.Drawing.Size(219, 20);
			this.txtFolder.TabIndex = 1;
			this.txtFolder.Text = "G:\\Training\\mp3\\songs\\";
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(57, 32);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(94, 37);
			this.btnNext.TabIndex = 2;
			this.btnNext.Text = "Next";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(182, 32);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(94, 37);
			this.btnDel.TabIndex = 3;
			this.btnDel.Text = "Delete";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(12, 88);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(37, 13);
			this.lblStatus.TabIndex = 4;
			this.lblStatus.Text = "Status";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(307, 118);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.txtFolder);
			this.Controls.Add(this.lblFolder);
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.Text = "NotThisSong";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblFolder;
		private System.Windows.Forms.TextBox txtFolder;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Label lblStatus;
	}
}

