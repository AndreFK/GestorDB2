﻿namespace DB2Test
{
    partial class BorrarIndices
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btpk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabpk = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pkname = new System.Windows.Forms.ComboBox();
            this.dgvpk = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btfk = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabfk = new System.Windows.Forms.ComboBox();
            this.fkname = new System.Windows.Forms.ComboBox();
            this.dgvfk = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btind = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabind = new System.Windows.Forms.ComboBox();
            this.indname = new System.Windows.Forms.ComboBox();
            this.dgvind = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tablasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarDDLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarDDLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.proceduresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.triggersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpk)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfk)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvind)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btpk);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tabpk);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pkname);
            this.groupBox1.Controls.Add(this.dgvpk);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Borrar PK";
            // 
            // btpk
            // 
            this.btpk.Location = new System.Drawing.Point(131, 122);
            this.btpk.Name = "btpk";
            this.btpk.Size = new System.Drawing.Size(75, 23);
            this.btpk.TabIndex = 9;
            this.btpk.Text = "Borrar";
            this.btpk.UseVisualStyleBackColor = true;
            this.btpk.Click += new System.EventHandler(this.btpk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre de Tabla: ";
            // 
            // tabpk
            // 
            this.tabpk.FormattingEnabled = true;
            this.tabpk.Location = new System.Drawing.Point(114, 19);
            this.tabpk.Name = "tabpk";
            this.tabpk.Size = new System.Drawing.Size(121, 21);
            this.tabpk.TabIndex = 7;
            this.tabpk.SelectedIndexChanged += new System.EventHandler(this.tabpk_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre de PK: ";
            // 
            // pkname
            // 
            this.pkname.FormattingEnabled = true;
            this.pkname.Location = new System.Drawing.Point(114, 56);
            this.pkname.Name = "pkname";
            this.pkname.Size = new System.Drawing.Size(121, 21);
            this.pkname.TabIndex = 1;
            // 
            // dgvpk
            // 
            this.dgvpk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpk.Location = new System.Drawing.Point(331, 19);
            this.dgvpk.Name = "dgvpk";
            this.dgvpk.Size = new System.Drawing.Size(476, 145);
            this.dgvpk.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btfk);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tabfk);
            this.groupBox2.Controls.Add(this.fkname);
            this.groupBox2.Controls.Add(this.dgvfk);
            this.groupBox2.Location = new System.Drawing.Point(12, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(814, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Borrar FK";
            // 
            // btfk
            // 
            this.btfk.Location = new System.Drawing.Point(131, 129);
            this.btfk.Name = "btfk";
            this.btfk.Size = new System.Drawing.Size(75, 23);
            this.btfk.TabIndex = 10;
            this.btfk.Text = "Borrar";
            this.btfk.UseVisualStyleBackColor = true;
            this.btfk.Click += new System.EventHandler(this.btfk_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nombre de Tabla: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre de FK: ";
            // 
            // tabfk
            // 
            this.tabfk.FormattingEnabled = true;
            this.tabfk.Location = new System.Drawing.Point(114, 20);
            this.tabfk.Name = "tabfk";
            this.tabfk.Size = new System.Drawing.Size(121, 21);
            this.tabfk.TabIndex = 9;
            this.tabfk.SelectedIndexChanged += new System.EventHandler(this.tabfk_SelectedIndexChanged);
            // 
            // fkname
            // 
            this.fkname.FormattingEnabled = true;
            this.fkname.Location = new System.Drawing.Point(114, 60);
            this.fkname.Name = "fkname";
            this.fkname.Size = new System.Drawing.Size(121, 21);
            this.fkname.TabIndex = 2;
            // 
            // dgvfk
            // 
            this.dgvfk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfk.Location = new System.Drawing.Point(331, 19);
            this.dgvfk.Name = "dgvfk";
            this.dgvfk.Size = new System.Drawing.Size(476, 145);
            this.dgvfk.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btind);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tabind);
            this.groupBox3.Controls.Add(this.indname);
            this.groupBox3.Controls.Add(this.dgvind);
            this.groupBox3.Location = new System.Drawing.Point(12, 389);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(814, 170);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Borrar Indice";
            // 
            // btind
            // 
            this.btind.Location = new System.Drawing.Point(131, 125);
            this.btind.Name = "btind";
            this.btind.Size = new System.Drawing.Size(75, 23);
            this.btind.TabIndex = 11;
            this.btind.Text = "Borrar";
            this.btind.UseVisualStyleBackColor = true;
            this.btind.Click += new System.EventHandler(this.btind_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nombre de Tabla: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre de Indice: ";
            // 
            // tabind
            // 
            this.tabind.FormattingEnabled = true;
            this.tabind.Location = new System.Drawing.Point(114, 25);
            this.tabind.Name = "tabind";
            this.tabind.Size = new System.Drawing.Size(121, 21);
            this.tabind.TabIndex = 11;
            this.tabind.SelectedIndexChanged += new System.EventHandler(this.tabind_SelectedIndexChanged);
            // 
            // indname
            // 
            this.indname.FormattingEnabled = true;
            this.indname.Location = new System.Drawing.Point(114, 67);
            this.indname.Name = "indname";
            this.indname.Size = new System.Drawing.Size(121, 21);
            this.indname.TabIndex = 3;
            // 
            // dgvind
            // 
            this.dgvind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvind.Location = new System.Drawing.Point(331, 25);
            this.dgvind.Name = "dgvind";
            this.dgvind.Size = new System.Drawing.Size(476, 145);
            this.dgvind.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablasToolStripMenuItem,
            this.indicesToolStripMenuItem,
            this.proceduresToolStripMenuItem,
            this.triggersToolStripMenuItem,
            this.viewsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tablasToolStripMenuItem
            // 
            this.tablasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem,
            this.crearToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.borrarToolStripMenuItem,
            this.mostrarDDLToolStripMenuItem});
            this.tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            this.tablasToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.tablasToolStripMenuItem.Text = "Tablas";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearToolStripMenuItem.Text = "Crear";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borrarToolStripMenuItem.Text = "Borrar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // mostrarDDLToolStripMenuItem
            // 
            this.mostrarDDLToolStripMenuItem.Name = "mostrarDDLToolStripMenuItem";
            this.mostrarDDLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarDDLToolStripMenuItem.Text = "Mostrar DDL";
            this.mostrarDDLToolStripMenuItem.Click += new System.EventHandler(this.mostrarDDLToolStripMenuItem_Click);
            // 
            // indicesToolStripMenuItem
            // 
            this.indicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem1,
            this.crearToolStripMenuItem1,
            this.modificarToolStripMenuItem1,
            this.borrarToolStripMenuItem1,
            this.mostrarDDLToolStripMenuItem1});
            this.indicesToolStripMenuItem.Name = "indicesToolStripMenuItem";
            this.indicesToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.indicesToolStripMenuItem.Text = "Indices";
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem1.Text = "Listar";
            this.listarToolStripMenuItem1.Click += new System.EventHandler(this.listarToolStripMenuItem1_Click);
            // 
            // crearToolStripMenuItem1
            // 
            this.crearToolStripMenuItem1.Name = "crearToolStripMenuItem1";
            this.crearToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.crearToolStripMenuItem1.Text = "Crear";
            this.crearToolStripMenuItem1.Click += new System.EventHandler(this.crearToolStripMenuItem1_Click);
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            this.modificarToolStripMenuItem1.Click += new System.EventHandler(this.modificarToolStripMenuItem1_Click);
            // 
            // borrarToolStripMenuItem1
            // 
            this.borrarToolStripMenuItem1.Name = "borrarToolStripMenuItem1";
            this.borrarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.borrarToolStripMenuItem1.Text = "Borrar";
            this.borrarToolStripMenuItem1.Click += new System.EventHandler(this.borrarToolStripMenuItem1_Click);
            // 
            // mostrarDDLToolStripMenuItem1
            // 
            this.mostrarDDLToolStripMenuItem1.Name = "mostrarDDLToolStripMenuItem1";
            this.mostrarDDLToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.mostrarDDLToolStripMenuItem1.Text = "Mostrar DDL";
            this.mostrarDDLToolStripMenuItem1.Click += new System.EventHandler(this.mostrarDDLToolStripMenuItem1_Click);
            // 
            // proceduresToolStripMenuItem
            // 
            this.proceduresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem2,
            this.crearToolStripMenuItem2,
            this.modificarToolStripMenuItem2,
            this.borrarToolStripMenuItem2});
            this.proceduresToolStripMenuItem.Name = "proceduresToolStripMenuItem";
            this.proceduresToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.proceduresToolStripMenuItem.Text = "Procedures";
            // 
            // listarToolStripMenuItem2
            // 
            this.listarToolStripMenuItem2.Name = "listarToolStripMenuItem2";
            this.listarToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem2.Text = "Listar";
            this.listarToolStripMenuItem2.Click += new System.EventHandler(this.listarToolStripMenuItem2_Click);
            // 
            // crearToolStripMenuItem2
            // 
            this.crearToolStripMenuItem2.Name = "crearToolStripMenuItem2";
            this.crearToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.crearToolStripMenuItem2.Text = "Crear";
            this.crearToolStripMenuItem2.Click += new System.EventHandler(this.crearToolStripMenuItem2_Click);
            // 
            // modificarToolStripMenuItem2
            // 
            this.modificarToolStripMenuItem2.Name = "modificarToolStripMenuItem2";
            this.modificarToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.modificarToolStripMenuItem2.Text = "Modificar";
            this.modificarToolStripMenuItem2.Click += new System.EventHandler(this.modificarToolStripMenuItem2_Click);
            // 
            // borrarToolStripMenuItem2
            // 
            this.borrarToolStripMenuItem2.Name = "borrarToolStripMenuItem2";
            this.borrarToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.borrarToolStripMenuItem2.Text = "Borrar";
            this.borrarToolStripMenuItem2.Click += new System.EventHandler(this.borrarToolStripMenuItem2_Click);
            // 
            // triggersToolStripMenuItem
            // 
            this.triggersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem3,
            this.crearToolStripMenuItem3,
            this.modificarToolStripMenuItem3,
            this.borrarToolStripMenuItem3});
            this.triggersToolStripMenuItem.Name = "triggersToolStripMenuItem";
            this.triggersToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.triggersToolStripMenuItem.Text = "Triggers";
            // 
            // listarToolStripMenuItem3
            // 
            this.listarToolStripMenuItem3.Name = "listarToolStripMenuItem3";
            this.listarToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem3.Text = "Listar ";
            this.listarToolStripMenuItem3.Click += new System.EventHandler(this.listarToolStripMenuItem3_Click);
            // 
            // crearToolStripMenuItem3
            // 
            this.crearToolStripMenuItem3.Name = "crearToolStripMenuItem3";
            this.crearToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.crearToolStripMenuItem3.Text = "Crear";
            this.crearToolStripMenuItem3.Click += new System.EventHandler(this.crearToolStripMenuItem3_Click);
            // 
            // modificarToolStripMenuItem3
            // 
            this.modificarToolStripMenuItem3.Name = "modificarToolStripMenuItem3";
            this.modificarToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.modificarToolStripMenuItem3.Text = "Modificar";
            this.modificarToolStripMenuItem3.Click += new System.EventHandler(this.modificarToolStripMenuItem3_Click);
            // 
            // borrarToolStripMenuItem3
            // 
            this.borrarToolStripMenuItem3.Name = "borrarToolStripMenuItem3";
            this.borrarToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.borrarToolStripMenuItem3.Text = "Borrar";
            this.borrarToolStripMenuItem3.Click += new System.EventHandler(this.borrarToolStripMenuItem3_Click);
            // 
            // viewsToolStripMenuItem
            // 
            this.viewsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem4,
            this.crearToolStripMenuItem4,
            this.modificarToolStripMenuItem4,
            this.borrarToolStripMenuItem4});
            this.viewsToolStripMenuItem.Name = "viewsToolStripMenuItem";
            this.viewsToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.viewsToolStripMenuItem.Text = "Views";
            // 
            // listarToolStripMenuItem4
            // 
            this.listarToolStripMenuItem4.Name = "listarToolStripMenuItem4";
            this.listarToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem4.Text = "Listar";
            this.listarToolStripMenuItem4.Click += new System.EventHandler(this.listarToolStripMenuItem4_Click);
            // 
            // crearToolStripMenuItem4
            // 
            this.crearToolStripMenuItem4.Name = "crearToolStripMenuItem4";
            this.crearToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.crearToolStripMenuItem4.Text = "Crear";
            this.crearToolStripMenuItem4.Click += new System.EventHandler(this.crearToolStripMenuItem4_Click);
            // 
            // modificarToolStripMenuItem4
            // 
            this.modificarToolStripMenuItem4.Name = "modificarToolStripMenuItem4";
            this.modificarToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.modificarToolStripMenuItem4.Text = "Modificar";
            this.modificarToolStripMenuItem4.Click += new System.EventHandler(this.modificarToolStripMenuItem4_Click);
            // 
            // borrarToolStripMenuItem4
            // 
            this.borrarToolStripMenuItem4.Name = "borrarToolStripMenuItem4";
            this.borrarToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.borrarToolStripMenuItem4.Text = "Borrar";
            this.borrarToolStripMenuItem4.Click += new System.EventHandler(this.borrarToolStripMenuItem4_Click);
            // 
            // BorrarIndices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 579);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BorrarIndices";
            this.Text = "BorrarIndices";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpk)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfk)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvind)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvpk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvfk;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pkname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox fkname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox indname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tabpk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tabfk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tabind;
        private System.Windows.Forms.Button btpk;
        private System.Windows.Forms.Button btfk;
        private System.Windows.Forms.Button btind;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tablasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarDDLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mostrarDDLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem proceduresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem triggersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem viewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem4;
    }
}