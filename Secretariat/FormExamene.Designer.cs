namespace Secretariat
{
    partial class FormExamene
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
            this.groupBoxExamene = new System.Windows.Forms.GroupBox();
            this.btnRefreshExamen = new System.Windows.Forms.Button();
            this.comboBoxNrExamen = new System.Windows.Forms.ComboBox();
            this.comboBoxCursExamen = new System.Windows.Forms.ComboBox();
            this.labelSelectati = new System.Windows.Forms.Label();
            this.btnCautaExamen = new System.Windows.Forms.Button();
            this.comboBoxAnExamen = new System.Windows.Forms.ComboBox();
            this.ExameneDataGridView = new System.Windows.Forms.DataGridView();
            this.labelExamene = new System.Windows.Forms.Label();
            this.groupBoxExamene.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExameneDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxExamene
            // 
            this.groupBoxExamene.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxExamene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.groupBoxExamene.Controls.Add(this.btnRefreshExamen);
            this.groupBoxExamene.Controls.Add(this.comboBoxNrExamen);
            this.groupBoxExamene.Controls.Add(this.comboBoxCursExamen);
            this.groupBoxExamene.Controls.Add(this.labelSelectati);
            this.groupBoxExamene.Controls.Add(this.btnCautaExamen);
            this.groupBoxExamene.Controls.Add(this.comboBoxAnExamen);
            this.groupBoxExamene.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxExamene.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxExamene.Location = new System.Drawing.Point(3, 3);
            this.groupBoxExamene.Name = "groupBoxExamene";
            this.groupBoxExamene.Size = new System.Drawing.Size(977, 80);
            this.groupBoxExamene.TabIndex = 16;
            this.groupBoxExamene.TabStop = false;
            this.groupBoxExamene.Text = "Introduceti notele studentilor (selectati anul, materia si examenul):";
            // 
            // btnRefreshExamen
            // 
            this.btnRefreshExamen.BackColor = System.Drawing.Color.MintCream;
            this.btnRefreshExamen.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnRefreshExamen.FlatAppearance.BorderSize = 0;
            this.btnRefreshExamen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshExamen.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshExamen.Image = global::Secretariat.Properties.Resources.search_icon;
            this.btnRefreshExamen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshExamen.Location = new System.Drawing.Point(841, 26);
            this.btnRefreshExamen.Name = "btnRefreshExamen";
            this.btnRefreshExamen.Size = new System.Drawing.Size(123, 41);
            this.btnRefreshExamen.TabIndex = 20;
            this.btnRefreshExamen.Text = "Refresh";
            this.btnRefreshExamen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefreshExamen.UseVisualStyleBackColor = false;
            this.btnRefreshExamen.Click += new System.EventHandler(this.btnRefreshExamen_Click);
            // 
            // comboBoxNrExamen
            // 
            this.comboBoxNrExamen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNrExamen.FormattingEnabled = true;
            this.comboBoxNrExamen.Location = new System.Drawing.Point(510, 31);
            this.comboBoxNrExamen.Name = "comboBoxNrExamen";
            this.comboBoxNrExamen.Size = new System.Drawing.Size(185, 30);
            this.comboBoxNrExamen.TabIndex = 22;
            // 
            // comboBoxCursExamen
            // 
            this.comboBoxCursExamen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCursExamen.FormattingEnabled = true;
            this.comboBoxCursExamen.Location = new System.Drawing.Point(307, 31);
            this.comboBoxCursExamen.Name = "comboBoxCursExamen";
            this.comboBoxCursExamen.Size = new System.Drawing.Size(185, 30);
            this.comboBoxCursExamen.TabIndex = 21;
            this.comboBoxCursExamen.SelectedIndexChanged += new System.EventHandler(this.comboBoxCursExamen_SelectedIndexChanged);
            // 
            // labelSelectati
            // 
            this.labelSelectati.AutoSize = true;
            this.labelSelectati.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectati.Location = new System.Drawing.Point(9, 36);
            this.labelSelectati.Name = "labelSelectati";
            this.labelSelectati.Size = new System.Drawing.Size(77, 21);
            this.labelSelectati.TabIndex = 20;
            this.labelSelectati.Text = "Selectati:";
            // 
            // btnCautaExamen
            // 
            this.btnCautaExamen.BackColor = System.Drawing.Color.MintCream;
            this.btnCautaExamen.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnCautaExamen.FlatAppearance.BorderSize = 0;
            this.btnCautaExamen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCautaExamen.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCautaExamen.Image = global::Secretariat.Properties.Resources.search_icon;
            this.btnCautaExamen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCautaExamen.Location = new System.Drawing.Point(713, 26);
            this.btnCautaExamen.Name = "btnCautaExamen";
            this.btnCautaExamen.Size = new System.Drawing.Size(110, 41);
            this.btnCautaExamen.TabIndex = 19;
            this.btnCautaExamen.Text = "Cauta ";
            this.btnCautaExamen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCautaExamen.UseVisualStyleBackColor = false;
            this.btnCautaExamen.Click += new System.EventHandler(this.btnCautaExamen_Click);
            // 
            // comboBoxAnExamen
            // 
            this.comboBoxAnExamen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnExamen.FormattingEnabled = true;
            this.comboBoxAnExamen.Location = new System.Drawing.Point(104, 31);
            this.comboBoxAnExamen.Name = "comboBoxAnExamen";
            this.comboBoxAnExamen.Size = new System.Drawing.Size(185, 30);
            this.comboBoxAnExamen.TabIndex = 18;
            this.comboBoxAnExamen.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnExamen_SelectedIndexChanged);
            // 
            // ExameneDataGridView
            // 
            this.ExameneDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExameneDataGridView.BackgroundColor = System.Drawing.Color.Snow;
            this.ExameneDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExameneDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ExameneDataGridView.ColumnHeadersHeight = 35;
            this.ExameneDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ExameneDataGridView.EnableHeadersVisualStyles = false;
            this.ExameneDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ExameneDataGridView.Location = new System.Drawing.Point(3, 110);
            this.ExameneDataGridView.Name = "ExameneDataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExameneDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ExameneDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.ExameneDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ExameneDataGridView.RowTemplate.Height = 24;
            this.ExameneDataGridView.Size = new System.Drawing.Size(977, 582);
            this.ExameneDataGridView.TabIndex = 15;
            // 
            // labelExamene
            // 
            this.labelExamene.AutoSize = true;
            this.labelExamene.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExamene.Location = new System.Drawing.Point(12, 86);
            this.labelExamene.Name = "labelExamene";
            this.labelExamene.Size = new System.Drawing.Size(679, 21);
            this.labelExamene.TabIndex = 21;
            this.labelExamene.Text = "Selectati celula din coloana \"Note\" a studentului si introduceti nota, apoi apasa" +
    "ti \"Refresh\".";
            // 
            // FormExamene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(983, 694);
            this.Controls.Add(this.labelExamene);
            this.Controls.Add(this.groupBoxExamene);
            this.Controls.Add(this.ExameneDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormExamene";
            this.Text = "FormExamene";
            this.Load += new System.EventHandler(this.FormExamene_Load);
            this.groupBoxExamene.ResumeLayout(false);
            this.groupBoxExamene.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExameneDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxExamene;
        private System.Windows.Forms.ComboBox comboBoxCursExamen;
        private System.Windows.Forms.Label labelSelectati;
        private System.Windows.Forms.Button btnCautaExamen;
        private System.Windows.Forms.ComboBox comboBoxAnExamen;
        private System.Windows.Forms.DataGridView ExameneDataGridView;
        private System.Windows.Forms.ComboBox comboBoxNrExamen;
        private System.Windows.Forms.Button btnRefreshExamen;
        private System.Windows.Forms.Label labelExamene;
    }
}