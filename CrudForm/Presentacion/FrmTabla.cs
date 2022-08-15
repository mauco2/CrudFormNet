using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudForm.Modelos;

namespace CrudForm.Presentacion
{
    public partial class FrmTabla : Form
    {
        public int? id;
        tabla oTabla = null;

        public FrmTabla(int? id=null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
            {
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            using (cursocrudEntities db = new cursocrudEntities())
            {
                oTabla = db.tabla.Find(id);
                TxtCorreo.Text = oTabla.correo1;
                TxtNombre.Text = oTabla.nombre1;
                DtpFecnac.Value = (DateTime)oTabla.fechanacimiento;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            using (cursocrudEntities db = new cursocrudEntities())
            {
                if (id==null)
                    oTabla = new tabla();
                else
                {
                    db.Entry(oTabla).State = System.Data.Entity.EntityState.Modified;
                }
                oTabla.nombre1 = TxtNombre.Text;
                oTabla.correo1 = TxtCorreo.Text;
                oTabla.fechanacimiento = DtpFecnac.Value;
                
                if(id==null)
                    db.tabla.Add(oTabla);
                
                db.SaveChanges();
                this.Close();
            }
        }

        private void FrmTabla_Load(object sender, EventArgs e)
        {

        }
    }
}
