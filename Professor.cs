using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processar_Salario
{
    class Professor
    {
        private int codigo;
        private string nome;
        private long contacto;
        private int dias;
        private double salario;
        private double salarioMens;

        public Professor(int codigo, string nome, long contacto, int dias, double salario, double salarioMens)
        {
            this.SetCodigo(codigo);
            this.SetNome(nome);
            this.SetContacto(contacto);
            this.SetDias(dias);
            this.SetSalario(salario);
            this.SetSalarioMens(salarioMens);
        }

        public Professor()
        {

        }

        public int GetCodigo()
        {
            return codigo;
        }

        public void SetCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public long GetContacto()
        {
            return contacto;
        }

        public void SetContacto(long contacto)
        {
            this.contacto = contacto;
        }

        public int GetDias()
        {
            return dias;
        }

        public void SetDias(int dias)
        {
            this.dias = dias;
        }

        public double GetSalario()
        {
            return salario;
        }

        public void SetSalario(double salario)
        {
            this.salario = salario;
        }

        public double GetSalarioMens()
        {
            return salarioMens;
        }

        public void SetSalarioMens(double salarioMens)
        {
            this.salarioMens = salarioMens;
        }
    }
}
