using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EstacionamentoForms {

  public partial class FormPrincipal : Form {

    public FormPrincipal() {
      InitializeComponent();
      LimpaTexto();
    }

    private void btnAdicionar_Click(object sender, EventArgs e) {
      //placa exemplo: cqr4l31
      String textoDigitado = tbPlaca.Text.Trim().ToUpper();
      Boolean podeAdicionar = Regex.IsMatch(textoDigitado, "[a-zA-Z]{3}\\d[a-zA-Z]\\d{2}");

      if (textoDigitado == "" || textoDigitado.Length != 7) {
        MessageBox.Show(@"Dígite uma placa válida!");
        return;
      }
      if (lvListaPlacas.Items.ContainsKey(textoDigitado)) {
        MessageBox.Show(@"Essa placa já está na lista");
        return;
      }
      if (podeAdicionar) {
        lvListaPlacas.Items.Add(textoDigitado);
        tbPlaca.Clear();
        tbPlaca.Focus();
      } else {
        MessageBox.Show(@"Não há digitos da placa ou os dígitos não são válidos, a placa deve seguir o padrão 'LLLNLNN'");
      }
    }

    private void btnLiberar_Click(object sender, EventArgs e) {
      if (lvListaPlacas.SelectedItems.Count == 0) {
        MessageBox.Show(@"Não há nenhuma placa selecionada para liberar do estacionamento");
        return;
      }
      lblPlacaCustoResult.Text = lvListaPlacas.SelectedItems[0].Text;
      lvListaPlacas.SelectedItems[0].Remove();
      tbPlaca.Focus();
      Random horasAleatorias = new Random();
      int horas = horasAleatorias.Next(1, 5);
      double horasAPagar = horas * 12.50 + 10;
      lblHorasResult.Text = horas.ToString();
      lblAPagarResult.Text = horas + @" * 12,50 (preço por hora) + 10 (preço inicial) = " + horasAPagar;
    }

    private void LimpaTexto() {
      lblHorasResult.Text = "";
      lblAPagarResult.Text = "";
      lblPlacaCustoResult.Text = "";
    }

    private void btnPago_Click(object sender, EventArgs e) {
      if (lblHorasResult.Text == "" && lblAPagarResult.Text == "" && lblPlacaCustoResult.Text == "") {
        MessageBox.Show(@"Selecione um veículo para pagar");
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