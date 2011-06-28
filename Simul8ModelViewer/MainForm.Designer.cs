/*
 * Created by SharpDevelop.
 * User: tm300
 * Date: 16/06/2011
 * Time: 10:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Simul8ModelViewer
{
	partial class MainForm
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
			this.btRunModel = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.runAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutSimRunnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.modelRunList1 = new Simul8ModelComponents.ModelRunList();
			this.modelSummaryView1 = new Simul8ModelComponents.ModelSummaryView();
			this.variableGrid1 = new Simul8ModelComponents.VariableGrid();
			this.variableDetailsView1 = new Simul8ModelComponents.VariableDetailsView();
			this.sheetView1 = new Simul8ModelComponents.SheetView();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btRunModel
			// 
			this.btRunModel.Location = new System.Drawing.Point(1155, 616);
			this.btRunModel.Name = "btRunModel";
			this.btRunModel.Size = new System.Drawing.Size(110, 22);
			this.btRunModel.TabIndex = 3;
			this.btRunModel.Text = "Run";
			this.btRunModel.UseVisualStyleBackColor = true;
			this.btRunModel.Click += new System.EventHandler(this.BtRunModelClick);
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1DoWork);
			this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker1ProgressChanged);
			this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1RunWorkerCompleted);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel1,
									this.toolStripProgressBar1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 666);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1277, 22);
			this.statusStrip1.TabIndex = 5;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(38, 17);
			this.toolStripStatusLabel1.Text = "Ready";
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.optionsToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1277, 24);
			this.menuStrip1.TabIndex = 15;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.runAllToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.optionsToolStripMenuItem.Text = "&Options";
			// 
			// runAllToolStripMenuItem
			// 
			this.runAllToolStripMenuItem.Name = "runAllToolStripMenuItem";
			this.runAllToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.runAllToolStripMenuItem.Text = "Run all";
			this.runAllToolStripMenuItem.Click += new System.EventHandler(this.RunAllToolStripMenuItemClick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aboutSimRunnerToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutSimRunnerToolStripMenuItem
			// 
			this.aboutSimRunnerToolStripMenuItem.Name = "aboutSimRunnerToolStripMenuItem";
			this.aboutSimRunnerToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.aboutSimRunnerToolStripMenuItem.Text = "About SimRunner";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.sheetView1);
			this.panel1.Controls.Add(this.variableDetailsView1);
			this.panel1.Controls.Add(this.variableGrid1);
			this.panel1.Controls.Add(this.modelSummaryView1);
			this.panel1.Controls.Add(this.modelRunList1);
			this.panel1.Location = new System.Drawing.Point(0, 27);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1265, 583);
			this.panel1.TabIndex = 17;
			// 
			// modelRunList1
			// 
			this.modelRunList1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.modelRunList1.Location = new System.Drawing.Point(3, 3);
			this.modelRunList1.Name = "modelRunList1";
			this.modelRunList1.Size = new System.Drawing.Size(328, 577);
			this.modelRunList1.TabIndex = 0;
			// 
			// modelSummaryView1
			// 
			this.modelSummaryView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.modelSummaryView1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.modelSummaryView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.modelSummaryView1.Location = new System.Drawing.Point(337, 3);
			this.modelSummaryView1.Name = "modelSummaryView1";
			this.modelSummaryView1.Size = new System.Drawing.Size(919, 96);
			this.modelSummaryView1.TabIndex = 1;
			// 
			// variableGrid1
			// 
			this.variableGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.variableGrid1.LinkedVariableDetailsView = null;
			this.variableGrid1.Location = new System.Drawing.Point(337, 105);
			this.variableGrid1.Name = "variableGrid1";
			this.variableGrid1.Size = new System.Drawing.Size(919, 153);
			this.variableGrid1.TabIndex = 2;
			// 
			// variableDetailsView1
			// 
			this.variableDetailsView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.variableDetailsView1.Location = new System.Drawing.Point(337, 264);
			this.variableDetailsView1.Name = "variableDetailsView1";
			this.variableDetailsView1.SelectedVariable = null;
			this.variableDetailsView1.Size = new System.Drawing.Size(919, 79);
			this.variableDetailsView1.TabIndex = 3;
			// 
			// sheetView1
			// 
			this.sheetView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.sheetView1.HasUpdates = false;
			this.sheetView1.Location = new System.Drawing.Point(337, 349);
			this.sheetView1.Name = "sheetView1";
			this.sheetView1.SelectedVariable = null;
			this.sheetView1.Size = new System.Drawing.Size(919, 218);
			this.sheetView1.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.ClientSize = new System.Drawing.Size(1277, 688);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.btRunModel);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Simulation Model Runner";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripMenuItem aboutSimRunnerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem runAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private Simul8ModelComponents.ModelSummaryView modelSummaryView1;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private Simul8ModelComponents.ModelRunList modelRunList1;
		private System.Windows.Forms.Button btRunModel;
		private Simul8ModelComponents.VariableDetailsView variableDetailsView1;
		private Simul8ModelComponents.SheetView sheetView1;
		private Simul8ModelComponents.VariableGrid variableGrid1;
	}
}
