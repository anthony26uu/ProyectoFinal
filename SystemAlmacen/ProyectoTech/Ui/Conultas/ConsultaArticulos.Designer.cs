﻿namespace ProyectoTech.Ui.Conultas
{
    partial class ConsultaArticulos
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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buscaText = new System.Windows.Forms.TextBox();
            this.HastadateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.desdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "SELECIONE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "HASTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "DESDE";
            // 
            // buscaText
            // 
            this.buscaText.Location = new System.Drawing.Point(264, 21);
            this.buscaText.Name = "buscaText";
            this.buscaText.Size = new System.Drawing.Size(193, 20);
            this.buscaText.TabIndex = 43;
            // 
            // HastadateTimePicker1
            // 
            this.HastadateTimePicker1.CustomFormat = "yyy/MM/dd";
            this.HastadateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker1.Location = new System.Drawing.Point(254, 70);
            this.HastadateTimePicker1.Name = "HastadateTimePicker1";
            this.HastadateTimePicker1.Size = new System.Drawing.Size(108, 20);
            this.HastadateTimePicker1.TabIndex = 41;
            // 
            // desdeDateTimePicker
            // 
            this.desdeDateTimePicker.CustomFormat = "yyy/MM/dd";
            this.desdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.desdeDateTimePicker.Location = new System.Drawing.Point(64, 68);
            this.desdeDateTimePicker.Name = "desdeDateTimePicker";
            this.desdeDateTimePicker.Size = new System.Drawing.Size(104, 20);
            this.desdeDateTimePicker.TabIndex = 40;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(841, 215);
            this.dataGridView1.TabIndex = 39;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(90, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 21);
            this.comboBox1.TabIndex = 49;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ConsultaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 366);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscaText);
            this.Controls.Add(this.HastadateTimePicker1);
            this.Controls.Add(this.desdeDateTimePicker);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsultaArticulos";
            this.Text = "Consulta Articulos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsultaArticulos_FormClosed);
            this.Load += new System.EventHandler(this.ConsultaArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox buscaText;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker1;
        private System.Windows.Forms.DateTimePicker desdeDateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}