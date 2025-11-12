using System;

namespace EstacionamentoForms {
  internal static class RegrasDeNegocio {

    public const Double PREÇO_HORA = 12.50;

    public const Double PREÇO_INICIAL = 10.00;

    public static Double CalculaValorAPagar(Int32 totalHoras) {
      return totalHoras * PREÇO_HORA + PREÇO_INICIAL;
    }
  }
}
