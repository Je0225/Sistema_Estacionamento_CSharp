using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoForms {
  internal static class RegrasDeNegocio {

    public static readonly Double preçoHora = 12.50;

    public static readonly Double preçoInicial = 10.00;

    public static Double CalculaValorAPagar(Int32 totalHoras) {
      return totalHoras * preçoHora + preçoInicial;
    }
  }
}
