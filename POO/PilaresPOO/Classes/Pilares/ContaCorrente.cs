using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Pilares
{
    public class ContaCorrente : Conta
    {
        public float Limite;

        public override bool Depositar(float valor)
        {

            if (Saldo > 0)
            {

                Saldo = Saldo + valor;
                return true;

            }
            else
            {
                return false;
            }

        }

        public override float Sacar (float valor)

        {
            if (valor <= Saldo)
            {
                Saldo = Saldo - valor;

                return valor;
            }

            else
            {
                return 0;
            }

        }

        public bool Transferir(float valor, Conta contaDestino)
        {
            return false;
        }




    }
}