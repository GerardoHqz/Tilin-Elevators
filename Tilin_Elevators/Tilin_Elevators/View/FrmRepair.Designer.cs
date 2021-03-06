namespace Elevators_Tilin.View
{
    partial class FrmRepair
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.dtpRepair = new System.Windows.Forms.DateTimePicker();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEquipNumber = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.cmbParts = new System.Windows.Forms.ComboBox();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5004 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtRegister = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Location = new System.Drawing.Point(647, 475);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(150, 63);
            this.btnRegister.TabIndex = 21;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRepair_Click);
            // 
            // dtpRepair
            // 
            this.dtpRepair.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRepair.Location = new System.Drawing.Point(256, 195);
            this.dtpRepair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpRepair.Name = "dtpRepair";
            this.dtpRepair.Size = new System.Drawing.Size(106, 23);
            this.dtpRepair.TabIndex = 16;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.BackColor = System.Drawing.Color.White;
            this.lbl6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl6.Location = new System.Drawing.Point(77, 293);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(159, 17);
            this.lbl6.TabIndex = 14;
            this.lbl6.Text = "Repuestos necesarios:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.White;
            this.lbl4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl4.Location = new System.Drawing.Point(74, 200);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(161, 17);
            this.lbl4.TabIndex = 15;
            this.lbl4.Text = "Fecha de la reparación:";
            // 
            // cmbState
            // 
            this.cmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbState.Location = new System.Drawing.Point(256, 153);
            this.cmbState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(106, 23);
            this.cmbState.TabIndex = 20;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.White;
            this.lbl1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(94, 106);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(138, 17);
            this.lbl1.TabIndex = 12;
            this.lbl1.Text = "N° de Equipo/Placa:";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(256, 247);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(302, 23);
            this.txtName.TabIndex = 19;
            // 
            // txtEquipNumber
            // 
            this.txtEquipNumber.AcceptsTab = true;
            this.txtEquipNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEquipNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEquipNumber.Location = new System.Drawing.Point(256, 105);
            this.txtEquipNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEquipNumber.Name = "txtEquipNumber";
            this.txtEquipNumber.Size = new System.Drawing.Size(106, 23);
            this.txtEquipNumber.TabIndex = 10;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.White;
            this.lbl3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl3.Location = new System.Drawing.Point(626, 76);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(249, 17);
            this.lbl3.TabIndex = 17;
            this.lbl3.Text = "Descripción de la actividad realizada:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl2.Location = new System.Drawing.Point(108, 156);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(128, 17);
            this.lbl2.TabIndex = 13;
            this.lbl2.Text = "Estado del equipo:";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Location = new System.Drawing.Point(626, 105);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(362, 111);
            this.txtDescription.TabIndex = 18;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl5.Location = new System.Drawing.Point(101, 247);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(138, 17);
            this.lbl5.TabIndex = 11;
            this.lbl5.Text = "Nombre del técnico:";
            // 
            // cmbParts
            // 
            this.cmbParts.FormattingEnabled = true;
            this.cmbParts.Location = new System.Drawing.Point(256, 287);
            this.cmbParts.Name = "cmbParts";
            this.cmbParts.Size = new System.Drawing.Size(302, 23);
            this.cmbParts.TabIndex = 22;
            // 
            // dgvParts
            // 
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColCant});
            this.dgvParts.Location = new System.Drawing.Point(74, 381);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.RowHeadersWidth = 51;
            this.dgvParts.RowTemplate.Height = 25;
            this.dgvParts.Size = new System.Drawing.Size(522, 157);
            this.dgvParts.TabIndex = 23;
            // 
            // ColName
            // 
            this.ColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColName.HeaderText = "Nombre";
            this.ColName.MinimumWidth = 6;
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // ColCant
            // 
            this.ColCant.HeaderText = "Cantidad";
            this.ColCant.MinimumWidth = 6;
            this.ColCant.Name = "ColCant";
            this.ColCant.Width = 156;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tilin_Elevators.Properties.Resources.imgReparacion;
            this.pictureBox1.Location = new System.Drawing.Point(709, 247);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Location = new System.Drawing.Point(256, 329);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(106, 23);
            this.txtQuantity.TabIndex = 25;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(172, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cantidad:";
            // 
            // label5004
            // 
            this.label5004.AutoSize = true;
            this.label5004.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5004.Location = new System.Drawing.Point(127, 58);
            this.label5004.Name = "label5004";
            this.label5004.Size = new System.Drawing.Size(106, 17);
            this.label5004.TabIndex = 13;
            this.label5004.Text = "Tipo de equipo:";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Elevador",
            "Vehículo"});
            this.cmbType.Location = new System.Drawing.Point(256, 57);
            this.cmbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(106, 23);
            this.cmbType.TabIndex = 20;
            // 
            // txtRegister
            // 
            this.txtRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegister.Location = new System.Drawing.Point(256, 19);
            this.txtRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegister.Name = "txtRegister";
            this.txtRegister.Size = new System.Drawing.Size(106, 23);
            this.txtRegister.TabIndex = 29;
            this.txtRegister.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegister_KeyPress);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(836, 474);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 64);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(138, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "N° de reporte:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Tilin_Elevators.Properties.Resources.btnAddFn;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(386, 318);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 43);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 558);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtRegister);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.cmbParts);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dtpRepair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEquipNumber);
            this.Controls.Add(this.label5004);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lbl5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmRepair";
            this.Text = "FrmRepair";
            this.Load += new System.EventHandler(this.FrmRepair_Load);
            this.Click += new System.EventHandler(this.btnAdd_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.DateTimePicker dtpRepair;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEquipNumber;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.ComboBox cmbParts;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5004;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCant;
        private System.Windows.Forms.TextBox txtRegister;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private PictureBox pictureBox2;
    }
}