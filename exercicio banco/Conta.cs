using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_banco
{
    class Conta
    {
        private string _nome;
        public int NumeroConta { get; private set; }
        public double SaldoConta { get; private set; }



        public Conta(string nome, int numeroConta)
        {
            _nome = nome;
            NumeroConta = numeroConta;
            SaldoConta = 0;
        }

        public Conta(string nome, int numeroConta,double saldoConta) : this(nome, numeroConta)
        {
            SaldoConta = saldoConta;
        }

        public double Depositar(double Valor)
        {
            return SaldoConta += Valor;
        }
        public double Sacar(double saque)
        {
            return (SaldoConta -= (saque + 5));
        }

        public override string ToString()
        {
            return $"Titular da conta : {_nome}, Numero da conta : {NumeroConta} com o saldo de R${SaldoConta:f2}";
        }




    }
}
