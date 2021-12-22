﻿using Elevators_Tilin.ContextSIAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevators_Tilin.View
{
    public partial class FrmRepair : Form
    {
        public FrmRepair()
        {
            InitializeComponent();
        }

        private void FrmRepair_Load(object sender, EventArgs e)
        {
            LoadTheme();
            ChargerProducts();
        }

        //Para cambiar los botones del color correspondiente
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = Extras.ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Extras.ThemeColor.SecundaryColor;
                }
            }
        }

        //Añadiendo funcion de cargar datos de repuestos
        private void ChargerProducts(){
            var db = new SIAL_DBContext();
            List<Repuesto> repuestos = db.Repuestos.ToList();
            //Cargando datos al cmb
            cmbParts.DataSource = repuestos;
            cmbParts.DisplayMember = "Nombre";
            cmbParts.ValueMember = "Id";
        }

        //Añadiendo funcion para añadir productos al dgv
        private void AddProduct()
        {
            var db = new SIAL_DBContext();
            List<Repuesto> repuestos = db.Repuestos.ToList();
            int cant = Convert.ToInt32(txtQuantity.Text);
            List<Repuesto> exist = repuestos.Where(x => x.Nombre == cmbParts.Text && x.Cantidad>=cant).ToList();
            bool verification = cant > 0;
            if(cant < 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0");
            }
            else if (verification && exist.Count() > 0)
            {
                dgvParts.Rows.Add(cmbParts.Text, cant);
            }
            else
            {
                MessageBox.Show("No hay suficientes productos en stock");
            }
        }

        //Funciones para agregar el registro de mantenimiento
        private void Repair()
        {
            var db = new SIAL_DBContext();
            List<Reparacion> reparaciones = db.Reparacions.ToList();
            List<Equipo> equipos = db.Equipos.ToList();
            List<Equipo> exist = equipos.Where(u => u.NumeroSerie == txtEquipNumber.Text).ToList();
            bool verification = txtEquipNumber.Text.Length > 1 && cmbState.Text.Length > 1 && txtName.Text.Length > 1;
            bool band = true;
            bool band2 = true;

            if(verification && exist.Count() > 0) {
                
                if(cmbType.Text == "Elevador"){
                    int id = 0;
                    foreach (var item in equipos)
                    {
                        if (item.NumeroSerie == txtEquipNumber.Text)
                        {
                            id = item.Id;
                        }
                        else{
                            band=false;
                        }
                    }

                    //Añadiendo el registro reparacion
                    Reparacion reparacion = new Reparacion{
                        FechaReparacion = dtpRepair.Value,
                        NumeroSerie = txtEquipNumber.Text,
                        Descripcion = txtDescription.Text,
                        Tecnico = txtName.Text,
                        Estado = cmbState.Text,
                        IdEquipo = id,
                        IdAutomovil = null
                    };
                    db.Add(reparacion);
                    db.SaveChanges();
                    
                }
                else{
                    int id = 0;
                    foreach (var item in equipos)
                    {
                        if (item.NumeroSerie == txtEquipNumber.Text)
                        {
                            id = item.Id;
                        }
                        else{
                            band2 = false;
                        }
                    }

                    //Añadiendo el registro reparacion
                    Reparacion reparacion = new Reparacion{
                        FechaReparacion = dtpRepair.Value,
                        NumeroSerie = txtEquipNumber.Text,
                        Descripcion = txtDescription.Text,
                        Tecnico = txtName.Text,
                        Estado = cmbState.Text,
                        IdEquipo = null,
                        IdAutomovil = id
                    };
                    db.Add(reparacion);
                    db.SaveChanges();
                }

                //Mandamos los datos a ReparacionxRepuesto
                var db2 = new SIAL_DBContext();
                List<Reparacion> reparaciones2 = db2.Reparacions.ToList();
                int idReparacion = 0;
                foreach (var item in reparaciones2)
                {
                    if (item.NumeroSerie == txtEquipNumber.Text)
                    {
                        idReparacion = item.Id;
                    }
                }
                
                //aQUI FALLA
                List<Repuesto> repuestos = db.Repuestos.ToList();
                for (int i = 0; i < dgvParts.Rows.Count; i++)
                {
                    int idRepuesto = 0;
                    foreach (var item in repuestos)
                    {
                        var name = dgvParts.Rows[i].Cells[0].Value.ToString();
                        if (item.Nombre == name)
                        {
                            idRepuesto = item.Id;
                        }
                    }
                    //Añadiendo el registro repuesto
                    ReparacionxRepuesto repuesto2 = new ReparacionxRepuesto
                    {
                        IdReparacion = idReparacion,
                        IdRepuesto = idRepuesto,
                    };
                    db.Add(repuesto2);
                    db.SaveChanges();
                }

                for(int i=0; i < dgvParts.Rows.Count; i++){
                    foreach(var item in repuestos){
                        if(item.Nombre == dgvParts.Rows[i].Cells[0].Value.ToString()){
                            int auxCant = Convert.ToInt32(dgvParts.Rows[i].Cells[2].Value.ToString());
                            item.Cantidad -=  auxCant;
                            db.Update(item);
                            db.SaveChanges();
                        }
                    }
                }
            }
            else{
                MessageBox.Show("Algo anda mal weon", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // if(band == false || band2 == false){
            //     MessageBox.Show("Numero de serie o placa no existente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            // }
            // else{
            //     MessageBox.Show("Reparacion registrada correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // }
        }

        private void Clear()
        {
            txtEquipNumber.Text = "";
            txtDescription.Text = "";
            txtName.Text = "";
            cmbState.Text = "";
            dgvParts.Rows.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProduct();
            cmbParts.Text = "";
            txtQuantity.Text = "";
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            Repair();
            Clear();
        }

        
    }
}