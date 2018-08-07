using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        private String filme;
        private String diaDaSemana;
        private double preco;

        public void setFilme(String filme)
        {
            this.filme = filme;
        }
        public void setDiaDaSemana(String diaDaSemana)
        {
            this.diaDaSemana = diaDaSemana;
        }

        public void setPreco(double preco)
        {
            this.preco = preco;
        }


        public double calcularDesconto() {
            if(this.diaDaSemana == "Quarta-Feira")
            {
                return this.preco * 0.5;
            }
            return this.preco;
        }
    }
}
