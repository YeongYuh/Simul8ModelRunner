/*
 * Created by SharpDevelop.
 * User: tm300
 * Date: 15/07/2011
 * Time: 09:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Simul8ModelComponents
{
	partial class ScenarioDetailsView
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblOutPath = new System.Windows.Forms.Label();
			this.btSetOutputPath = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.label2 = new System.Windows.Forms.Label();
			this.lblInPath = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblPrefix = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtName
			// 
			this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtName.Location = new System.Drawing.Point(3, 6);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(228, 20);
			this.txtName.TabIndex = 0;
			this.txtName.TextChanged += new System.EventHandler(this.TxtNameTextChanged);
			// 
			// lblOutPath
			// 
			this.lblOutPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lblOutPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblOutPath.Location = new System.Drawing.Point(82, 53);
			this.lblOutPath.Name = "lblOutPath";
			this.lblOutPath.Size = new System.Drawing.Size(118, 23);
			this.lblOutPath.TabIndex = 1;
			// 
			// btSetOutputPath
			// 
			this.btSetOutputPath.Location = new System.Drawing.Point(206, 53);
			this.btSetOutputPath.Name = "btSetOutputPath";
			this.btSetOutputPath.Size = new System.Drawing.Size(25, 23);
			this.btSetOutputPath.TabIndex = 2;
			this.btSetOutputPath.Text = "...";
			this.btSetOutputPath.UseVisualStyleBackColor = true;
			this.btSetOutputPath.Click += new System.EventHandler(this.BtSetOutputPathClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 18);
			this.label1.TabIndex = 3;
			this.label1.Text = "Output Path:";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(100, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(3, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 18);
			this.label2.TabIndex = 4;
			this.label2.Text = "Input Path:";
			// 
			// lblInPath
			// 
			this.lblInPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lblInPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblInPath.Location = new System.Drawing.Point(82, 29);
			this.lblInPath.Name = "lblInPath";
			this.lblInPath.Size = new System.Drawing.Size(149, 21);
			this.lblInPath.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(3, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 18);
			this.label3.TabIndex = 6;
			this.label3.Text = "File Prefix: ";
			// 
			// lblPrefix
			// 
			this.lblPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lblPrefix.Location = new System.Drawing.Point(82, 82);
			this.lblPrefix.Name = "lblPrefix";
			this.lblPrefix.Size = new System.Drawing.Size(118, 20);
			this.lblPrefix.TabIndex = 7;
			this.lblPrefix.TextChanged += new System.EventHandler(this.LblPrefixTextChanged);
			// 
			// ScenarioDetailsView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblPrefix);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblInPath);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btSetOutputPath);
			this.Controls.Add(this.lblOutPath);
			this.Controls.Add(this.txtName);
			this.Name = "ScenarioDetailsView";
			this.Size = new System.Drawing.Size(241, 120);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox lblPrefix;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblInPath;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.Label lblOutPath;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btSetOutputPath;
		private System.Windows.Forms.TextBox txtName;
	}
}
