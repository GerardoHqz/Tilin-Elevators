namespace Elevators_Tilin.View
{
    partial class FrmVehicle
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegisterVehicle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtPlateVehicle = new System.Windows.Forms.TextBox();
            this.cmbGas = new System.Windows.Forms.ComboBox();
            this.lbl2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Elevators_Tilin.Properties.Resources.imgRegistro;
            this.pictureBox1.Location = new System.Drawing.Point(524, 82);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 423);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegisterVehicle
            // 
            this.btnRegisterVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterVehicle.Location = new System.Drawing.Point(210, 460);
            this.btnRegisterVehicle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegisterVehicle.Name = "btnRegisterVehicle";
            this.btnRegisterVehicle.Size = new System.Drawing.Size(171, 65);
            this.btnRegisterVehicle.TabIndex = 42;
            this.btnRegisterVehicle.Text = "Registrar";
            this.btnRegisterVehicle.UseVisualStyleBackColor = true;
            this.btnRegisterVehicle.Click += new System.EventHandler(this.btnRegisterVehicle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(134, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 37;
            this.label4.Text = "Marca:";
            // 
            // txtBrand
            // 
            this.txtBrand.AcceptsTab = true;
            this.txtBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBrand.Location = new System.Drawing.Point(210, 149);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(219, 27);
            this.txtBrand.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(155, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Año:";
            // 
            // txtYear
            // 
            this.txtYear.AcceptsTab = true;
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYear.Location = new System.Drawing.Point(210, 280);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(219, 27);
            this.txtYear.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(126, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "Modelo:";
            // 
            // txtModel
            // 
            this.txtModel.AcceptsTab = true;
            this.txtModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModel.Location = new System.Drawing.Point(210, 216);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(219, 27);
            this.txtModel.TabIndex = 30;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(116, 82);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(88, 22);
            this.lbl1.TabIndex = 29;
            this.lbl1.Text = "N° Placa:";
            // 
            // txtPlateVehicle
            // 
            this.txtPlateVehicle.AcceptsTab = true;
            this.txtPlateVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlateVehicle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlateVehicle.Location = new System.Drawing.Point(210, 81);
            this.txtPlateVehicle.Name = "txtPlateVehicle";
            this.txtPlateVehicle.Size = new System.Drawing.Size(219, 27);
            this.txtPlateVehicle.TabIndex = 28;
            // 
            // cmbGas
            // 
            this.cmbGas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGas.FormattingEnabled = true;
            this.cmbGas.Items.AddRange(new object[] {
            "Regular",
            "Super",
            "Diesel"});
            this.cmbGas.Location = new System.Drawing.Point(210, 343);
            this.cmbGas.Name = "cmbGas";
            this.cmbGas.Size = new System.Drawing.Size(219, 28);
            this.cmbGas.TabIndex = 27;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl2.Location = new System.Drawing.Point(19, 345);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(187, 22);
            this.lbl2.TabIndex = 26;
            this.lbl2.Text = "Tipo de combustible:";
            // 
            // FrmVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 632);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegisterVehicle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtPlateVehicle);
            this.Controls.Add(this.cmbGas);
            this.Controls.Add(this.lbl2);
            this.Name = "FrmVehicle";
            this.Text = "FrmVehicle";
            this.Load += new System.EventHandler(this.FrmVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegisterVehicle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtPlateVehicle;
        private System.Windows.Forms.ComboBox cmbGas;
        private System.Windows.Forms.Label lbl2;
    }
}