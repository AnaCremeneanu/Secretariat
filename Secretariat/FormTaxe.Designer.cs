namespace Secretariat
{
    partial class FormTaxe
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
            this.groupBoxTaxe = new System.Windows.Forms.GroupBox();
            this.labelTaxe2 = new System.Windows.Forms.Label();
            this.comboBoxTaxeDomeniu = new System.Windows.Forms.ComboBox();
            this.labelTaxe = new System.Windows.Forms.Label();
            this.btnCautaTaxe = new System.Windows.Forms.Button();
            this.comboBoxTaxeFacultate = new System.Windows.Forms.ComboBox();
            this.TaxeDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBoxTaxe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaxeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTaxe
            // 
            this.groupBoxTaxe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTaxe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.groupBoxTaxe.Controls.Add(this.labelTaxe2);
            this.groupBoxTaxe.Controls.Add(this.comboBoxTaxeDomeniu);
            this.groupBoxTaxe.Controls.Add(this.labelTaxe);
            this.groupBoxTaxe.Controls.Add(this.btnCautaTaxe);
            this.groupBoxTaxe.Controls.Add(this.comboBoxTaxeFacultate);
            this.groupBoxTaxe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxTaxe.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTaxe.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTaxe.Name = "groupBoxTaxe";
            this.groupBoxTaxe.Size = new System.Drawing.Size(977, 80);
            this.groupBoxTaxe.TabIndex = 16;
            this.groupBoxTaxe.TabStop = false;
            this.groupBoxTaxe.Text = "Afisati taxele aplicate domeniului:";
            // 
            // labelTaxe2
            // 
            this.labelTaxe2.AutoSize = true;
            this.labelTaxe2.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaxe2.Location = new System.Drawing.Point(394, 37);
            this.labelTaxe2.Name = "labelTaxe2";
            this.labelTaxe2.Size = new System.Drawing.Size(84, 21);
            this.labelTaxe2.TabIndex = 22;
            this.labelTaxe2.Text = "Domeniu:";
            // 
            // comboBoxTaxeDomeniu
            // 
            this.comboBoxTaxeDomeniu.FormattingEnabled = true;
            this.comboBoxTaxeDomeniu.Location = new System.Drawing.Point(490, 31);
            this.comboBoxTaxeDomeniu.Name = "comboBoxTaxeDomeniu";
            this.comboBoxTaxeDomeniu.Size = new System.Drawing.Size(260, 32);
            this.comboBoxTaxeDomeniu.TabIndex = 21;
            // 
            // labelTaxe
            // 
            this.labelTaxe.AutoSize = true;
            this.labelTaxe.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaxe.Location = new System.Drawing.Point(9, 37);
            this.labelTaxe.Name = "labelTaxe";
            this.labelTaxe.Size = new System.Drawing.Size(81, 21);
            this.labelTaxe.TabIndex = 20;
            this.labelTaxe.Text = "Facultate:";
            // 
            // btnCautaTaxe
            // 
            this.btnCautaTaxe.BackColor = System.Drawing.Color.MintCream;
            this.btnCautaTaxe.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnCautaTaxe.FlatAppearance.BorderSize = 0;
            this.btnCautaTaxe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCautaTaxe.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCautaTaxe.Image = global::Secretariat.Properties.Resources.search_icon;
            this.btnCautaTaxe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCautaTaxe.Location = new System.Drawing.Point(778, 27);
            this.btnCautaTaxe.Name = "btnCautaTaxe";
            this.btnCautaTaxe.Size = new System.Drawing.Size(110, 41);
            this.btnCautaTaxe.TabIndex = 19;
            this.btnCautaTaxe.Text = "Cauta ";
            this.btnCautaTaxe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCautaTaxe.UseVisualStyleBackColor = false;
            // 
            // comboBoxTaxeFacultate
            // 
            this.comboBoxTaxeFacultate.FormattingEnabled = true;
            this.comboBoxTaxeFacultate.Location = new System.Drawing.Point(102, 31);
            this.comboBoxTaxeFacultate.Name = "comboBoxTaxeFacultate";
            this.comboBoxTaxeFacultate.Size = new System.Drawing.Size(260, 32);
            this.comboBoxTaxeFacultate.TabIndex = 18;
            // 
            // TaxeDataGridView
            // 
            this.TaxeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaxeDataGridView.BackgroundColor = System.Drawing.Color.Snow;
            this.TaxeDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TaxeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TaxeDataGridView.ColumnHeadersHeight = 35;
            this.TaxeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TaxeDataGridView.EnableHeadersVisualStyles = false;
            this.TaxeDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.TaxeDataGridView.Location = new System.Drawing.Point(3, 89);
            this.TaxeDataGridView.Name = "TaxeDataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TaxeDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TaxeDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.TaxeDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.TaxeDataGridView.RowTemplate.Height = 24;
            this.TaxeDataGridView.Size = new System.Drawing.Size(977, 603);
            this.TaxeDataGridView.TabIndex = 15;
            // 
            // FormTaxe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(983, 694);
            this.Controls.Add(this.groupBoxTaxe);
            this.Controls.Add(this.TaxeDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTaxe";
            this.Text = "FormTaxe";
            this.Load += new System.EventHandler(this.FormTaxe_Load);
            this.groupBoxTaxe.ResumeLayout(false);
            this.groupBoxTaxe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaxeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxTaxe;
        private System.Windows.Forms.Label labelTaxe;
        private System.Windows.Forms.Button btnCautaTaxe;
        private System.Windows.Forms.ComboBox comboBoxTaxeFacultate;
        private System.Windows.Forms.DataGridView TaxeDataGridView;
        private System.Windows.Forms.Label labelTaxe2;
        private System.Windows.Forms.ComboBox comboBoxTaxeDomeniu;
    }
}