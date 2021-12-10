
namespace Elevators_Tilin.View
{
    partial class FrmRegister
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
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtNumberRegister = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLevels = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVoltage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDirection = new System.Windows.Forms.TextBox();
            this.dtpStartcontract = new System.Windows.Forms.DateTimePicker();
            this.lbl4 = new System.Windows.Forms.Label();
            this.dtpFinishcontract = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbType.Location = new System.Drawing.Point(300, 157);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(236, 28);
            this.cmbType.TabIndex = 9;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(172, 160);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(114, 20);
            this.lbl2.TabIndex = 8;
            this.lbl2.Text = "Tipo de Equipo:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(144, 106);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(142, 20);
            this.lbl1.TabIndex = 11;
            this.lbl1.Text = "Numero del equipo:";
            // 
            // txtNumberRegister
            // 
            this.txtNumberRegister.AcceptsTab = true;
            this.txtNumberRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumberRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumberRegister.Location = new System.Drawing.Point(300, 99);
            this.txtNumberRegister.Name = "txtNumberRegister";
            this.txtNumberRegister.Size = new System.Drawing.Size(203, 27);
            this.txtNumberRegister.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Numero de niveles:";
            // 
            // txtLevels
            // 
            this.txtLevels.AcceptsTab = true;
            this.txtLevels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLevels.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLevels.Location = new System.Drawing.Point(300, 210);
            this.txtLevels.Name = "txtLevels";
            this.txtLevels.Size = new System.Drawing.Size(121, 27);
            this.txtLevels.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Velocidad:";
            // 
            // txtSpeed
            // 
            this.txtSpeed.AcceptsTab = true;
            this.txtSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpeed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSpeed.Location = new System.Drawing.Point(300, 262);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(121, 27);
            this.txtSpeed.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Voltaje:";
            // 
            // txtVoltage
            // 
            this.txtVoltage.AcceptsTab = true;
            this.txtVoltage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVoltage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVoltage.Location = new System.Drawing.Point(300, 309);
            this.txtVoltage.Name = "txtVoltage";
            this.txtVoltage.Size = new System.Drawing.Size(121, 27);
            this.txtVoltage.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Dirección:";
            // 
            // txtDirection
            // 
            this.txtDirection.AcceptsTab = true;
            this.txtDirection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDirection.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDirection.Location = new System.Drawing.Point(300, 362);
            this.txtDirection.Name = "txtDirection";
            this.txtDirection.Size = new System.Drawing.Size(121, 27);
            this.txtDirection.TabIndex = 18;
            // 
            // dtpStartcontract
            // 
            this.dtpStartcontract.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartcontract.Location = new System.Drawing.Point(300, 420);
            this.dtpStartcontract.Name = "dtpStartcontract";
            this.dtpStartcontract.Size = new System.Drawing.Size(121, 27);
            this.dtpStartcontract.TabIndex = 21;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(94, 420);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(192, 20);
            this.lbl4.TabIndex = 20;
            this.lbl4.Text = "Fecha de inicio de contrato:";
            // 
            // dtpFinishcontract
            // 
            this.dtpFinishcontract.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinishcontract.Location = new System.Drawing.Point(300, 469);
            this.dtpFinishcontract.Name = "dtpFinishcontract";
            this.dtpFinishcontract.Size = new System.Drawing.Size(121, 27);
            this.dtpFinishcontract.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fecha de fin de contrato:";
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(965, 635);
            this.Controls.Add(this.dtpFinishcontract);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpStartcontract);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDirection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVoltage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLevels);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtNumberRegister);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lbl2);
            this.Name = "FrmRegister";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtNumberRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLevels;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVoltage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDirection;
        private System.Windows.Forms.DateTimePicker dtpStartcontract;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.DateTimePicker dtpFinishcontract;
        private System.Windows.Forms.Label label5;
    }
}