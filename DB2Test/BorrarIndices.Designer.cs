namespace DB2Test
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
            this.label2 = new System.Windows.Forms.Label();
            this.tabpk = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pkname = new System.Windows.Forms.ComboBox();
            this.dgvpk = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabfk = new System.Windows.Forms.ComboBox();
            this.fkname = new System.Windows.Forms.ComboBox();
            this.dgvfk = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabind = new System.Windows.Forms.ComboBox();
            this.indname = new System.Windows.Forms.ComboBox();
            this.dgvind = new System.Windows.Forms.DataGridView();
            this.btpk = new System.Windows.Forms.Button();
            this.btfk = new System.Windows.Forms.Button();
            this.btind = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpk)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfk)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvind)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Borrar PK";
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
            this.groupBox2.Location = new System.Drawing.Point(12, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(814, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Borrar FK";
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
            this.groupBox3.Location = new System.Drawing.Point(12, 375);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(814, 170);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Borrar Indice";
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
            // BorrarIndices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 562);
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
            this.ResumeLayout(false);

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
    }
}