using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EstacionamentoForms {

  public partial class FormPrincipal : Form {

    private Veiculo VeiculoSelecionado { get; set; }

    public FormPrincipal() {
      InitializeComponent();
      LimpaCamposResultado();
    }

    private void LimpaCamposResultado() {
      lblHorasResult.Text = "";
      lblAPagarResult.Text = "";
      lblPlacaCustoResult.Text = "";
    }

    private void AdicionarVeiculo() {
      String textoDigitado = tbPlaca.Text.Trim().ToUpper();
      if (!PlacaEhValdia(textoDigitado)) {
        return;
      }
      Veiculo veiculo = new Veiculo(textoDigitado);
      Estacionamento.AdicionarVeiculo(veiculo);
      lvListaPlacas.Items.Add(veiculo.Placa).Tag = veiculo;
      tbPlaca.Clear();
      tbPlaca.Focus();
    }

    private void LiberarVeiculo() {
      if (!PodeLiberar()) {
        return;
      }
      if (Estacionamento.PrecisaAguardarOutroVeiculoLiberar()) {
        MessageBox.Show(@"Aguarde o veículo da frente ser liberado.");
        return;
      }
      lblPlacaCustoResult.Text = VeiculoSelecionado.Placa;
      lvListaPlacas.SelectedItems[0].Remove();
      tbPlaca.Select();
      Estacionamento.LiberarParaPagamento(VeiculoSelecionado);
      Double valorAPagar = Estacionamento.CalculaValorAPagar(VeiculoSelecionado.HorasAPagar);
      lblHorasResult.Text = VeiculoSelecionado.HorasAPagar.ToString();
      lblAPagarResult.Text = $@"{VeiculoSelecionado.HorasAPagar} * {RegrasDeNegocio.PREÇO_HORA} (preço por hora) + {RegrasDeNegocio.PREÇO_INICIAL} (preço inicial) = {valorAPagar}";
    }

    private void Pagar() {
      if (!PodePagar()) {
        return;
      }
      Estacionamento.Pagar(VeiculoSelecionado);
      Estacionamento.RemoverVeiculo(VeiculoSelecionado);
      LimpaCamposResultado();
      MessageBox.Show($@"Veículo {VeiculoSelecionado.Placa} liberado!");
    }

    private void GetVeiculoSelecionado() {
      if (lvListaPlacas.SelectedItems.Count > 0) {
        VeiculoSelecionado = (Veiculo)lvListaPlacas.SelectedItems[0].Tag;
      }
    }

    private Boolean PlacaEhValdia(String textoDigitado) {
      if (textoDigitado == "" || textoDigitado.Length != 7 || !Regex.IsMatch(textoDigitado, "[a-zA-Z]{3}\\d[a-zA-Z]\\d{2}")) {
        MessageBox.Show(@"Dígite uma placa válida! a placa deve seguir o padrão 'LLLNLNN'");
        return false;
      }
      if (Estacionamento.GetVeiculos().Exists(v => v.Placa == textoDigitado)) {
        MessageBox.Show(@"Essa placa já está na lista");
        return false;
      }
      return true;
    }

    private Boolean PodePagar() {
      if (lblHorasResult.Text == "" && lblAPagarResult.Text == "" && lblPlacaCustoResult.Text == "") {
        MessageBox.Show(@"Selecione um veículo para pagar");
        return false;
      }
      return true;
    }

    private Boolean PodeLiberar() {
      if (lvListaPlacas.SelectedItems.Count == 0) {
        MessageBox.Show(@"Não há nenhuma placa selecionada para liberar do estacionamento");
        return false;
      }
      return true;
    }

    private void btnAdicionar_Click(object sender, EventArgs e) {
      AdicionarVeiculo();
    }

    private void btnLiberar_Click(object sender, EventArgs e) {
      LiberarVeiculo();
    }

    private void lvListaPlacas_SelectedIndexChanged(object sender, EventArgs e) {
      GetVeiculoSelecionado();
    }

    private void btnPago_Click(object sender, EventArgs e) {
      Pagar();
    }
    private void tbPlaca_KeyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Enter) {
        AdicionarVeiculo();
      }
    }
  }
}