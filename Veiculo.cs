using System;

namespace EstacionamentoForms {
  internal class Veiculo {

    public String Placa { get; private set; }

    public Int32 HorasAPagar { get; }

    public Boolean Pago { get; set; }

    public Veiculo(String placa) {
      Placa = placa;
      Random randonHoras = new Random();
      HorasAPagar = randonHoras.Next(1, 5);
    }

  }
}
