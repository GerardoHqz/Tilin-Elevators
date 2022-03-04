namespace Elevators_Tilin.View
{
    partial class FrmElevatorsList
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cmbType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "No. Serie/Placa";
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundImage = global::Tilin_Elevators.Properties.Resources.excel;
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Location = new System.Drawing.Point(790, 50);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(58, 37);
            this.btnExcel.TabIndex = 20;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Azure;
            this.btnSearch.BackgroundImage = global::Tilin_Elevators.Properties.Resources.search3;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(680, 58);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(33, 24);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(341, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(334, 23);
            this.txtName.TabIndex = 17;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(56, 119);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.Size = new System.Drawing.Size(910, 398);
            this.dgv.TabIndex = 22;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Elevador",
            "Vehículo"});
            this.cmbType.Location = new System.Drawing.Point(191, 58);
            this.cmbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(112, 23);
            this.cmbType.TabIndex = 23;
            // 
            // FrmElevatorsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 558);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmElevatorsList";
            this.Text = "FrmElevatorsList";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridView dgvInformation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn InicioContrato;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cmbType;
    }
}