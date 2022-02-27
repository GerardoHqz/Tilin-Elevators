namespace Elevators_Tilin.View
{
    partial class FrmServices
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
            this.dgvInformation = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumReport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInformation
            // 
            this.dgvInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NumReport,
            this.NumeroIdentificacion,
            this.Estado,
            this.NombreTecnico,
            this.Fecha,
            this.Descripcion});
            this.dgvInformation.Location = new System.Drawing.Point(49, 157);
            this.dgvInformation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvInformation.Name = "dgvInformation";
            this.dgvInformation.RowHeadersWidth = 51;
            this.dgvInformation.RowTemplate.Height = 25;
            this.dgvInformation.Size = new System.Drawing.Size(1070, 533);
            this.dgvInformation.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Azure;
            this.btnSearch.BackgroundImage = global::Tilin_Elevators.Properties.Resources.search3;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(760, 75);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(38, 32);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(373, 77);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(381, 27);
            this.txtName.TabIndex = 5;
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundImage = global::Tilin_Elevators.Properties.Resources.excel;
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Location = new System.Drawing.Point(888, 67);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(66, 49);
            this.btnExcel.TabIndex = 8;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Reparaciones",
            "Mantenimientos"});
            this.cmbType.Location = new System.Drawing.Point(217, 75);
            this.cmbType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(134, 28);
            this.cmbType.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "No. Placa/Serie";
            // 
            // ID
            // 
            this.ID.FillWeight = 160.4278F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // NumReport
            // 
            this.NumReport.HeaderText = "No. Reporte";
            this.NumReport.MinimumWidth = 6;
            this.NumReport.Name = "NumReport";
            this.NumReport.Width = 75;
            // 
            // NumeroIdentificacion
            // 
            this.NumeroIdentificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NumeroIdentificacion.FillWeight = 87.91444F;
            this.NumeroIdentificacion.HeaderText = "No. Identificación ";
            this.NumeroIdentificacion.MinimumWidth = 6;
            this.NumeroIdentificacion.Name = "NumeroIdentificacion";
            this.NumeroIdentificacion.Width = 146;
            // 
            // Estado
            // 
            this.Estado.FillWeight = 87.91444F;
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 90;
            // 
            // NombreTecnico
            // 
            this.NombreTecnico.FillWeight = 87.91444F;
            this.NombreTecnico.HeaderText = "Nombre Técnico ";
            this.NombreTecnico.MinimumWidth = 6;
            this.NombreTecnico.Name = "NombreTecnico";
            this.NombreTecnico.Width = 250;
            // 
            // Fecha
            // 
            this.Fecha.FillWeight = 87.91444F;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 165;
            // 
            // Descripcion
            // 
            this.Descripcion.FillWeight = 87.91444F;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 450;
            // 
            // FrmServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1169, 744);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dgvInformation);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbType);
            this.Name = "FrmServices";
            this.Text = "FrmServices";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInformation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tate;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Label label1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NumReport;
        private DataGridViewTextBoxColumn NumeroIdentificacion;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn NombreTecnico;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Descripcion;
    }
}
