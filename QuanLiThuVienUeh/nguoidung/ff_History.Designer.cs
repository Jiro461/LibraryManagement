﻿namespace QuanLiThuVienUeh.nguoidung
{
    partial class ff_History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ff_History));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Null2 = new System.Windows.Forms.Panel();
            this.label_ThongTinNhanVien = new System.Windows.Forms.Label();
            this.label_SearchName = new System.Windows.Forms.Label();
            this.textBox_SearchName = new System.Windows.Forms.TextBox();
            this.panel_Search = new System.Windows.Forms.Panel();
            this.button_ReturnLastPage = new System.Windows.Forms.Button();
            this.button_ReturnFirstPage = new System.Windows.Forms.Button();
            this.button_InsertDelete = new System.Windows.Forms.Button();
            this.label_Previous = new System.Windows.Forms.Label();
            this.panel_Null3 = new System.Windows.Forms.Panel();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_ChangePage3 = new System.Windows.Forms.Button();
            this.label_Next = new System.Windows.Forms.Label();
            this.button_ChangePage2 = new System.Windows.Forms.Button();
            this.panel_Null1 = new System.Windows.Forms.Panel();
            this.dataGridView_History = new System.Windows.Forms.DataGridView();
            this.panel_Null4 = new System.Windows.Forms.Panel();
            this.button_ChangePage1 = new System.Windows.Forms.Button();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_SearchFunction = new System.Windows.Forms.Panel();
            this.panel_Search.SuspendLayout();
            this.panel_Null3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_History)).BeginInit();
            this.panel_Null4.SuspendLayout();
            this.panel_Main.SuspendLayout();
            this.panel_SearchFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Null2
            // 
            this.panel_Null2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Null2.Location = new System.Drawing.Point(1281, 0);
            this.panel_Null2.Name = "panel_Null2";
            this.panel_Null2.Size = new System.Drawing.Size(22, 676);
            this.panel_Null2.TabIndex = 19;
            // 
            // label_ThongTinNhanVien
            // 
            this.label_ThongTinNhanVien.AutoSize = true;
            this.label_ThongTinNhanVien.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ThongTinNhanVien.Location = new System.Drawing.Point(-5, 9);
            this.label_ThongTinNhanVien.Name = "label_ThongTinNhanVien";
            this.label_ThongTinNhanVien.Size = new System.Drawing.Size(161, 30);
            this.label_ThongTinNhanVien.TabIndex = 6;
            this.label_ThongTinNhanVien.Text = "LỊCH SỬ MƯỢN";
            this.label_ThongTinNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_SearchName
            // 
            this.label_SearchName.AutoSize = true;
            this.label_SearchName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label_SearchName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SearchName.ForeColor = System.Drawing.Color.DimGray;
            this.label_SearchName.Location = new System.Drawing.Point(12, 8);
            this.label_SearchName.Name = "label_SearchName";
            this.label_SearchName.Size = new System.Drawing.Size(183, 21);
            this.label_SearchName.TabIndex = 10;
            this.label_SearchName.Text = "Search by id, name, book";
            this.label_SearchName.Click += new System.EventHandler(this.label_SearchName_Click);
            // 
            // textBox_SearchName
            // 
            this.textBox_SearchName.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_SearchName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_SearchName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SearchName.Location = new System.Drawing.Point(2, 8);
            this.textBox_SearchName.Name = "textBox_SearchName";
            this.textBox_SearchName.Size = new System.Drawing.Size(475, 22);
            this.textBox_SearchName.TabIndex = 7;
            this.textBox_SearchName.Click += new System.EventHandler(this.textBox_SearchName_Click);
            this.textBox_SearchName.TextChanged += new System.EventHandler(this.textBox_SearchName_TextChanged);
            // 
            // panel_Search
            // 
            this.panel_Search.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_Search.Controls.Add(this.label_SearchName);
            this.panel_Search.Controls.Add(this.textBox_SearchName);
            this.panel_Search.Location = new System.Drawing.Point(0, 47);
            this.panel_Search.Name = "panel_Search";
            this.panel_Search.Size = new System.Drawing.Size(480, 39);
            this.panel_Search.TabIndex = 9;
            // 
            // button_ReturnLastPage
            // 
            this.button_ReturnLastPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ReturnLastPage.BackColor = System.Drawing.Color.White;
            this.button_ReturnLastPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ReturnLastPage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.button_ReturnLastPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.button_ReturnLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ReturnLastPage.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ReturnLastPage.ForeColor = System.Drawing.Color.Black;
            this.button_ReturnLastPage.Location = new System.Drawing.Point(1160, 11);
            this.button_ReturnLastPage.Name = "button_ReturnLastPage";
            this.button_ReturnLastPage.Size = new System.Drawing.Size(40, 40);
            this.button_ReturnLastPage.TabIndex = 19;
            this.button_ReturnLastPage.Text = ">>";
            this.button_ReturnLastPage.UseVisualStyleBackColor = false;
            this.button_ReturnLastPage.Click += new System.EventHandler(this.button_ReturnLastPage_Click);
            // 
            // button_ReturnFirstPage
            // 
            this.button_ReturnFirstPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ReturnFirstPage.BackColor = System.Drawing.Color.White;
            this.button_ReturnFirstPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ReturnFirstPage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.button_ReturnFirstPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.button_ReturnFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ReturnFirstPage.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ReturnFirstPage.ForeColor = System.Drawing.Color.Black;
            this.button_ReturnFirstPage.Location = new System.Drawing.Point(925, 11);
            this.button_ReturnFirstPage.Name = "button_ReturnFirstPage";
            this.button_ReturnFirstPage.Size = new System.Drawing.Size(40, 40);
            this.button_ReturnFirstPage.TabIndex = 18;
            this.button_ReturnFirstPage.Text = "<<";
            this.button_ReturnFirstPage.UseVisualStyleBackColor = false;
            this.button_ReturnFirstPage.Click += new System.EventHandler(this.button_ReturnFirstPage_Click);
            // 
            // button_InsertDelete
            // 
            this.button_InsertDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_InsertDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_InsertDelete.FlatAppearance.BorderSize = 0;
            this.button_InsertDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_InsertDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_InsertDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.button_InsertDelete.Image = ((System.Drawing.Image)(resources.GetObject("button_InsertDelete.Image")));
            this.button_InsertDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_InsertDelete.Location = new System.Drawing.Point(0, 11);
            this.button_InsertDelete.Name = "button_InsertDelete";
            this.button_InsertDelete.Size = new System.Drawing.Size(173, 40);
            this.button_InsertDelete.TabIndex = 11;
            this.button_InsertDelete.Text = "      Insert/ Delete";
            this.button_InsertDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_InsertDelete.UseVisualStyleBackColor = true;
            // 
            // label_Previous
            // 
            this.label_Previous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Previous.AutoSize = true;
            this.label_Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Previous.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Previous.Location = new System.Drawing.Point(836, 19);
            this.label_Previous.Name = "label_Previous";
            this.label_Previous.Size = new System.Drawing.Size(84, 25);
            this.label_Previous.TabIndex = 12;
            this.label_Previous.Text = "Previous";
            // 
            // panel_Null3
            // 
            this.panel_Null3.Controls.Add(this.panel_Search);
            this.panel_Null3.Controls.Add(this.button_Search);
            this.panel_Null3.Controls.Add(this.label_ThongTinNhanVien);
            this.panel_Null3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Null3.Location = new System.Drawing.Point(0, 0);
            this.panel_Null3.Name = "panel_Null3";
            this.panel_Null3.Size = new System.Drawing.Size(1250, 103);
            this.panel_Null3.TabIndex = 0;
            // 
            // button_Search
            // 
            this.button_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.button_Search.FlatAppearance.BorderSize = 0;
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.ForeColor = System.Drawing.Color.White;
            this.button_Search.Location = new System.Drawing.Point(1096, 46);
            this.button_Search.Margin = new System.Windows.Forms.Padding(2);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(155, 39);
            this.button_Search.TabIndex = 4;
            this.button_Search.Text = "SEARCH";
            this.button_Search.UseVisualStyleBackColor = false;
            // 
            // button_ChangePage3
            // 
            this.button_ChangePage3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ChangePage3.BackColor = System.Drawing.Color.White;
            this.button_ChangePage3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ChangePage3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.button_ChangePage3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.button_ChangePage3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ChangePage3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ChangePage3.ForeColor = System.Drawing.Color.Black;
            this.button_ChangePage3.Location = new System.Drawing.Point(1102, 11);
            this.button_ChangePage3.Name = "button_ChangePage3";
            this.button_ChangePage3.Size = new System.Drawing.Size(40, 40);
            this.button_ChangePage3.TabIndex = 17;
            this.button_ChangePage3.Text = "3";
            this.button_ChangePage3.UseVisualStyleBackColor = false;
            this.button_ChangePage3.Click += new System.EventHandler(this.button_ChangePage3_Click);
            // 
            // label_Next
            // 
            this.label_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Next.AutoSize = true;
            this.label_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Next.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Next.Location = new System.Drawing.Point(1205, 19);
            this.label_Next.Name = "label_Next";
            this.label_Next.Size = new System.Drawing.Size(51, 25);
            this.label_Next.TabIndex = 16;
            this.label_Next.Text = "Next";
            // 
            // button_ChangePage2
            // 
            this.button_ChangePage2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ChangePage2.BackColor = System.Drawing.Color.White;
            this.button_ChangePage2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ChangePage2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.button_ChangePage2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.button_ChangePage2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ChangePage2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ChangePage2.ForeColor = System.Drawing.Color.Black;
            this.button_ChangePage2.Location = new System.Drawing.Point(1044, 11);
            this.button_ChangePage2.Name = "button_ChangePage2";
            this.button_ChangePage2.Size = new System.Drawing.Size(40, 40);
            this.button_ChangePage2.TabIndex = 14;
            this.button_ChangePage2.Text = "2";
            this.button_ChangePage2.UseVisualStyleBackColor = false;
            this.button_ChangePage2.Click += new System.EventHandler(this.button_ChangePage2_Click);
            // 
            // panel_Null1
            // 
            this.panel_Null1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Null1.Location = new System.Drawing.Point(0, 0);
            this.panel_Null1.Name = "panel_Null1";
            this.panel_Null1.Size = new System.Drawing.Size(31, 676);
            this.panel_Null1.TabIndex = 18;
            // 
            // dataGridView_History
            // 
            this.dataGridView_History.AllowUserToAddRows = false;
            this.dataGridView_History.AllowUserToDeleteRows = false;
            this.dataGridView_History.AllowUserToResizeColumns = false;
            this.dataGridView_History.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            this.dataGridView_History.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView_History.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_History.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_History.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView_History.ColumnHeadersHeight = 40;
            this.dataGridView_History.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_History.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_History.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView_History.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_History.EnableHeadersVisualStyles = false;
            this.dataGridView_History.GridColor = System.Drawing.Color.White;
            this.dataGridView_History.Location = new System.Drawing.Point(0, 103);
            this.dataGridView_History.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_History.MultiSelect = false;
            this.dataGridView_History.Name = "dataGridView_History";
            this.dataGridView_History.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_History.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView_History.RowHeadersVisible = false;
            this.dataGridView_History.RowHeadersWidth = 100;
            this.dataGridView_History.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.dataGridView_History.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView_History.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_History.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_History.RowTemplate.Height = 24;
            this.dataGridView_History.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_History.Size = new System.Drawing.Size(1250, 512);
            this.dataGridView_History.TabIndex = 0;
            // 
            // panel_Null4
            // 
            this.panel_Null4.Controls.Add(this.button_ReturnLastPage);
            this.panel_Null4.Controls.Add(this.button_ReturnFirstPage);
            this.panel_Null4.Controls.Add(this.button_InsertDelete);
            this.panel_Null4.Controls.Add(this.label_Previous);
            this.panel_Null4.Controls.Add(this.button_ChangePage3);
            this.panel_Null4.Controls.Add(this.button_ChangePage1);
            this.panel_Null4.Controls.Add(this.label_Next);
            this.panel_Null4.Controls.Add(this.button_ChangePage2);
            this.panel_Null4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Null4.Location = new System.Drawing.Point(0, 615);
            this.panel_Null4.Name = "panel_Null4";
            this.panel_Null4.Size = new System.Drawing.Size(1250, 61);
            this.panel_Null4.TabIndex = 1;
            // 
            // button_ChangePage1
            // 
            this.button_ChangePage1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ChangePage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.button_ChangePage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ChangePage1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.button_ChangePage1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.button_ChangePage1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ChangePage1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ChangePage1.ForeColor = System.Drawing.Color.White;
            this.button_ChangePage1.Location = new System.Drawing.Point(985, 11);
            this.button_ChangePage1.Name = "button_ChangePage1";
            this.button_ChangePage1.Size = new System.Drawing.Size(40, 40);
            this.button_ChangePage1.TabIndex = 13;
            this.button_ChangePage1.Text = "1";
            this.button_ChangePage1.UseVisualStyleBackColor = false;
            this.button_ChangePage1.Click += new System.EventHandler(this.button_ChangePage1_Click);
            // 
            // panel_Main
            // 
            this.panel_Main.Controls.Add(this.dataGridView_History);
            this.panel_Main.Controls.Add(this.panel_Null4);
            this.panel_Main.Controls.Add(this.panel_Null3);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(31, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1250, 676);
            this.panel_Main.TabIndex = 20;
            // 
            // panel_SearchFunction
            // 
            this.panel_SearchFunction.BackColor = System.Drawing.Color.White;
            this.panel_SearchFunction.Controls.Add(this.panel_Main);
            this.panel_SearchFunction.Controls.Add(this.panel_Null1);
            this.panel_SearchFunction.Controls.Add(this.panel_Null2);
            this.panel_SearchFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_SearchFunction.Location = new System.Drawing.Point(0, 0);
            this.panel_SearchFunction.Name = "panel_SearchFunction";
            this.panel_SearchFunction.Size = new System.Drawing.Size(1303, 676);
            this.panel_SearchFunction.TabIndex = 2;
            // 
            // ff_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1303, 676);
            this.Controls.Add(this.panel_SearchFunction);
            this.Name = "ff_History";
            this.Text = "Form_History";
            this.Resize += new System.EventHandler(this.FormHistory_Resize);
            this.panel_Search.ResumeLayout(false);
            this.panel_Search.PerformLayout();
            this.panel_Null3.ResumeLayout(false);
            this.panel_Null3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_History)).EndInit();
            this.panel_Null4.ResumeLayout(false);
            this.panel_Null4.PerformLayout();
            this.panel_Main.ResumeLayout(false);
            this.panel_SearchFunction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Null2;
        private System.Windows.Forms.Label label_ThongTinNhanVien;
        private System.Windows.Forms.Label label_SearchName;
        private System.Windows.Forms.TextBox textBox_SearchName;
        private System.Windows.Forms.Panel panel_Search;
        private System.Windows.Forms.Button button_ReturnLastPage;
        private System.Windows.Forms.Button button_ReturnFirstPage;
        private System.Windows.Forms.Button button_InsertDelete;
        private System.Windows.Forms.Label label_Previous;
        private System.Windows.Forms.Panel panel_Null3;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_ChangePage3;
        private System.Windows.Forms.Label label_Next;
        private System.Windows.Forms.Button button_ChangePage2;
        private System.Windows.Forms.Panel panel_Null1;
        private System.Windows.Forms.DataGridView dataGridView_History;
        private System.Windows.Forms.Panel panel_Null4;
        private System.Windows.Forms.Button button_ChangePage1;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Panel panel_SearchFunction;
    }
}