using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_aluno
{
    internal class Aluno
    {
        private string nome;
        private string endereco;
        private string situacao;
        private Color cor;
        private double nota1;
        private double nota2;
        private double nota3;
        private double media;
        DateTime dataNasc;

        public Aluno()
        {
            this.nome = "";
            this.endereco = "";
            this.situacao = "";
            this.cor = Color.Black;
            this.nota1 = 0;
            this.nota2 = 0;
            this.nota3 = 0;
            this.media = 0;
            DateTime dataNasc = DateTime.Today;
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
        public void setDataNasc(DateTime paramDataNasc)
        {
            this.dataNasc = paramDataNasc;
        }
        public DateTime getDataNasc()
        {
            return this.dataNasc;
        }
        public void setNota1(double paramNota1)
        {
            this.nota1 = paramNota1;
        }
        public double getNota1()
        {
            return this.nota1;
        }
        public void setNota2(double paramNota2)
        {
            this.nota2 = paramNota2;
        }
        public double getNota2()
        {
            return this.nota2;
        }
        public void setNota3(double paramNota3)
        {
            this.nota3 = paramNota3;
        }
        public double getNota3()
        {
            return this.nota3;
        }

        public double calcular()
        {
            this.media = (this.nota1 + this.nota2 + this.nota3) / 3;
            this.media = Math.Round(this.media, 1);
            if (this.media >= 6)
            {
                this.situacao = "Aprovado";
                this.cor = Color.CornflowerBlue;
            }
            else
            {
                this.situacao = "Reprovado";
                this.cor = Color.Red;
            }
            return this.media;            
        }
        public string getSituacao()
        {
            return this.situacao;
        }
        public Color getCor()
        {
            return this.cor;
        }

    }
}
