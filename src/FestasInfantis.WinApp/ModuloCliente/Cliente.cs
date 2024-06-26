using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloAluguel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloCliente
{

    public class Cliente : EntidadeBase
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public List<Aluguel> alugueis { get; set; } = new List<Aluguel>();

        public Cliente() { }
        public Cliente(string nome, string telefone, string cpf)
        {
            Nome = nome;
            Telefone = telefone;
            Cpf = cpf;
        }
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Cliente atualizar = (Cliente)novoRegistro;

            Nome = atualizar.Nome;
            Telefone = atualizar.Telefone;
            Cpf = atualizar.Cpf;
        }

        public override string? ToString()
        {
            return $"{Nome}{Telefone}{Cpf}";
        }

        public void ListarAlugueis(Aluguel aluguel)
        {
            alugueis.Add(aluguel);
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório.");

            if (string.IsNullOrEmpty(Telefone.Trim()))
                erros.Add("O campo \"telefone\" é obrigatório.");

            if (string.IsNullOrEmpty(Cpf.Trim()))
                erros.Add("O campo \"Cpf\" é obrigatório.");

            return erros;
        }
    }
}
