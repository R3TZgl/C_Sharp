using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Cliente
    {
        private string nome;
        private string endereco;
        private string contato;
        private double limiteCartao;
        private int numeroCartao;
        private string status;
        DateTime dataNasc;

        public Cliente()
        {
            this.nome = "";
            this.endereco = "";
            this.contato = "";
            this.limiteCartao = 0;
            this.numeroCartao = 0;
            this.status = "";
            DateTime dataNdesc = DateTime.Today;
        }

        public void setNome(string paramNome)
        {
            this.nome = paramNome;
        }
        public string getNome()
        {
            return this.nome;
        }

        public void setEndereco(string paramEndereco)
        {
            this.endereco = paramEndereco;
        }
        public string getEndereco()
        {
            return this.endereco;
        }

        public void setContato(string paramContato)
        {
            this.contato = paramContato;
        }
        public string getContato()
        {
            return this.contato;
        }

        public void setLimiteCartao(double paramLimiteCartao)
        {
            this.limiteCartao = paramLimiteCartao;
        }
        public double getLimiteCartao()
        {
            return this.limiteCartao;
        }

        public void setNumeroCartao(int paramNumeroCartao)
        {
            this.numeroCartao = paramNumeroCartao;
        }
        public int getNumeroCartao()
        {
            return this.numeroCartao;
        }

        public void setStatus(string paramStatus)
        {
            this.status = paramStatus;
        }
        public string getStatus()
        {
            return this.status;
        }

        public void setDataNasc(DateTime paramDataNasc)
        {
            this.dataNasc = paramDataNasc;
        }
        public DateTime getDataNasc()
        {
            return this.dataNasc;
        }

        public void verificarLimite()
        {
            if(this.limiteCartao < 1000)
            {
                this.status = "Bloqueada";
            }
            else
            {
                this.status = "Liberada";
            }



        }
    }
}
