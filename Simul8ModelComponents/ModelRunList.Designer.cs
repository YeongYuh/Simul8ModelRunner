/*
 * Created by SharpDevelop.
 * User: tm300
 * Date: 20/06/2011
 * Time: 11:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Simul8ModelComponents
{
	partial class ModelRunList
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.btAdd = new System.Windows.Forms.Button();
			this.btRemove = new System.Windows.Forms.Button();
			this.btAddFolder = new System.Windows.Forms.Button();
			this.btMoveUp = new System.Windows.Forms.Button();
			this.byMoveDown = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1});
			this.dataGridView1.DataSource = this.bindingSource1;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.Window;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new System.Drawing.Size(325, 119);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellClick);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "ModelName";
			this.Column1.HeaderText = "Model Name";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 322;
			// 
			// btAdd
			// 
			this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btAdd.Location = new System.Drawing.Point(3, 125);
			this.btAdd.Name = "btAdd";
			this.btAdd.Size = new System.Drawing.Size(75, 23);
			this.btAdd.TabIndex = 1;
			this.btAdd.Text = "Add";
			this.btAdd.UseVisualStyleBackColor = true;
			this.btAdd.Click += new System.EventHandler(this.BtAddClick);
			// 
			// btRemove
			// 
			this.btRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btRemove.Location = new System.Drawing.Point(165, 125);
			this.btRemove.Name = "btRemove";
			this.btRemove.Size = new System.Drawing.Size(75, 23);
			this.btRemove.TabIndex = 2;
			this.btRemove.Text = "Remove";
			this.btRemove.UseVisualStyleBackColor = true;
			this.btRemove.Click += new System.EventHandler(this.BtRemoveClick);
			// 
			// btAddFolder
			// 
			this.btAddFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btAddFolder.Location = new System.Drawing.Point(84, 125);
			this.btAddFolder.Name = "btAddFolder";
			this.btAddFolder.Size = new System.Drawing.Size(75, 23);
			this.btAddFolder.TabIndex = 3;
			this.btAddFolder.Text = "Add Folder";
			this.btAddFolder.UseVisualStyleBackColor = true;
			// 
			// btMoveUp
			// 
			this.btMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btMoveUp.Location = new System.Drawing.Point(246, 125);
			this.btMoveUp.Name = "btMoveUp";
			this.btMoveUp.Size = new System.Drawing.Size(25, 23);
			this.btMoveUp.TabIndex = 4;
			this.btMoveUp.UseVisualStyleBackColor = true;
			this.btMoveUp.Click += new System.EventHandler(this.BtMoveUpClick);
			// 
			// byMoveDown
			// 
			this.byMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.byMoveDown.Location = new System.Drawing.Point(277, 125);
			this.byMoveDown.Name = "byMoveDown";
			this.byMoveDown.Size = new System.Drawing.Size(25, 23);
			this.byMoveDown.TabIndex = 5;
			this.byMoveDown.UseVisualStyleBackColor = true;
			this.byMoveDown.Click += new System.EventHandler(this.ByMoveDownClick);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// ModelRunList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.byMoveDown);
			this.Controls.Add(this.btMoveUp);
			this.Controls.Add(this.btAddFolder);
			this.Controls.Add(this.btRemove);
			this.Controls.Add(this.btAdd);
			this.Controls.Add(this.dataGridView1);
			this.Name = "ModelRunList";
			this.Size = new System.Drawing.Size(328, 151);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button byMoveDown;
		private System.Windows.Forms.Button btMoveUp;
		private System.Windows.Forms.Button btAddFolder;
		private System.Windows.Forms.Button btRemove;
		private System.Windows.Forms.Button btAdd;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}
