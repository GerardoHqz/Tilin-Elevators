
namespace Elevators_Tilin.View
{
    partial class FrmMaintenance
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
            this.dtpMaintain = new System.Windows.Forms.DateTimePicker();
            this.lbl4 = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtEquipNumber = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Location = new System.Drawing.Point(147, 496);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(176, 61);
            this.btnRegister.TabIndex = 19;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // dtpMaintain
            // 
            this.dtpMaintain.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpMaintain.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMaintain.Location = new System.Drawing.Point(282, 145);
            this.dtpMaintain.Name = "dtpMaintain";
            this.dtpMaintain.Size = new System.Drawing.Size(121, 32);
            this.dtpMaintain.TabIndex = 14;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.White;
            this.lbl4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl4.Location = new System.Drawing.Point(49, 153);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(227, 22);
            this.lbl4.TabIndex = 13;
            this.lbl4.Text = "Fecha del mantenimiento:";
            // 
            // cmbState
            // 
            this.cmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbState.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbState.Location = new System.Drawing.Point(648, 47);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(149, 33);
            this.cmbState.TabIndex = 18;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.White;
            this.lbl1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(49, 55);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(176, 22);
            this.lbl1.TabIndex = 11;
            this.lbl1.Text = "Numero del equipo:";
            // 
            // txtEquipNumber
            // 
            this.txtEquipNumber.AcceptsTab = true;
            this.txtEquipNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEquipNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEquipNumber.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEquipNumber.Location = new System.Drawing.Point(234, 53);
            this.txtEquipNumber.Name = "txtEquipNumber";
            this.txtEquipNumber.Size = new System.Drawing.Size(149, 32);
            this.txtEquipNumber.TabIndex = 9;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.White;
            this.lbl3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl3.Location = new System.Drawing.Point(49, 245);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(338, 22);
            this.lbl3.TabIndex = 15;
            this.lbl3.Text = "Descripción de la reparacíon realizada:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl2.Location = new System.Drawing.Point(473, 53);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(169, 22);
            this.lbl2.TabIndex = 12;
            this.lbl2.Text = "Estado del equipo:";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.Location = new System.Drawing.Point(49, 287);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(389, 131);
            this.txtDescription.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(452, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre del técnico:";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(638, 140);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(278, 32);
            this.txtName.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Elevators_Tilin.Properties.Resources.imgMantenimiento;
            this.pictureBox1.Location = new System.Drawing.Point(565, 253);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 304);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 632);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dtpMaintain);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtEquipNumber);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Name = "FrmMaintenance";
            this.Text = "FrmMaintenance";
            this.Load += new System.EventHandler(this.FrmMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.DateTimePicker dtpMaintain;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtEquipNumber;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}