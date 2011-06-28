/*
 * Created by SharpDevelop.
 * User: tm300
 * Date: 23/06/2011
 * Time: 10:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Simul8ModelComponents
{
	partial class ModelSummaryView
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
			this.pictureType = new System.Windows.Forms.PictureBox();
			this.FileName = new System.Windows.Forms.Label();
			this.FullPath = new System.Windows.Forms.Label();
			this.VariableCount = new System.Windows.Forms.Label();
			this.Replications = new System.Windows.Forms.Label();
			this.RunLength = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureType)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureType
			// 
			this.pictureType.BackgroundImage = global::Simul8ModelComponents.Properties.Resource1.s8_icon;
			this.pictureType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureType.InitialImage = null;
			this.pictureType.Location = new System.Drawing.Point(3, 3);
			this.pictureType.Name = "pictureType";
			this.pictureType.Size = new System.Drawing.Size(110, 89);
			this.pictureType.TabIndex = 0;
			this.pictureType.TabStop = false;
			// 
			// FileName
			// 
			this.FileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FileName.Location = new System.Drawing.Point(119, 3);
			this.FileName.Name = "FileName";
			this.FileName.Size = new System.Drawing.Size(496, 21);
			this.FileName.TabIndex = 1;
			this.FileName.Text = "Model Name";
			// 
			// FullPath
			// 
			this.FullPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.FullPath.Location = new System.Drawing.Point(119, 24);
			this.FullPath.Name = "FullPath";
			this.FullPath.Size = new System.Drawing.Size(516, 21);
			this.FullPath.TabIndex = 2;
			// 
			// VariableCount
			// 
			this.VariableCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.VariableCount.Location = new System.Drawing.Point(119, 45);
			this.VariableCount.Name = "VariableCount";
			this.VariableCount.Size = new System.Drawing.Size(496, 21);
			this.VariableCount.TabIndex = 3;
			this.VariableCount.Text = "Variables";
			// 
			// Replications
			// 
			this.Replications.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.Replications.Location = new System.Drawing.Point(119, 71);
			this.Replications.Name = "Replications";
			this.Replications.Size = new System.Drawing.Size(96, 21);
			this.Replications.TabIndex = 4;
			this.Replications.Text = "Replications";
			// 
			// RunLength
			// 
			this.RunLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.RunLength.Location = new System.Drawing.Point(233, 71);
			this.RunLength.Name = "RunLength";
			this.RunLength.Size = new System.Drawing.Size(195, 21);
			this.RunLength.TabIndex = 5;
			this.RunLength.Text = "Run length: ";
			// 
			// ModelSummaryView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.RunLength);
			this.Controls.Add(this.Replications);
			this.Controls.Add(this.VariableCount);
			this.Controls.Add(this.FullPath);
			this.Controls.Add(this.FileName);
			this.Controls.Add(this.pictureType);
			this.Name = "ModelSummaryView";
			this.Size = new System.Drawing.Size(638, 96);
			((System.ComponentModel.ISupportInitialize)(this.pictureType)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label RunLength;
		private System.Windows.Forms.Label Replications;
		private System.Windows.Forms.Label VariableCount;
		private System.Windows.Forms.Label FullPath;
		private System.Windows.Forms.Label FileName;
		private System.Windows.Forms.PictureBox pictureType;
	}
}
