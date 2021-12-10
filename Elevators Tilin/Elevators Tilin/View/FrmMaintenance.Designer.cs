
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.dtpMaintain = new System.Windows.Forms.DateTimePicker();
            this.lbl4 = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEquipNumber = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.dtpMaintain);
            this.panel1.Controls.Add(this.lbl4);
            this.panel1.Controls.Add(this.cmbState);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtEquipNumber);
            this.panel1.Controls.Add(this.lbl3);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.lbl5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 11;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Location = new System.Drawing.Point(618, 360);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(128, 56);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // dtpMaintain
            // 
            this.dtpMaintain.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMaintain.Location = new System.Drawing.Point(236, 173);
            this.dtpMaintain.Name = "dtpMaintain";
            this.dtpMaintain.Size = new System.Drawing.Size(121, 27);
            this.dtpMaintain.TabIndex = 3;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl4.Location = new System.Drawing.Point(50, 175);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(180, 20);
            this.lbl4.TabIndex = 2;
            this.lbl4.Text = "Fecha del mantenimiento:";
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbState.Location = new System.Drawing.Point(236, 107);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(121, 28);
            this.cmbState.TabIndex = 7;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl1.Location = new System.Drawing.Point(50, 46);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(142, 20);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Numero del equipo:";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(262, 239);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(484, 27);
            this.txtName.TabIndex = 6;
            // 
            // txtEquipNumber
            // 
            this.txtEquipNumber.AcceptsTab = true;
            this.txtEquipNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEquipNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEquipNumber.Location = new System.Drawing.Point(236, 44);
            this.txtEquipNumber.Name = "txtEquipNumber";
            this.txtEquipNumber.Size = new System.Drawing.Size(121, 27);
            this.txtEquipNumber.TabIndex = 0;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl3.Location = new System.Drawing.Point(425, 46);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(267, 20);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "Descripción de la reparacíon realizada:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(50, 110);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(133, 20);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Estado del equipo:";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Location = new System.Drawing.Point(425, 69);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(321, 131);
            this.txtDescription.TabIndex = 5;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(50, 239);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(206, 20);
            this.lbl5.TabIndex = 0;
            this.lbl5.Text = "Mantenimiento realizado por:";
            // 
            // FrmMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMaintenance";
            this.Text = "FrmMaintenance";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.DateTimePicker dtpMaintain;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEquipNumber;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lbl5;
    }
}