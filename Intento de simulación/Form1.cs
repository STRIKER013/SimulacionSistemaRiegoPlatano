using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intento_de_simulación {
    public partial class FrmPrincipal : Form {
        public decimal cantAgua { get; set; }
        public FrmPrincipal() {
            InitializeComponent();
            Btn_desable();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        public void Btn_desable()
        {
            btn_CrecimientoEneroMarzo.Enabled = true;
            btn_CrecimientoMarzoMayo.Enabled = false;
            btn_CrecimientoMayoJulio.Enabled = false;
            btn_CrecimientoJulioSeptiembre.Enabled = false;
            btn_CrecimientoSeptiembreNoviembre.Enabled = false;
        }
        public void PlatanitoVerdadero() {
            this.pb_Platanito1.Visible = true;
            this.pb_Platanito2.Visible = true;
            this.pb_Platanito3.Visible = true;
            this.pb_Platanito4.Visible = true;
            this.pb_Platanito5.Visible = true;
            this.pb_Platanito6.Visible = true;
            this.pb_Platanito7.Visible = true;
            this.pb_Platanito8.Visible = true;

        }

        public void PlatanitoFalso() {
            this.pb_Platanito1.Visible = false;
            this.pb_Platanito2.Visible = false;
            this.pb_Platanito3.Visible = false;
            this.pb_Platanito4.Visible = false;
            this.pb_Platanito5.Visible = false;
            this.pb_Platanito6.Visible = false;
            this.pb_Platanito7.Visible = false;
            this.pb_Platanito8.Visible = false;

        }

        public void PlatanoMedianoverdadero() {
            this.Pb_Platano_mediano1.Visible = true;
            this.Pb_Platano_mediano2.Visible = true;
            this.Pb_Platano_mediano3.Visible = true;
            this.Pb_Platano_mediano4.Visible = true;
            this.Pb_Platano_mediano5.Visible = true;
            this.Pb_Platano_mediano6.Visible = true;
            this.Pb_Platano_mediano7.Visible = true;
            this.Pb_Platano_mediano8.Visible = true;
        }

        public void PlatanoMedianoFalso() {
            this.Pb_Platano_mediano1.Visible = false;
            this.Pb_Platano_mediano2.Visible = false;
            this.Pb_Platano_mediano3.Visible = false;
            this.Pb_Platano_mediano4.Visible = false;
            this.Pb_Platano_mediano5.Visible = false;
            this.Pb_Platano_mediano6.Visible = false;
            this.Pb_Platano_mediano7.Visible = false;
            this.Pb_Platano_mediano8.Visible = false;
        }

        public void MedianoGrandeVerdadero() {
            this.pb_Mediano_Grande1.Visible = true;
            this.pb_Mediano_Grande2.Visible = true;
            this.pb_Mediano_Grande3.Visible = true;
            this.pb_Mediano_Grande4.Visible = true;
            this.pb_Mediano_Grande5.Visible = true;
            this.pb_Mediano_Grande6.Visible = true;
            this.pb_Mediano_Grande7.Visible = true;
            this.pb_Mediano_Grande8.Visible = true;
        
        }

        public void MedianoGrandeFalso() {
            this.pb_Mediano_Grande1.Visible = false;
            this.pb_Mediano_Grande2.Visible = false;
            this.pb_Mediano_Grande3.Visible = false;
            this.pb_Mediano_Grande4.Visible = false;
            this.pb_Mediano_Grande5.Visible = false;
            this.pb_Mediano_Grande6.Visible = false;
            this.pb_Mediano_Grande7.Visible = false;
            this.pb_Mediano_Grande8.Visible = false;
           
        }

        public void PlatanoGrandeFalso() {
            this.pb_PlatanoGrande1.Visible = false;
            this.pb_PlatanoGrande2.Visible = false;
            this.pb_PlatanoGrande3.Visible = false;
            this.pb_PlatanoGrande4.Visible = false;
            this.pb_PlatanoGrande5.Visible = false;
            this.pb_PlatanoGrande6.Visible = false;
            this.pb_PlatanoGrande7.Visible = false;
            this.pb_PlatanoGrande8.Visible = false;

        }
        public void PlatanoGrandeVerdadero() {
            this.pb_PlatanoGrande1.Visible = true;
            this.pb_PlatanoGrande2.Visible = true;
            this.pb_PlatanoGrande3.Visible = true;
            this.pb_PlatanoGrande4.Visible = true;
            this.pb_PlatanoGrande5.Visible = true;
            this.pb_PlatanoGrande6.Visible = true;
            this.pb_PlatanoGrande7.Visible = true;
            this.pb_PlatanoGrande8.Visible = true;
        }

        public void PlatanoFrutoVerdadero() {
            this.pb_PlatanoFruto1.Visible = true;
            this.pb_PlatanoFruto2.Visible = true;
            this.pb_PlatanoFruto3.Visible = true;
            this.pb_PlatanoFruto4.Visible = true;
            this.pb_PlatanoFruto5.Visible = true;
            this.pb_PlatanoFruto6.Visible = true;
            this.pb_PlatanoFruto7.Visible = true;
            this.pb_PlatanoFruto8.Visible = true;

        }

        public void PlatanoFrutoFalso() {
            this.pb_PlatanoFruto1.Visible = false;
            this.pb_PlatanoFruto2.Visible = false;
            this.pb_PlatanoFruto3.Visible = false;
            this.pb_PlatanoFruto4.Visible = false;
            this.pb_PlatanoFruto5.Visible = false;
            this.pb_PlatanoFruto6.Visible = false;
            this.pb_PlatanoFruto7.Visible = false;
            this.pb_PlatanoFruto8.Visible = false;

        }



        private void btn_CrecimientoEneroMarzo_Click(object sender, EventArgs e) {
            
            MedianoGrandeFalso();
            PlatanoMedianoFalso();
            PlatanoGrandeFalso();
            PlatanoFrutoFalso();
            PlatanitoVerdadero();
            cbxClima.Enabled = true;
            btn_CrecimientoEneroMarzo.Enabled = false;
            btn_CrecimientoMarzoMayo.Enabled = true;
        }

        private void btn_CrecimientoMarzoMayo_Click(object sender, EventArgs e) {
            PlatanitoFalso();
            MedianoGrandeFalso();
            PlatanoGrandeFalso();
            PlatanoFrutoFalso();
            PlatanoMedianoverdadero();
            cbxClima.Enabled = true;
            btn_CrecimientoMarzoMayo.Enabled = false;
            btn_CrecimientoMayoJulio.Enabled = true;
        }

        private void btn_CrecimientoMayoJulio_Click(object sender, EventArgs e) {
            PlatanoMedianoFalso();
            PlatanitoFalso();
            PlatanoGrandeFalso();
            PlatanoFrutoFalso();
            MedianoGrandeVerdadero();
            cbxClima.Enabled = true;
            btn_CrecimientoMayoJulio.Enabled = false;
            btn_CrecimientoJulioSeptiembre.Enabled = true;
        }

        private void btn_CrecimientoJulioSeptiembre_Click(object sender, EventArgs e) {
            MedianoGrandeFalso();
            PlatanoFrutoFalso();
            PlatanoGrandeVerdadero();
            cbxClima.Enabled = true;
            btn_CrecimientoJulioSeptiembre.Enabled = false;
            btn_CrecimientoSeptiembreNoviembre.Enabled = true;

        }

        private void btn_CrecimientoSeptiembreNoviembre_Click(object sender, EventArgs e) {
            PlatanoGrandeFalso();
            PlatanoFrutoVerdadero();
            cbxClima.Enabled = true;
            btn_CrecimientoSeptiembreNoviembre.Enabled = false;
        }

        private void cbxClima_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxClima.SelectedIndex.Equals(0))
            {
                cantAgua = cantAgua + (1170 * 3);
                txtCantidadAgua.Text = cantAgua.ToString();
            }else if (cbxClima.SelectedIndex.Equals(1))
            {
                cantAgua = cantAgua + (970 * 3);
                txtCantidadAgua.Text = cantAgua.ToString();
            }else if (cbxClima.SelectedIndex.Equals(2))
            {
                cantAgua = cantAgua + (765 * 3);
                txtCantidadAgua.Text = cantAgua.ToString();
            }

            cbxClima.Enabled = false;
        }

        private void btn_Reiniciar_Click(object sender, EventArgs e)
        {
            Btn_desable();
            cantAgua = 0;
            txtCantidadAgua.Text = "0";
        }

    }
}
