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
            this.btnRegister = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(88, 70);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(131, 17);
            this.lbl1.TabIndex = 11;
            this.lbl1.Text = "Numero de equipo:";
            // 
            // txtNumberRegister
            // 
            this.txtNumberRegister.AcceptsTab = true;
            this.txtNumberRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumberRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumberRegister.Location = new System.Drawing.Point(244, 70);
            this.txtNumberRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumberRegister.Name = "txtNumberRegister";
            this.txtNumberRegister.Size = new System.Drawing.Size(192, 23);
            this.txtNumberRegister.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(88, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Numero de niveles:";
            // 
            // txtLevels
            // 
            this.txtLevels.AcceptsTab = true;
            this.txtLevels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLevels.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLevels.Location = new System.Drawing.Point(244, 243);
            this.txtLevels.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLevels.Name = "txtLevels";
            this.txtLevels.Size = new System.Drawing.Size(107, 23);
            this.txtLevels.TabIndex = 12;
            this.txtLevels.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLevels_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(155, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Velocidad:";
            // 
            // txtSpeed
            // 
            this.txtSpeed.AcceptsTab = true;
            this.txtSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpeed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSpeed.Location = new System.Drawing.Point(244, 297);
            this.txtSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(105, 23);
            this.txtSpeed.TabIndex = 14;
            this.txtSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSpeed_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(176, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Voltaje:";
            // 
            // txtVoltage
            // 
            this.txtVoltage.AcceptsTab = true;
            this.txtVoltage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVoltage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVoltage.Location = new System.Drawing.Point(244, 352);
            this.txtVoltage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVoltage.Name = "txtVoltage";
            this.txtVoltage.Size = new System.Drawing.Size(105, 23);
            this.txtVoltage.TabIndex = 16;
            this.txtVoltage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVoltage_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(156, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Dirección:";
            // 
            // txtDirection
            // 
            this.txtDirection.AcceptsTab = true;
            this.txtDirection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDirection.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDirection.Location = new System.Drawing.Point(244, 194);
            this.txtDirection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDirection.Name = "txtDirection";
            this.txtDirection.Size = new System.Drawing.Size(284, 23);
            this.txtDirection.TabIndex = 18;
            // 
            // dtpStartcontract
            // 
            this.dtpStartcontract.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartcontract.Location = new System.Drawing.Point(785, 68);
            this.dtpStartcontract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStartcontract.Name = "dtpStartcontract";
            this.dtpStartcontract.Size = new System.Drawing.Size(106, 23);
            this.dtpStartcontract.TabIndex = 21;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl4.Location = new System.Drawing.Point(567, 70);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(187, 17);
            this.lbl4.TabIndex = 20;
            this.lbl4.Text = "Fecha de inicio de contrato:";
            // 
            // dtpFinishcontract
            // 
            this.dtpFinishcontract.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinishcontract.Location = new System.Drawing.Point(785, 130);
            this.dtpFinishcontract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFinishcontract.Name = "dtpFinishcontract";
            this.dtpFinishcontract.Size = new System.Drawing.Size(106, 23);
            this.dtpFinishcontract.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(587, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fecha de fin de contrato:";
            // 
            // btnRegister
            // 
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Location = new System.Drawing.Point(66, 450);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(195, 64);
            this.btnRegister.TabIndex = 24;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tilin_Elevators.Properties.Resources.imgRegistro;
            this.pictureBox1.Location = new System.Drawing.Point(651, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 277);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(354, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Voltios";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(354, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "m/s";
            // 
            // txtBrand
            // 
            this.txtBrand.AcceptsTab = true;
            this.txtBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBrand.Location = new System.Drawing.Point(244, 130);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(192, 23);
            this.txtBrand.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(178, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Marca:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(333, 450);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(195, 64);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 558);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dtpFinishcontract);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpStartcontract);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtDirection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVoltage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLevels);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtNumberRegister);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmRegister";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label8;
        private Button btnUpdate;
    }
}