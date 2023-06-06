namespace Secretariat
{
    partial class FormPlati
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxPlati = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeStudentPlata = new System.Windows.Forms.TextBox();
            this.txtCNPStudentPlata = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPlataSuma = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlata = new System.Windows.Forms.Button();
            this.comboBoxPlataTaxa = new System.Windows.Forms.ComboBox();
            this.PlatiDataGridView = new System.Windows.Forms.DataGridView();
            this.btnCautaStudentNeplata = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCNPStudentNeplata = new System.Windows.Forms.TextBox();
            this.txtNumeStudentNeplata = new System.Windows.Forms.TextBox();
            this.groupBoxPlati2 = new System.Windows.Forms.GroupBox();
            this.groupBoxPlati.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlatiDataGridView)).BeginInit();
            this.groupBoxPlati2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPlati
            // 
            this.groupBoxPlati.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPlati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.groupBoxPlati.Controls.Add(this.label4);
            this.groupBoxPlati.Controls.Add(this.txtNumeStudentPlata);
            this.groupBoxPlati.Controls.Add(this.txtCNPStudentPlata);
            this.groupBoxPlati.Controls.Add(this.label2);
            this.groupBoxPlati.Controls.Add(this.label1);
            this.groupBoxPlati.Controls.Add(this.comboBoxPlataSuma);
            this.groupBoxPlati.Controls.Add(this.label3);
            this.groupBoxPlati.Controls.Add(this.btnPlata);
            this.groupBoxPlati.Controls.Add(this.comboBoxPlataTaxa);
            this.groupBoxPlati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxPlati.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPlati.Location = new System.Drawing.Point(3, 3);
            this.groupBoxPlati.Name = "groupBoxPlati";
            this.groupBoxPlati.Size = new System.Drawing.Size(547, 253);
            this.groupBoxPlati.TabIndex = 16;
            this.groupBoxPlati.TabStop = false;
            this.groupBoxPlati.Text = "Efectuati plata (selectati studentul, taxa si suma):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Suma: ";
            // 
            // txtNumeStudentPlata
            // 
            this.txtNumeStudentPlata.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeStudentPlata.Location = new System.Drawing.Point(95, 36);
            this.txtNumeStudentPlata.Name = "txtNumeStudentPlata";
            this.txtNumeStudentPlata.Size = new System.Drawing.Size(250, 28);
            this.txtNumeStudentPlata.TabIndex = 22;
            // 
            // txtCNPStudentPlata
            // 
            this.txtCNPStudentPlata.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNPStudentPlata.Location = new System.Drawing.Point(95, 92);
            this.txtCNPStudentPlata.Name = "txtCNPStudentPlata";
            this.txtCNPStudentPlata.Size = new System.Drawing.Size(250, 28);
            this.txtCNPStudentPlata.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "CNP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nume:";
            // 
            // comboBoxPlataSuma
            // 
            this.comboBoxPlataSuma.FormattingEnabled = true;
            this.comboBoxPlataSuma.Location = new System.Drawing.Point(95, 201);
            this.comboBoxPlataSuma.Name = "comboBoxPlataSuma";
            this.comboBoxPlataSuma.Size = new System.Drawing.Size(250, 30);
            this.comboBoxPlataSuma.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Taxa: ";
            // 
            // btnPlata
            // 
            this.btnPlata.BackColor = System.Drawing.Color.MintCream;
            this.btnPlata.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnPlata.FlatAppearance.BorderSize = 0;
            this.btnPlata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlata.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlata.Location = new System.Drawing.Point(387, 196);
            this.btnPlata.Name = "btnPlata";
            this.btnPlata.Size = new System.Drawing.Size(154, 41);
            this.btnPlata.TabIndex = 19;
            this.btnPlata.Text = "Efectuati plata";
            this.btnPlata.UseVisualStyleBackColor = false;
            // 
            // comboBoxPlataTaxa
            // 
            this.comboBoxPlataTaxa.FormattingEnabled = true;
            this.comboBoxPlataTaxa.Location = new System.Drawing.Point(95, 145);
            this.comboBoxPlataTaxa.Name = "comboBoxPlataTaxa";
            this.comboBoxPlataTaxa.Size = new System.Drawing.Size(250, 30);
            this.comboBoxPlataTaxa.TabIndex = 18;
            // 
            // PlatiDataGridView
            // 
            this.PlatiDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlatiDataGridView.BackgroundColor = System.Drawing.Color.Snow;
            this.PlatiDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PlatiDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PlatiDataGridView.ColumnHeadersHeight = 35;
            this.PlatiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.PlatiDataGridView.EnableHeadersVisualStyles = false;
            this.PlatiDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.PlatiDataGridView.Location = new System.Drawing.Point(3, 262);
            this.PlatiDataGridView.Name = "PlatiDataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PlatiDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PlatiDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.PlatiDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.PlatiDataGridView.RowTemplate.Height = 24;
            this.PlatiDataGridView.Size = new System.Drawing.Size(977, 430);
            this.PlatiDataGridView.TabIndex = 15;
            // 
            // btnCautaStudentNeplata
            // 
            this.btnCautaStudentNeplata.BackColor = System.Drawing.Color.MintCream;
            this.btnCautaStudentNeplata.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnCautaStudentNeplata.FlatAppearance.BorderSize = 0;
            this.btnCautaStudentNeplata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCautaStudentNeplata.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCautaStudentNeplata.Image = global::Secretariat.Properties.Resources.search_icon;
            this.btnCautaStudentNeplata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCautaStudentNeplata.Location = new System.Drawing.Point(12, 195);
            this.btnCautaStudentNeplata.Name = "btnCautaStudentNeplata";
            this.btnCautaStudentNeplata.Size = new System.Drawing.Size(110, 41);
            this.btnCautaStudentNeplata.TabIndex = 19;
            this.btnCautaStudentNeplata.Text = "Cauta  ";
            this.btnCautaStudentNeplata.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCautaStudentNeplata.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 24;
            this.label7.Text = "Nume:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "CNP:";
            // 
            // txtCNPStudentNeplata
            // 
            this.txtCNPStudentNeplata.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNPStudentNeplata.Location = new System.Drawing.Point(95, 92);
            this.txtCNPStudentNeplata.Name = "txtCNPStudentNeplata";
            this.txtCNPStudentNeplata.Size = new System.Drawing.Size(250, 28);
            this.txtCNPStudentNeplata.TabIndex = 23;
            // 
            // txtNumeStudentNeplata
            // 
            this.txtNumeStudentNeplata.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeStudentNeplata.Location = new System.Drawing.Point(95, 36);
            this.txtNumeStudentNeplata.Name = "txtNumeStudentNeplata";
            this.txtNumeStudentNeplata.Size = new System.Drawing.Size(250, 28);
            this.txtNumeStudentNeplata.TabIndex = 22;
            // 
            // groupBoxPlati2
            // 
            this.groupBoxPlati2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPlati2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.groupBoxPlati2.Controls.Add(this.txtNumeStudentNeplata);
            this.groupBoxPlati2.Controls.Add(this.txtCNPStudentNeplata);
            this.groupBoxPlati2.Controls.Add(this.label6);
            this.groupBoxPlati2.Controls.Add(this.label7);
            this.groupBoxPlati2.Controls.Add(this.btnCautaStudentNeplata);
            this.groupBoxPlati2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxPlati2.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPlati2.Location = new System.Drawing.Point(566, 3);
            this.groupBoxPlati2.Name = "groupBoxPlati2";
            this.groupBoxPlati2.Size = new System.Drawing.Size(414, 253);
            this.groupBoxPlati2.TabIndex = 17;
            this.groupBoxPlati2.TabStop = false;
            this.groupBoxPlati2.Text = "Afisati studentii care nu au platit taxele:";
            // 
            // FormPlati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(983, 694);
            this.Controls.Add(this.groupBoxPlati2);
            this.Controls.Add(this.groupBoxPlati);
            this.Controls.Add(this.PlatiDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPlati";
            this.Text = "FormPlati";
            this.groupBoxPlati.ResumeLayout(false);
            this.groupBoxPlati.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlatiDataGridView)).EndInit();
            this.groupBoxPlati2.ResumeLayout(false);
            this.groupBoxPlati2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxPlati;
        private System.Windows.Forms.ComboBox comboBoxPlataSuma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPlata;
        private System.Windows.Forms.ComboBox comboBoxPlataTaxa;
        private System.Windows.Forms.DataGridView PlatiDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumeStudentPlata;
        private System.Windows.Forms.TextBox txtCNPStudentPlata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCautaStudentNeplata;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCNPStudentNeplata;
        private System.Windows.Forms.TextBox txtNumeStudentNeplata;
        private System.Windows.Forms.GroupBox groupBoxPlati2;
    }
}