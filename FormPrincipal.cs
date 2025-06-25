using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EstacionamentoForms {

  public partial class FormPrincipal : Form {

    private List<Veiculo> Veiculos { get; set; }

    private Veiculo VeiculoSelecionado { get; set; }

    public FormPrincipal() {
      InitializeComponent();
      LimpaTexto();
      Veiculos = new List<Veiculo>();
    }

    private void LimpaTexto() {
      lblHorasResult.Text = "";
      lblAPagarResult.Text = "";
      lblPlacaCustoResult.Text = "";
    }

    private void AdicionarVeiculo() {
      String textoDigitado = tbPlaca.Text.Trim().ToUpper();

      if (textoDigitado == "" || textoDigitado.Length != 7 || !Regex.IsMatch(textoDigitado, "[a-zA-Z]{3}\\d[a-zA-Z]\\d{2}")) {
        MessageBox.Show(@"Dígite uma placa válida! a placa deve seguir o padrão 'LLLNLNN'");
        return;
      }
      if (Veiculos.Exists(v => v.Placa == textoDigitado)) {
        MessageBox.Show(@"Essa placa já está na lista");
        return;
      }

      Veiculo veiculo = new Veiculo(textoDigitado);
      Veiculos.Add(veiculo);
      lvListaPlacas.Items.Add(veiculo.Placa);
      tbPlaca.Clear();
      tbPlaca.Focus();
    }

    private void btnAdicionar_Click(object sender, EventArgs e) {
      AdicionarVeiculo();
    }

    private void tbPlaca_KeyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Enter) {
        AdicionarVeiculo();
      }
    }

    private void btnLiberar_Click(object sender, EventArgs e) {
      if (lvListaPlacas.SelectedItems.Count == 0) {
        MessageBox.Show(@"Não há nenhuma placa selecionada para liberar do estacionamento");
        return;
      }
      lblPlacaCustoResult.Text = VeiculoSelecionado.Placa;
      lvListaPlacas.SelectedItems[0].Remove();
      tbPlaca.Focus();
      VeiculoSelecionado.CalculaValorAPagar();
      lblHorasResult.Text = VeiculoSelecionado.HorasAPagar.ToString();
      lblAPagarResult.Text = $@"{VeiculoSelecionado.HorasAPagar} * {RegrasDeNegocio.preçoHora} (preço por hora) + {RegrasDeNegocio.preçoInicial} (preço inicial) = {VeiculoSelecionado.Valor}";
    }

    private void btnPago_Click(object sender, EventArgs e) {
      if (lblHorasResult.Text == "" && lblAPagarResult.Text == "" && lblPlacaCustoResult.Text == "") {
        MessageBox.Show(@"Selecione um veículo para pagar");
        return;
      }
      VeiculoSelecionado.Pago = true;
      Veiculos.Remove(VeiculoSelecionado);
      LimpaTexto();
      MessageBox.Show($@"Veículo {VeiculoSelecionado.Placa} liberado!");
    }

    private void lvListaPlacas_SelectedIndexChanged(object sender, EventArgs e) {
      if (lvListaPlacas.SelectedItems.Count > 0) {
        VeiculoSelecionado = Veiculos.Find(v => v.Placa == lvListaPlacas.SelectedItems[0].Text);
      }
    }

  }
}