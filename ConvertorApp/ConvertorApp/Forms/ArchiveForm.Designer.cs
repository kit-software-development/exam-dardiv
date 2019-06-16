﻿namespace ConvertorApp.Forms
{
    partial class ArchiveForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spearmansRhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archiveViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.archiveViewDataSet = new ConvertorApp.ArchiveViewDataSet();
            this.archiveViewTableAdapter = new ConvertorApp.ArchiveViewDataSetTableAdapters.ArchiveViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveViewDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xDataGridViewTextBoxColumn,
            this.yDataGridViewTextBoxColumn,
            this.spearmansRhoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.archiveViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 233);
            this.dataGridView1.TabIndex = 0;
            // 
            // xDataGridViewTextBoxColumn
            // 
            this.xDataGridViewTextBoxColumn.DataPropertyName = "X";
            this.xDataGridViewTextBoxColumn.HeaderText = "X";
            this.xDataGridViewTextBoxColumn.Name = "xDataGridViewTextBoxColumn";
            // 
            // yDataGridViewTextBoxColumn
            // 
            this.yDataGridViewTextBoxColumn.DataPropertyName = "Y";
            this.yDataGridViewTextBoxColumn.HeaderText = "Y";
            this.yDataGridViewTextBoxColumn.Name = "yDataGridViewTextBoxColumn";
            // 
            // spearmansRhoDataGridViewTextBoxColumn
            // 
            this.spearmansRhoDataGridViewTextBoxColumn.DataPropertyName = "Spearman\'s rho";
            this.spearmansRhoDataGridViewTextBoxColumn.HeaderText = "Spearman\'s rho";
            this.spearmansRhoDataGridViewTextBoxColumn.Name = "spearmansRhoDataGridViewTextBoxColumn";
            // 
            // archiveViewBindingSource
            // 
            this.archiveViewBindingSource.DataMember = "ArchiveView";
            this.archiveViewBindingSource.DataSource = this.archiveViewDataSet;
            // 
            // archiveViewDataSet
            // 
            this.archiveViewDataSet.DataSetName = "ArchiveViewDataSet";
            this.archiveViewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // archiveViewTableAdapter
            // 
            this.archiveViewTableAdapter.ClearBeforeFill = true;
            // 
            // ArchiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 239);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ArchiveForm";
            this.Text = "Recent calculations";
            this.Load += new System.EventHandler(this.ArchiveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveViewDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ArchiveViewDataSet archiveViewDataSet;
        private System.Windows.Forms.BindingSource archiveViewBindingSource;
        private ArchiveViewDataSetTableAdapters.ArchiveViewTableAdapter archiveViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spearmansRhoDataGridViewTextBoxColumn;
    }
}