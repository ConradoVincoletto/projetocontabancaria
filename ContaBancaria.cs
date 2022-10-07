using System;
using System.Globalization;
using System.Text;

namespace Course {
    class ContaBancaria {

        public int NumeroConta { get; private set; }
        public string Nome { get; set; }

        public double Saldo { get; private set; }

        public ContaBancaria (int numero, string titular) {
            NumeroConta = numero;
            Nome = titular;
        }

        public ContaBancaria (int numero, string titular, double depositioInicial) : this(numero, titular) {
            Deposito(depositioInicial);
        }
        
        public void Deposito (double quantia) {
            Saldo += quantia;
        }

        public void Saque (double quatia) {
            Saldo -= quatia + 5.0;
        }

        public override string ToString() {
            return "Conta "
                + NumeroConta
                + ", Titular, "
                + Nome
                + ", Saldo R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }




    }
}
