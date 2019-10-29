using ModelosRally;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistasRally
{
    public partial class Form1 : Form
    {
        public event EventHandler<AgregarPilotoEventArgs> OnAgregarPiloto;

        public Form1()
        {
            InitializeComponent();
            this.RolComboBox.DataSource = Enum.GetValues(typeof(Rol));
        }

        private void AgregarPilotoButton_Click(object sender, EventArgs e)
        {
            PilotNameComboBox.Items.Add(this.NameTextBox.Text + " - " + RolComboBox.SelectedItem);
            if (RolComboBox.SelectedItem.ToString() == "Piloto")
            {
                PilotocomboBox.Items.Add(NameTextBox.Text);
            }
            else if (RolComboBox.SelectedItem.ToString() == "Navegante")
            {
                NavegantecomboBox.Items.Add(NameTextBox.Text);
            }
            /*
            if (OnAgregarPiloto != null)
            {
                AgregarPilotoEventArgs pilotoArgs = new AgregarPilotoEventArgs();
                pilotoArgs.nombre = this.NameTextBox.Text;
                OnAgregarPiloto(this, pilotoArgs);
            }
            */
            
        }

        
        public void ActualizarListadoPilotos(Persona pilotoNuevo)
        {
            PilotNameComboBox.Items.Add(pilotoNuevo);
        }

        private void CrearEquipo_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void AgregarEquipoButton_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo(marcaVehiculo.Text,Convert.ToInt32( cilindraVehiculo.Value));
            Persona persona = new Persona(PilotocomboBox.SelectedItem.ToString(), Rol.Piloto);
            Persona persona1 = new Persona(NavegantecomboBox.SelectedItem.ToString(), Rol.Navegante);
            Equipo equipo = new Equipo(nameEquipo.Text, vehiculo, persona, persona1);
            EquipoComboBox.Items.Add(nameEquipo.Text);
            panel1.Visible = false;
        }
    }
}
