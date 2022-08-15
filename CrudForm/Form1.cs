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
using CrudForm.Presentacion;

namespace CrudForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Refrescar();
        }

        #region ayuda
        private void Refrescar()
        {
            using (cursocrudEntities db = new cursocrudEntities())
            {
                var lst = from d in db.tabla
                          select d;
                dataGridView1.DataSource = lst.ToList();
            }

        }

        private int? LeerId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch(Exception ex)
            {
                return null;
            }
        }


        #endregion

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmTabla oFrmTabla = new FrmTabla();
            oFrmTabla.ShowDialog();
            Refrescar();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            int? id = this.LeerId();
            if (id != null)
            {
                FrmTabla oFrmTabla = new FrmTabla(id);
                oFrmTabla.ShowDialog();
                Refrescar();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int? id = this.LeerId();
            if (id != null)
            {
                using (cursocrudEntities db = new cursocrudEntities())
                {
                    tabla oTabla = db.tabla.Find(id);
                    db.tabla.Remove(oTabla);
                    db.SaveChanges();
                }
                Refrescar();
            }

        }
    }
}
