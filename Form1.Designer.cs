﻿namespace TondoDB
{
    partial class Form1
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
            this.ToodeText = new System.Windows.Forms.TextBox();
            this.HindText = new System.Windows.Forms.TextBox();
            this.KogusText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pilt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tootetableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toodedDataSet1 = new TondoDB.ToodedDataSet1();
            this.tootetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toodedDataSet = new TondoDB.ToodedDataSet();
            this.tootetableTableAdapter = new TondoDB.ToodedDataSetTableAdapters.TootetableTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_img = new System.Windows.Forms.Button();
            this.toodedDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tootetableTableAdapter1 = new TondoDB.ToodedDataSet1TableAdapters.TootetableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tootetableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodedDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tootetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodedDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ToodeText
            // 
            this.ToodeText.Location = new System.Drawing.Point(101, 51);
            this.ToodeText.Name = "ToodeText";
            this.ToodeText.Size = new System.Drawing.Size(100, 20);
            this.ToodeText.TabIndex = 0;
            // 
            // HindText
            // 
            this.HindText.Location = new System.Drawing.Point(101, 77);
            this.HindText.Name = "HindText";
            this.HindText.Size = new System.Drawing.Size(100, 20);
            this.HindText.TabIndex = 1;
            // 
            // KogusText
            // 
            this.KogusText.Location = new System.Drawing.Point(101, 103);
            this.KogusText.Name = "KogusText";
            this.KogusText.Size = new System.Drawing.Size(100, 20);
            this.KogusText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Toode";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hind";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kogus";
            // 
            // btn_Insert
            // 
            this.btn_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btn_Insert.Location = new System.Drawing.Point(100, 140);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(101, 51);
            this.btn_Insert.TabIndex = 6;
            this.btn_Insert.Text = "Lisa uus";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btn_Update.Location = new System.Drawing.Point(100, 209);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(101, 49);
            this.btn_Update.TabIndex = 7;
            this.btn_Update.Text = "Uuenda";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btn_Delete.Location = new System.Drawing.Point(100, 277);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(101, 49);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "Kustuta";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pilt});
            this.dataGridView1.Location = new System.Drawing.Point(254, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 426);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // Pilt
            // 
            this.Pilt.DataPropertyName = "Pilt";
            this.Pilt.HeaderText = "Pilt";
            this.Pilt.Name = "Pilt";
            // 
            // tootetableBindingSource1
            // 
            this.tootetableBindingSource1.DataMember = "Tootetable";
            this.tootetableBindingSource1.DataSource = this.toodedDataSet1;
            // 
            // toodedDataSet1
            // 
            this.toodedDataSet1.DataSetName = "ToodedDataSet1";
            this.toodedDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tootetableBindingSource
            // 
            this.tootetableBindingSource.DataMember = "Tootetable";
            this.tootetableBindingSource.DataSource = this.toodedDataSet;
            // 
            // toodedDataSet
            // 
            this.toodedDataSet.DataSetName = "ToodedDataSet";
            this.toodedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tootetableTableAdapter
            // 
            this.tootetableTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(83, 458);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btn_img
            // 
            this.btn_img.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btn_img.Location = new System.Drawing.Point(100, 389);
            this.btn_img.Name = "btn_img";
            this.btn_img.Size = new System.Drawing.Size(101, 49);
            this.btn_img.TabIndex = 11;
            this.btn_img.Text = "Lisa uus";
            this.btn_img.UseVisualStyleBackColor = true;
            this.btn_img.Click += new System.EventHandler(this.btn_img_Click);
            // 
            // toodedDataSetBindingSource
            // 
            this.toodedDataSetBindingSource.DataSource = this.toodedDataSet;
            this.toodedDataSetBindingSource.Position = 0;
            // 
            // tootetableTableAdapter1
            // 
            this.tootetableTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(927, 586);
            this.Controls.Add(this.btn_img);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KogusText);
            this.Controls.Add(this.HindText);
            this.Controls.Add(this.ToodeText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tootetableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodedDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tootetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodedDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ToodeText;
        private System.Windows.Forms.TextBox HindText;
        private System.Windows.Forms.TextBox KogusText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ToodedDataSet toodedDataSet;
        private System.Windows.Forms.BindingSource tootetableBindingSource;
        private ToodedDataSetTableAdapters.TootetableTableAdapter tootetableTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_img;
        private System.Windows.Forms.BindingSource toodedDataSetBindingSource;
        private ToodedDataSet1 toodedDataSet1;
        private System.Windows.Forms.BindingSource tootetableBindingSource1;
        private ToodedDataSet1TableAdapters.TootetableTableAdapter tootetableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pilt;
    }
}

