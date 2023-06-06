namespace Secretariat
{
    partial class FormStudenti
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
            this.txtNumeStudent = new System.Windows.Forms.TextBox();
            this.StudentDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxStudent = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxFacultateStudent = new System.Windows.Forms.ComboBox();
            this.groupBoxStudent2 = new System.Windows.Forms.GroupBox();
            this.btnCautaStudent2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).BeginInit();
            this.groupBoxStudent.SuspendLayout();
            this.groupBoxStudent2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumeStudent
            // 
            this.txtNumeStudent.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeStudent.Location = new System.Drawing.Point(73, 28);
            this.txtNumeStudent.Name = "txtNumeStudent";
            this.txtNumeStudent.Size = new System.Drawing.Size(270, 28);
            this.txtNumeStudent.TabIndex = 0;
            // 
            // StudentDataGridView
            // 
            this.StudentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentDataGridView.BackgroundColor = System.Drawing.Color.Snow;
            this.StudentDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StudentDataGridView.ColumnHeadersHeight = 35;
            this.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StudentDataGridView.EnableHeadersVisualStyles = false;
            this.StudentDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.StudentDataGridView.Location = new System.Drawing.Point(3, 176);
            this.StudentDataGridView.Name = "StudentDataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StudentDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.StudentDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.StudentDataGridView.RowTemplate.Height = 24;
            this.StudentDataGridView.Size = new System.Drawing.Size(977, 518);
            this.StudentDataGridView.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nume:";
            // 
            // groupBoxStudent
            // 
            this.groupBoxStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.groupBoxStudent.Controls.Add(this.label3);
            this.groupBoxStudent.Controls.Add(this.comboBoxFacultateStudent);
            this.groupBoxStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxStudent.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStudent.Location = new System.Drawing.Point(3, 5);
            this.groupBoxStudent.Name = "groupBoxStudent";
            this.groupBoxStudent.Size = new System.Drawing.Size(968, 80);
            this.groupBoxStudent.TabIndex = 13;
            this.groupBoxStudent.TabStop = false;
            this.groupBoxStudent.Text = "Afisati doar studentii din:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Selectati:";
            // 
            // comboBoxFacultateStudent
            // 
            this.comboBoxFacultateStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFacultateStudent.FormattingEnabled = true;
            this.comboBoxFacultateStudent.Location = new System.Drawing.Point(95, 31);
            this.comboBoxFacultateStudent.Name = "comboBoxFacultateStudent";
            this.comboBoxFacultateStudent.Size = new System.Drawing.Size(260, 32);
            this.comboBoxFacultateStudent.TabIndex = 18;
            this.comboBoxFacultateStudent.SelectedIndexChanged += new System.EventHandler(this.comboBoxFacultateStudent_SelectedIndexChanged);
            // 
            // groupBoxStudent2
            // 
            this.groupBoxStudent2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStudent2.Controls.Add(this.btnCautaStudent2);
            this.groupBoxStudent2.Controls.Add(this.txtNumeStudent);
            this.groupBoxStudent2.Controls.Add(this.label1);
            this.groupBoxStudent2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxStudent2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStudent2.Location = new System.Drawing.Point(3, 90);
            this.groupBoxStudent2.Name = "groupBoxStudent2";
            this.groupBoxStudent2.Size = new System.Drawing.Size(977, 80);
            this.groupBoxStudent2.TabIndex = 14;
            this.groupBoxStudent2.TabStop = false;
            this.groupBoxStudent2.Text = "Cauta student:";
            // 
            // btnCautaStudent2
            // 
            this.btnCautaStudent2.BackColor = System.Drawing.Color.MintCream;
            this.btnCautaStudent2.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnCautaStudent2.FlatAppearance.BorderSize = 0;
            this.btnCautaStudent2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCautaStudent2.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCautaStudent2.Image = global::Secretariat.Properties.Resources.search_icon;
            this.btnCautaStudent2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCautaStudent2.Location = new System.Drawing.Point(386, 21);
            this.btnCautaStudent2.Name = "btnCautaStudent2";
            this.btnCautaStudent2.Size = new System.Drawing.Size(110, 41);
            this.btnCautaStudent2.TabIndex = 20;
            this.btnCautaStudent2.Text = "Cauta ";
            this.btnCautaStudent2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCautaStudent2.UseVisualStyleBackColor = false;
            this.btnCautaStudent2.Click += new System.EventHandler(this.btnCautaStudent2_Click);
            // 
            // FormStudenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(983, 694);
            this.Controls.Add(this.groupBoxStudent2);
            this.Controls.Add(this.groupBoxStudent);
            this.Controls.Add(this.StudentDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStudenti";
            this.Text = "FormStudenti";
            this.Load += new System.EventHandler(this.FormStudenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).EndInit();
            this.groupBoxStudent.ResumeLayout(false);
            this.groupBoxStudent.PerformLayout();
            this.groupBoxStudent2.ResumeLayout(false);
            this.groupBoxStudent2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeStudent;
        private System.Windows.Forms.DataGridView StudentDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxStudent;
        private System.Windows.Forms.GroupBox groupBoxStudent2;
        private System.Windows.Forms.ComboBox comboBoxFacultateStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCautaStudent2;
    }
}