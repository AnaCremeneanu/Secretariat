namespace Secretariat
{
    partial class FormFacultati
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
            this.groupBoxFacultate2 = new System.Windows.Forms.GroupBox();
            this.btnCautaFacultateNume = new System.Windows.Forms.Button();
            this.txtNumeFacultate = new System.Windows.Forms.TextBox();
            this.labelFacultate2 = new System.Windows.Forms.Label();
            this.groupBoxFacultate = new System.Windows.Forms.GroupBox();
            this.labelFacultate = new System.Windows.Forms.Label();
            this.comboBoxOraseFacultate = new System.Windows.Forms.ComboBox();
            this.FacultateDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBoxFacultate2.SuspendLayout();
            this.groupBoxFacultate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacultateDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFacultate2
            // 
            this.groupBoxFacultate2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFacultate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.groupBoxFacultate2.Controls.Add(this.btnCautaFacultateNume);
            this.groupBoxFacultate2.Controls.Add(this.txtNumeFacultate);
            this.groupBoxFacultate2.Controls.Add(this.labelFacultate2);
            this.groupBoxFacultate2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxFacultate2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFacultate2.Location = new System.Drawing.Point(501, 3);
            this.groupBoxFacultate2.Name = "groupBoxFacultate2";
            this.groupBoxFacultate2.Size = new System.Drawing.Size(469, 129);
            this.groupBoxFacultate2.TabIndex = 23;
            this.groupBoxFacultate2.TabStop = false;
            this.groupBoxFacultate2.Text = "Cauta facultate:";
            // 
            // btnCautaFacultateNume
            // 
            this.btnCautaFacultateNume.BackColor = System.Drawing.Color.MintCream;
            this.btnCautaFacultateNume.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnCautaFacultateNume.FlatAppearance.BorderSize = 0;
            this.btnCautaFacultateNume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCautaFacultateNume.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCautaFacultateNume.Image = global::Secretariat.Properties.Resources.search_icon;
            this.btnCautaFacultateNume.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCautaFacultateNume.Location = new System.Drawing.Point(12, 79);
            this.btnCautaFacultateNume.Name = "btnCautaFacultateNume";
            this.btnCautaFacultateNume.Size = new System.Drawing.Size(110, 41);
            this.btnCautaFacultateNume.TabIndex = 20;
            this.btnCautaFacultateNume.Text = "Cauta ";
            this.btnCautaFacultateNume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCautaFacultateNume.UseVisualStyleBackColor = false;
            this.btnCautaFacultateNume.Click += new System.EventHandler(this.btnCautaFacultateNume_Click);
            // 
            // txtNumeFacultate
            // 
            this.txtNumeFacultate.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeFacultate.Location = new System.Drawing.Point(95, 31);
            this.txtNumeFacultate.Name = "txtNumeFacultate";
            this.txtNumeFacultate.Size = new System.Drawing.Size(260, 28);
            this.txtNumeFacultate.TabIndex = 0;
            // 
            // labelFacultate2
            // 
            this.labelFacultate2.AutoSize = true;
            this.labelFacultate2.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacultate2.Location = new System.Drawing.Point(8, 35);
            this.labelFacultate2.Name = "labelFacultate2";
            this.labelFacultate2.Size = new System.Drawing.Size(60, 21);
            this.labelFacultate2.TabIndex = 5;
            this.labelFacultate2.Text = "Nume:";
            // 
            // groupBoxFacultate
            // 
            this.groupBoxFacultate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFacultate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.groupBoxFacultate.Controls.Add(this.labelFacultate);
            this.groupBoxFacultate.Controls.Add(this.comboBoxOraseFacultate);
            this.groupBoxFacultate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxFacultate.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFacultate.Location = new System.Drawing.Point(12, 3);
            this.groupBoxFacultate.Name = "groupBoxFacultate";
            this.groupBoxFacultate.Size = new System.Drawing.Size(469, 129);
            this.groupBoxFacultate.TabIndex = 22;
            this.groupBoxFacultate.TabStop = false;
            this.groupBoxFacultate.Text = "Afisati doar facultatile din:";
            // 
            // labelFacultate
            // 
            this.labelFacultate.AutoSize = true;
            this.labelFacultate.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacultate.Location = new System.Drawing.Point(9, 37);
            this.labelFacultate.Name = "labelFacultate";
            this.labelFacultate.Size = new System.Drawing.Size(77, 21);
            this.labelFacultate.TabIndex = 20;
            this.labelFacultate.Text = "Selectati:";
            // 
            // comboBoxOraseFacultate
            // 
            this.comboBoxOraseFacultate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOraseFacultate.FormattingEnabled = true;
            this.comboBoxOraseFacultate.Location = new System.Drawing.Point(95, 31);
            this.comboBoxOraseFacultate.Name = "comboBoxOraseFacultate";
            this.comboBoxOraseFacultate.Size = new System.Drawing.Size(260, 32);
            this.comboBoxOraseFacultate.TabIndex = 18;
            this.comboBoxOraseFacultate.SelectedIndexChanged += new System.EventHandler(this.comboBoxOraseFacultate_SelectedIndexChanged);
            // 
            // FacultateDataGridView
            // 
            this.FacultateDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FacultateDataGridView.BackgroundColor = System.Drawing.Color.Snow;
            this.FacultateDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FacultateDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FacultateDataGridView.ColumnHeadersHeight = 35;
            this.FacultateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.FacultateDataGridView.EnableHeadersVisualStyles = false;
            this.FacultateDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.FacultateDataGridView.Location = new System.Drawing.Point(3, 138);
            this.FacultateDataGridView.Name = "FacultateDataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FacultateDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.FacultateDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.FacultateDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.FacultateDataGridView.RowTemplate.Height = 24;
            this.FacultateDataGridView.Size = new System.Drawing.Size(977, 554);
            this.FacultateDataGridView.TabIndex = 21;
            // 
            // FormFacultati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(983, 694);
            this.Controls.Add(this.groupBoxFacultate2);
            this.Controls.Add(this.groupBoxFacultate);
            this.Controls.Add(this.FacultateDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFacultati";
            this.Text = "FormFacultati";
            this.Load += new System.EventHandler(this.FormFacultati_Load);
            this.groupBoxFacultate2.ResumeLayout(false);
            this.groupBoxFacultate2.PerformLayout();
            this.groupBoxFacultate.ResumeLayout(false);
            this.groupBoxFacultate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacultateDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFacultate2;
        private System.Windows.Forms.Button btnCautaFacultateNume;
        private System.Windows.Forms.TextBox txtNumeFacultate;
        private System.Windows.Forms.Label labelFacultate2;
        private System.Windows.Forms.GroupBox groupBoxFacultate;
        private System.Windows.Forms.Label labelFacultate;
        private System.Windows.Forms.ComboBox comboBoxOraseFacultate;
        private System.Windows.Forms.DataGridView FacultateDataGridView;
    }
}