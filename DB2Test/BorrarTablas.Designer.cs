﻿namespace DB2Test
{
    partial class BorrarTablas
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tabName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.borrarBtn = new System.Windows.Forms.Button();
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
            this.mostrarDDLToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.triggersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarDDLToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarDDLToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Location = new System.Drawing.Point(274, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 406);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tablas";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(7, 20);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(397, 400);
            this.dgv.TabIndex = 0;
            // 
            // tabName
            // 
            this.tabName.FormattingEnabled = true;
            this.tabName.Location = new System.Drawing.Point(109, 52);
            this.tabName.Name = "tabName";
            this.tabName.Size = new System.Drawing.Size(121, 21);
            this.tabName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tabla a borrar:";
            // 
            // borrarBtn
            // 
            this.borrarBtn.Location = new System.Drawing.Point(109, 113);
            this.borrarBtn.Name = "borrarBtn";
            this.borrarBtn.Size = new System.Drawing.Size(75, 23);
            this.borrarBtn.TabIndex = 3;
            this.borrarBtn.Text = "Borrar";
            this.borrarBtn.UseVisualStyleBackColor = true;
            this.borrarBtn.Click += new System.EventHandler(this.borrarBtn_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(692, 24);
            this.menuStrip1.TabIndex = 6;
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
            // 
            // mostrarDDLToolStripMenuItem
            // 
            this.mostrarDDLToolStripMenuItem.Name = "mostrarDDLToolStripMenuItem";
            this.mostrarDDLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarDDLToolStripMenuItem.Text = "Mostrar DDL";
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
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.listarToolStripMenuItem1.Text = "Listar";
            // 
            // crearToolStripMenuItem1
            // 
            this.crearToolStripMenuItem1.Name = "crearToolStripMenuItem1";
            this.crearToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.crearToolStripMenuItem1.Text = "Crear";
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            // 
            // borrarToolStripMenuItem1
            // 
            this.borrarToolStripMenuItem1.Name = "borrarToolStripMenuItem1";
            this.borrarToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.borrarToolStripMenuItem1.Text = "Borrar";
            // 
            // mostrarDDLToolStripMenuItem1
            // 
            this.mostrarDDLToolStripMenuItem1.Name = "mostrarDDLToolStripMenuItem1";
            this.mostrarDDLToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.mostrarDDLToolStripMenuItem1.Text = "Mostrar DDL";
            // 
            // proceduresToolStripMenuItem
            // 
            this.proceduresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem2,
            this.crearToolStripMenuItem2,
            this.modificarToolStripMenuItem2,
            this.borrarToolStripMenuItem2,
            this.mostrarDDLToolStripMenuItem2});
            this.proceduresToolStripMenuItem.Name = "proceduresToolStripMenuItem";
            this.proceduresToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.proceduresToolStripMenuItem.Text = "Procedures";
            // 
            // listarToolStripMenuItem2
            // 
            this.listarToolStripMenuItem2.Name = "listarToolStripMenuItem2";
            this.listarToolStripMenuItem2.Size = new System.Drawing.Size(140, 22);
            this.listarToolStripMenuItem2.Text = "Listar";
            // 
            // crearToolStripMenuItem2
            // 
            this.crearToolStripMenuItem2.Name = "crearToolStripMenuItem2";
            this.crearToolStripMenuItem2.Size = new System.Drawing.Size(140, 22);
            this.crearToolStripMenuItem2.Text = "Crear";
            // 
            // modificarToolStripMenuItem2
            // 
            this.modificarToolStripMenuItem2.Name = "modificarToolStripMenuItem2";
            this.modificarToolStripMenuItem2.Size = new System.Drawing.Size(140, 22);
            this.modificarToolStripMenuItem2.Text = "Modificar";
            // 
            // borrarToolStripMenuItem2
            // 
            this.borrarToolStripMenuItem2.Name = "borrarToolStripMenuItem2";
            this.borrarToolStripMenuItem2.Size = new System.Drawing.Size(140, 22);
            this.borrarToolStripMenuItem2.Text = "Borrar";
            // 
            // mostrarDDLToolStripMenuItem2
            // 
            this.mostrarDDLToolStripMenuItem2.Name = "mostrarDDLToolStripMenuItem2";
            this.mostrarDDLToolStripMenuItem2.Size = new System.Drawing.Size(140, 22);
            this.mostrarDDLToolStripMenuItem2.Text = "Mostrar DDL";
            // 
            // triggersToolStripMenuItem
            // 
            this.triggersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem3,
            this.crearToolStripMenuItem3,
            this.modificarToolStripMenuItem3,
            this.borrarToolStripMenuItem3,
            this.mostrarDDLToolStripMenuItem3});
            this.triggersToolStripMenuItem.Name = "triggersToolStripMenuItem";
            this.triggersToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.triggersToolStripMenuItem.Text = "Triggers";
            // 
            // listarToolStripMenuItem3
            // 
            this.listarToolStripMenuItem3.Name = "listarToolStripMenuItem3";
            this.listarToolStripMenuItem3.Size = new System.Drawing.Size(140, 22);
            this.listarToolStripMenuItem3.Text = "Listar";
            // 
            // crearToolStripMenuItem3
            // 
            this.crearToolStripMenuItem3.Name = "crearToolStripMenuItem3";
            this.crearToolStripMenuItem3.Size = new System.Drawing.Size(140, 22);
            this.crearToolStripMenuItem3.Text = "Crear";
            // 
            // modificarToolStripMenuItem3
            // 
            this.modificarToolStripMenuItem3.Name = "modificarToolStripMenuItem3";
            this.modificarToolStripMenuItem3.Size = new System.Drawing.Size(140, 22);
            this.modificarToolStripMenuItem3.Text = "Modificar";
            // 
            // borrarToolStripMenuItem3
            // 
            this.borrarToolStripMenuItem3.Name = "borrarToolStripMenuItem3";
            this.borrarToolStripMenuItem3.Size = new System.Drawing.Size(140, 22);
            this.borrarToolStripMenuItem3.Text = "Borrar";
            // 
            // mostrarDDLToolStripMenuItem3
            // 
            this.mostrarDDLToolStripMenuItem3.Name = "mostrarDDLToolStripMenuItem3";
            this.mostrarDDLToolStripMenuItem3.Size = new System.Drawing.Size(140, 22);
            this.mostrarDDLToolStripMenuItem3.Text = "Mostrar DDL";
            // 
            // viewsToolStripMenuItem
            // 
            this.viewsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem4,
            this.crearToolStripMenuItem4,
            this.modificarToolStripMenuItem4,
            this.borrarToolStripMenuItem4,
            this.mostrarDDLToolStripMenuItem4});
            this.viewsToolStripMenuItem.Name = "viewsToolStripMenuItem";
            this.viewsToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.viewsToolStripMenuItem.Text = "Views";
            // 
            // listarToolStripMenuItem4
            // 
            this.listarToolStripMenuItem4.Name = "listarToolStripMenuItem4";
            this.listarToolStripMenuItem4.Size = new System.Drawing.Size(140, 22);
            this.listarToolStripMenuItem4.Text = "Listar";
            // 
            // crearToolStripMenuItem4
            // 
            this.crearToolStripMenuItem4.Name = "crearToolStripMenuItem4";
            this.crearToolStripMenuItem4.Size = new System.Drawing.Size(140, 22);
            this.crearToolStripMenuItem4.Text = "Crear";
            // 
            // modificarToolStripMenuItem4
            // 
            this.modificarToolStripMenuItem4.Name = "modificarToolStripMenuItem4";
            this.modificarToolStripMenuItem4.Size = new System.Drawing.Size(140, 22);
            this.modificarToolStripMenuItem4.Text = "Modificar";
            // 
            // borrarToolStripMenuItem4
            // 
            this.borrarToolStripMenuItem4.Name = "borrarToolStripMenuItem4";
            this.borrarToolStripMenuItem4.Size = new System.Drawing.Size(140, 22);
            this.borrarToolStripMenuItem4.Text = "Borrar";
            // 
            // mostrarDDLToolStripMenuItem4
            // 
            this.mostrarDDLToolStripMenuItem4.Name = "mostrarDDLToolStripMenuItem4";
            this.mostrarDDLToolStripMenuItem4.Size = new System.Drawing.Size(140, 22);
            this.mostrarDDLToolStripMenuItem4.Text = "Mostrar DDL";
            // 
            // BorrarTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.borrarBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabName);
            this.Controls.Add(this.groupBox1);
            this.Name = "BorrarTablas";
            this.Text = "Gestor";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox tabName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button borrarBtn;
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
        private System.Windows.Forms.ToolStripMenuItem mostrarDDLToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem triggersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mostrarDDLToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem viewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mostrarDDLToolStripMenuItem4;
    }
}