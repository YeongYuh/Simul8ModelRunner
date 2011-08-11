/*
 * Created by SharpDevelop.
 * User: tm300
 * Date: 04/08/2011
 * Time: 13:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Simul8ModelViewer
{
	partial class MultipleUpdateDialog
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
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
			this.variableDetailsView1 = new Simul8ModelComponents.VariableDetailsView();
			this.label1 = new System.Windows.Forms.Label();
			this.UpdateAll = new System.Windows.Forms.Button();
			this.variableGrid1 = new Simul8ModelComponents.VariableGrid();
			this.sheetView1 = new Simul8ModelComponents.SheetView();
			this.CloseForm = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// variableDetailsView1
			// 
			this.variableDetailsView1.Location = new System.Drawing.Point(12, 284);
			this.variableDetailsView1.Name = "variableDetailsView1";
			this.variableDetailsView1.SelectedVariable = null;
			this.variableDetailsView1.Size = new System.Drawing.Size(664, 78);
			this.variableDetailsView1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(464, 35);
			this.label1.TabIndex = 1;
			this.label1.Text = "This dialog provides a multiple update mechanism for the selected variable.  All " +
			"models within the scenario that contain the variable will be updated.";
			// 
			// UpdateAll
			// 
			this.UpdateAll.Location = new System.Drawing.Point(594, 12);
			this.UpdateAll.Name = "UpdateAll";
			this.UpdateAll.Size = new System.Drawing.Size(163, 29);
			this.UpdateAll.TabIndex = 2;
			this.UpdateAll.Text = "Update";
			this.UpdateAll.UseVisualStyleBackColor = true;
			this.UpdateAll.Click += new System.EventHandler(this.UpdateAllClick);
			// 
			// variableGrid1
			// 
			this.variableGrid1.LinkedVariableDetailsView = null;
			this.variableGrid1.Location = new System.Drawing.Point(12, 59);
			this.variableGrid1.Name = "variableGrid1";
			this.variableGrid1.Size = new System.Drawing.Size(664, 219);
			this.variableGrid1.TabIndex = 3;
			// 
			// sheetView1
			// 
			this.sheetView1.HasUpdates = false;
			this.sheetView1.Location = new System.Drawing.Point(682, 59);
			this.sheetView1.Name = "sheetView1";
			this.sheetView1.SelectedVariable = null;
			this.sheetView1.Size = new System.Drawing.Size(384, 473);
			this.sheetView1.TabIndex = 4;
			// 
			// CloseForm
			// 
			this.CloseForm.Location = new System.Drawing.Point(763, 12);
			this.CloseForm.Name = "CloseForm";
			this.CloseForm.Size = new System.Drawing.Size(163, 29);
			this.CloseForm.TabIndex = 5;
			this.CloseForm.Text = "Close";
			this.CloseForm.UseVisualStyleBackColor = true;
			// 
			// MultipleUpdateDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1103, 544);
			this.Controls.Add(this.CloseForm);
			this.Controls.Add(this.sheetView1);
			this.Controls.Add(this.variableGrid1);
			this.Controls.Add(this.UpdateAll);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.variableDetailsView1);
			this.Name = "MultipleUpdateDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Update variable in multiple models";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button CloseForm;
		private Simul8ModelComponents.SheetView sheetView1;
		private Simul8ModelComponents.VariableGrid variableGrid1;
		private System.Windows.Forms.Button UpdateAll;
		private System.Windows.Forms.Label label1;
		private Simul8ModelComponents.VariableDetailsView variableDetailsView1;
	}
}
