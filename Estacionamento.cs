using System;
using System.Collections.Generic;

namespace EstacionamentoForms {
  internal static class Estacionamento {

    private static readonly List<Veiculo> veiculos = new List<Veiculo>();

    private static Veiculo veiculoAguardandoLiberacao;

    public static void AdicionarVeiculo(Veiculo veiculo) {
      veiculos.Add(veiculo);
    }

    public static void RemoverVeiculo(Veiculo veiculo) {
      veiculos.Remove(veiculo);
    }

    public static List<Veiculo> GetVeiculos() {
      return veiculos;
    }

    public static Boolean PrecisaAguardarOutroVeiculoLiberar() {
      return veiculoAguardandoLiberacao != null;
    }

    public static void LiberarParaPagamento(Veiculo veiculo) {
      veiculoAguardandoLiberacao = veiculo;
    }

    public static Double CalculaValorAPagar(Int32 horasAPagar) {
      return RegrasDeNegocio.CalculaValorAPagar(horasAPagar);
    }

    public static void Pagar(Veiculo veiculo) {
      veiculo.Pago = true;
      veiculoAguardandoLiberacao = null;
    }

  }
}
