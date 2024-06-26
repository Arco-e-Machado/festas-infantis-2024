﻿using System.Text.Json;
using System.Text.Json.Serialization;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloItem;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.Compartilhado
{
    public class ContextoDados
    {
        private string caminho = Directory.GetCurrentDirectory().Split("bin")[0] + "\\Dados\\Data.json";


        public List<Item> Itens { get; set; }
        public List<Cliente> Clientes { get; set; }
        public List<Tema> Temas { get; set; }

        public ContextoDados()
        {
            Itens = new List<Item>();
            Clientes = new List<Cliente>();
            Temas = new List<Tema>();
        }

        public ContextoDados(bool carregarDados) : this()
        {
            if (carregarDados)
                CarregarDados();
        }

        public void Gravar()
        {
            FileInfo arquivo = new FileInfo(caminho);

            arquivo.Directory.Create();

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve
            };

            byte[] registrosEmBytes = JsonSerializer.SerializeToUtf8Bytes(this, options);

            File.WriteAllBytes(caminho, registrosEmBytes);
        }

        protected void CarregarDados()
        {
            FileInfo arquivo = new FileInfo(caminho);

            if (!arquivo.Exists)
                return;

            byte[] registrosEmBytes = File.ReadAllBytes(caminho);

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };

            ContextoDados ctx = JsonSerializer.Deserialize<ContextoDados>(registrosEmBytes, options);

            if (ctx == null)
                return;

            Itens = ctx.Itens;
            Clientes = ctx.Clientes;
            Temas = ctx.Temas;
        }
    }
}