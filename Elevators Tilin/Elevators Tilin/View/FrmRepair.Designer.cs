
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Location = new System.Drawing.Point(671, 527);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(207, 64);
            this.btnRegister.TabIndex = 21;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // dtpRepair
            // 
            this.dtpRepair.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRepair.Location = new System.Drawing.Point(259, 173);
            this.dtpRepair.Name = "dtpRepair";
            this.dtpRepair.Size = new System.Drawing.Size(121, 27);
            this.dtpRepair.TabIndex = 16;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.BackColor = System.Drawing.Color.White;
            this.lbl6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl6.Location = new System.Drawing.Point(54, 305);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(206, 22);
            this.lbl6.TabIndex = 14;
            this.lbl6.Text = "Repuestos necesarios:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.White;
            this.lbl4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl4.Location = new System.Drawing.Point(50, 178);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(208, 22);
            this.lbl4.TabIndex = 15;
            this.lbl4.Text = "Fecha de la reparación:";
            // 
            // cmbState
            // 
            this.cmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbState.Location = new System.Drawing.Point(259, 109);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(121, 28);
            this.cmbState.TabIndex = 20;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.White;
            this.lbl1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(77, 48);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(176, 22);
            this.lbl1.TabIndex = 12;
            this.lbl1.Text = "Numero del equipo:";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(259, 244);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(345, 27);
            this.txtName.TabIndex = 19;
            // 
            // txtEquipNumber
            // 
            this.txtEquipNumber.AcceptsTab = true;
            this.txtEquipNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEquipNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEquipNumber.Location = new System.Drawing.Point(259, 47);
            this.txtEquipNumber.Name = "txtEquipNumber";
            this.txtEquipNumber.Size = new System.Drawing.Size(121, 27);
            this.txtEquipNumber.TabIndex = 10;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.White;
            this.lbl3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl3.Location = new System.Drawing.Point(464, 47);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(338, 22);
            this.lbl3.TabIndex = 17;
            this.lbl3.Text = "Descripción de la reparacíon realizada:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl2.Location = new System.Drawing.Point(89, 112);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(169, 22);
            this.lbl2.TabIndex = 13;
            this.lbl2.Text = "Estado del equipo:";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Location = new System.Drawing.Point(464, 85);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(413, 118);
            this.txtDescription.TabIndex = 18;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl5.Location = new System.Drawing.Point(81, 244);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(180, 22);
            this.lbl5.TabIndex = 11;
            this.lbl5.Text = "Nombre del técnico:";
            // 
            // cmbParts
            // 
            this.cmbParts.FormattingEnabled = true;
            this.cmbParts.Location = new System.Drawing.Point(259, 297);
            this.cmbParts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbParts.Name = "cmbParts";
            this.cmbParts.Size = new System.Drawing.Size(345, 28);
            this.cmbParts.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColCant});
            this.dataGridView1.Location = new System.Drawing.Point(58, 413);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(546, 191);
            this.dataGridView1.TabIndex = 23;
            // 
            // ColName
            // 
            this.ColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColName.HeaderText = "Nombre";
            this.ColName.MinimumWidth = 6;
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.Width = 335;
            // 
            // ColCant
            // 
            this.ColCant.HeaderText = "Cantidad";
            this.ColCant.MinimumWidth = 6;
            this.ColCant.Name = "ColCant";
            this.ColCant.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Elevators_Tilin.Properties.Resources.imgReparacion;
            this.pictureBox1.Location = new System.Drawing.Point(671, 229);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(259, 348);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 27);
            this.textBox1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(163, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cantidad:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Elevators_Tilin.Properties.Resources.btnAddFn;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(443, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 632);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbParts);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dtpRepair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEquipNumber);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lbl5);
            this.Name = "FrmRepair";
            this.Text = "FrmRepair";
            this.Load += new System.EventHandler(this.FrmRepair_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCant;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}