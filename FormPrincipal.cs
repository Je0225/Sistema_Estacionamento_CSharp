using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EstacionamentoForms {

    public partial class FormPrincipal: Form {

        public FormPrincipal() {
            InitializeComponent();
            LimpaTexto(); 
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {

            string textoDigitado = tbPlaca.Text.Trim().ToUpper();
            bool jaEstaNaLista = false;

            for ( int i = 0; i < lvListaPlacas.Items.Count; i++) {
                jaEstaNaLista = lvListaPlacas.Items[i].Text == textoDigitado;
                if (jaEstaNaLista) {
                    break;
                }
            }
            if (jaEstaNaLista) {
                MessageBox.Show("Essa placa já está na lista");
                return;
            }
            foreach (var placa in lvListaPlacas.Items) {
                
            }
            /*
                if (textoDigitado == "") {
                    MessageBox.Show("Dígite uma placa válida!");
                    return;
                }
                if (textoDigitado.Length != 7) {
                    MessageBox.Show("Dígite uma placa válida!, a placa deve conter 7 dígitos");
                    return;
                 }
            //cqr4l31
                for (int i = 0; i < textoDigitado.Length; i++) {
                    if ((i == 0 || i == 1 || i == 2 || i == 4) && Char.IsLetter(textoDigitado[i])) {
                        podeAdicionar =true;
                 }
                else if ((i == 3 || i == 5 || i == 6) && Char.IsNumber(textoDigitado[i])) {
                    podeAdicionar = true;
                 }
                else {
                    podeAdicionar = false;
                 }
               }
            */
            bool podeAdicionar = Regex.IsMatch(textoDigitado, "[a-zA-Z]{3}\\d[a-zA-Z]\\d{2}");

            if (podeAdicionar) {
                lvListaPlacas.Items.Add(textoDigitado);
                tbPlaca.Clear();
                tbPlaca.Focus();
            } else {
                MessageBox.Show(" Não há digitos da placa ou os dígitos não são válidos, a placa deve seguir o padrão 'LLLNLNN'");
            }
        }

        private void btnLiberar_Click(object sender, EventArgs e) {
            if (lvListaPlacas.SelectedItems.Count == 0) {
                MessageBox.Show("Não há nenhuma placa selecionada para liberar do estacionamento");
                return;
            }
            lblPlacaCustoResult.Text = lvListaPlacas.SelectedItems[0].Text;
            lvListaPlacas.SelectedItems[0].Remove();
            tbPlaca.Focus();
            Random horasAleatorias = new Random();
            int horas = horasAleatorias.Next(1, 5);
            double horasAPagar = horas * 12.50 + 10;
            lblHorasResult.Text = horas.ToString();
            lblAPagarResult.Text = horas + " * 12,50 (preço por hora) + 10 (preço inicial) = " + horasAPagar;
        }

        public void LimpaTexto() {
            lblHorasResult.Text = "";
            lblAPagarResult.Text = "";
            lblPlacaCustoResult.Text = "";
        }

        private void btnPago_Click(object sender, EventArgs e) {
            if (lblHorasResult.Text == "" && lblAPagarResult.Text == "" && lblPlacaCustoResult.Text == "") {
                MessageBox.Show("Não há informações de nenhum veículo para limpar");
                return;
            }
            LimpaTexto();
        }

        private void tbPlaca_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                btnAdicionar.PerformClick();
            }
        }

    }

}