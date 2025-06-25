using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoForms {
  internal class Veiculo {

    public String Placa { get; private set; }

    public Int32 HorasAPagar { get; }

    public Double Valor { get; private set; }

    public Boolean Pago { get; set; }

    public Veiculo(String placa) {
      Placa = placa;
      Random randonHoras = new Random();
      HorasAPagar = randonHoras.Next(1, 5);
    }

    public void CalculaValorAPagar() {
      Valor = RegrasDeNegocio.CalculaValorAPagar(HorasAPagar);
    }
  }
}
