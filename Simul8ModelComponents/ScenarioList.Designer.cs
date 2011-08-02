/*
 * Created by SharpDevelop.
 * User: tm300
 * Date: 15/07/2011
 * Time: 09:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Simul8ModelComponents
{
	partial class ScenarioList
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
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ScenarioName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.RunAll = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.scenarioDetailsView1 = new Simul8ModelComponents.ScenarioDetailsView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ScenarioName});
			this.dataGridView1.DataSource = this.bindingSource1;
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new System.Drawing.Size(240, 282);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// ScenarioName
			// 
			this.ScenarioName.DataPropertyName = "Name";
			this.ScenarioName.HeaderText = "Scenario";
			this.ScenarioName.Name = "ScenarioName";
			this.ScenarioName.ReadOnly = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(3, 291);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(78, 24);
			this.button1.TabIndex = 1;
			this.button1.Text = "Add Folder";
			this.toolTip1.SetToolTip(this.button1, "Create a scenario from a folder containing models");
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// RunAll
			// 
			this.RunAll.Location = new System.Drawing.Point(3, 318);
			this.RunAll.Name = "RunAll";
			this.RunAll.Size = new System.Drawing.Size(78, 24);
			this.RunAll.TabIndex = 3;
			this.RunAll.Text = "Run All";
			this.toolTip1.SetToolTip(this.RunAll, "Run all scenarios");
			this.RunAll.UseVisualStyleBackColor = true;
			this.RunAll.Click += new System.EventHandler(this.RunAllClick);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(87, 318);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(86, 24);
			this.button3.TabIndex = 4;
			this.button3.Text = "Run Selected";
			this.toolTip1.SetToolTip(this.button3, "Run selected scenario");
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(87, 291);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(86, 24);
			this.button4.TabIndex = 5;
			this.button4.Text = "Create";
			this.toolTip1.SetToolTip(this.button4, "Create an empty scenario");
			this.button4.UseVisualStyleBackColor = true;
			// 
			// scenarioDetailsView1
			// 
			this.scenarioDetailsView1.Location = new System.Drawing.Point(3, 348);
			this.scenarioDetailsView1.Name = "scenarioDetailsView1";
			this.scenarioDetailsView1.SelectedScenario = null;
			this.scenarioDetailsView1.Size = new System.Drawing.Size(241, 120);
			this.scenarioDetailsView1.TabIndex = 6;
			// 
			// ScenarioList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.scenarioDetailsView1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.RunAll);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "ScenarioList";
			this.Size = new System.Drawing.Size(246, 553);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button RunAll;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private Simul8ModelComponents.ScenarioDetailsView scenarioDetailsView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ScenarioName;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}
