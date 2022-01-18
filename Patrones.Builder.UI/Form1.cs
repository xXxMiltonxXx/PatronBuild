using Patrones.Builder.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patrones.Builder.UI
{
    public partial class Form1 : Form
    {


        List<PersonajeConstructor> _lineas;
        public Form1()
        {
            InitializeComponent();

            _lineas = new List<PersonajeConstructor>();
            _lineas.Add(new PosionFuerza());
            _lineas.Add(new PosionVelocidad());
            _lineas.Add(new PosionInmunidad());

            this.cboLineas.DataSource = _lineas;
        
        }

        private void btnConstruír_Click(object sender, EventArgs e)
        {
            PersonajeConstructor builder = (PersonajeConstructor)cboLineas.SelectedItem;
            Acciones poder = builder.ConstrutorAcciones();

            this.Poder.Items.Add(poder);
        }
    }
}
