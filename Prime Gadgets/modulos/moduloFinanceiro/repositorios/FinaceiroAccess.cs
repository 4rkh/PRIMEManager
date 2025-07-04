﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prime_Gadgets.modulos.moduloFinanceiro
{
    internal class FinanceiroAccess
    {
        public string caminhoRelativo = "modulos\\moduloFinanceiro\\repositorios\\Gastos.prime";
        public string caminho;

        public FinanceiroAccess()
        {
            try
            {
                string diretorioProjeto = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                caminho = Path.Combine(diretorioProjeto, caminhoRelativo);

                // Garante que o diretório existe
                Directory.CreateDirectory(Path.GetDirectoryName(caminho));

                if (!File.Exists(caminho))
                {
                    File.Create(caminho).Dispose();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema ao tentar acessar o arquivo Gastos.prime: " + e.Message);
            }
        }

        // Salva todo o conteúdo do DataGridView no arquivo Gastos.prime (sem o ID vindo do DataGridView)
        public void SalvarGastos(DataGridView dgv)
        {
            try
            {
                // Lê os gastos existentes para saber o último ID
                var gastosExistentes = LerGastos();
                int proximoId = gastosExistentes.Any() ? gastosExistentes.Max(g => g.Id) + 1 : 1;

                using (StreamWriter sw = new StreamWriter(caminho, false, Encoding.UTF8))
                {
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string descricao = row.Cells[0].Value?.ToString() ?? "";
                        string valorStr = row.Cells[1].Value?.ToString() ?? "";
                        valorStr = valorStr.Replace(',', '.');
                        decimal valor = decimal.TryParse(valorStr, NumberStyles.Any, CultureInfo.InvariantCulture, out var v) ? v : 0;

                        string diaStr = row.Cells[2].Value?.ToString() ?? "";
                        int dia = int.TryParse(diaStr, out var d) ? d : 1;
                        DateTime data = DateTime.Now;
                        try { data = new DateTime(DateTime.Now.Year, DateTime.Now.Month, dia); } catch { }

                        string categoria = row.Cells[3].Value?.ToString() ?? "";
                        string formaPagamento = row.Cells[4].Value?.ToString() ?? "";
                        string observacoes = row.Cells[5].Value?.ToString() ?? "";

                        // Gera o ID automaticamente
                        int id = proximoId++;

                        string linha = $"{id};{descricao};{valor.ToString(CultureInfo.InvariantCulture)};{data:yyyy-MM-dd};{categoria};{formaPagamento};{observacoes}";
                        sw.WriteLine(linha);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao salvar os gastos: " + e.Message);
            }
        }

        // Salva os gastos do DataGridView no arquivo Gastos.prime, filtrando por mês e ano (sem depender do ID do DataGridView)
        public void SalvarGastos(DataGridView dgv, int mes, int ano)
        {
            try
            {
                var todosGastos = LerGastos();

                // IDs dos gastos que estão atualmente no DataGridView
                var idsNoGrid = new HashSet<int>();

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow) continue;

                    string descricao = row.Cells[0].Value?.ToString() ?? "";
                    string valorStr = row.Cells[1].Value?.ToString() ?? "";
                    valorStr = valorStr.Replace(',', '.');
                    decimal valor = decimal.TryParse(valorStr, NumberStyles.Any, CultureInfo.InvariantCulture, out var v) ? v : 0;

                    string diaStr = row.Cells[2].Value?.ToString() ?? "";
                    int dia = int.TryParse(diaStr, out var d) ? d : 1;
                    DateTime data = new DateTime(ano, mes, dia);

                    string categoria = row.Cells[3].Value?.ToString() ?? "";
                    string formaPagamento = row.Cells[4].Value?.ToString() ?? "";
                    string observacoes = row.Cells[5].Value?.ToString() ?? "";

                    // Procura se já existe um gasto igual (por descrição, valor, data, categoria, formaPagamento, observações)
                    var gastoExistente = todosGastos.FirstOrDefault(g =>
                        g.Descricao == descricao &&
                        g.Valor == valor &&
                        g.Data == data &&
                        g.Categoria == categoria &&
                        g.FormaPagamento == formaPagamento &&
                        g.Observacoes == observacoes
                    );

                    if (gastoExistente != null)
                    {
                        // Atualiza o registro existente
                        gastoExistente.Descricao = descricao;
                        gastoExistente.Valor = valor;
                        gastoExistente.Data = data;
                        gastoExistente.Categoria = categoria;
                        gastoExistente.FormaPagamento = formaPagamento;
                        gastoExistente.Observacoes = observacoes;
                        idsNoGrid.Add(gastoExistente.Id);
                    }
                    else
                    {
                        // Gera novo ID
                        int novoId = todosGastos.Any() ? todosGastos.Max(g => g.Id) + 1 : 1;
                        var novoGasto = new Gasto
                        {
                            Id = novoId,
                            Descricao = descricao,
                            Valor = valor,
                            Data = data,
                            Categoria = categoria,
                            FormaPagamento = formaPagamento,
                            Observacoes = observacoes
                        };
                        todosGastos.Add(novoGasto);
                        idsNoGrid.Add(novoId);
                    }
                }

                // Remove gastos do mês/ano que não estão mais no DataGridView
                todosGastos.RemoveAll(g =>
                    g.Data.Month == mes &&
                    g.Data.Year == ano &&
                    !idsNoGrid.Contains(g.Id)
                );

                // Salva todos os gastos de volta no arquivo, sobrescrevendo
                using (StreamWriter sw = new StreamWriter(caminho, false, Encoding.UTF8))
                {
                    foreach (var g in todosGastos.OrderBy(g => g.Id))
                    {
                        string linha = $"{g.Id};{g.Descricao};{g.Valor.ToString(CultureInfo.InvariantCulture)};{g.Data:yyyy-MM-dd};{g.Categoria};{g.FormaPagamento};{g.Observacoes}";
                        sw.WriteLine(linha);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao salvar os gastos: " + e.Message);
            }
        }

        // Lê todos os gastos do arquivo Gastos.prime
        public List<Gasto> LerGastos()
        {
            var gastos = new List<Gasto>();
            try
            {
                var linhas = File.ReadAllLines(caminho, Encoding.UTF8);
                foreach (var linha in linhas)
                {
                    if (string.IsNullOrWhiteSpace(linha)) continue;
                    var campos = linha.Split(';');
                    if (campos.Length >= 7)
                    {
                        gastos.Add(new Gasto
                        {
                            Id = int.TryParse(campos[0], out int id) ? id : 0,
                            Descricao = campos[1],
                            Valor = decimal.TryParse(campos[2], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal valor) ? valor : 0,
                            Data = DateTime.TryParse(campos[3], out DateTime data) ? data : DateTime.MinValue,
                            Categoria = campos[4],
                            FormaPagamento = campos[5],
                            Observacoes = campos[6]
                        });
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao ler os gastos: " + e.Message);
            }
            return gastos;
        }

        // Filtra os gastos por mês e ano
        public List<Gasto> FiltrarGastosPorMesAno(int mes, int ano)
        {
            var todos = LerGastos();
            return todos.Where(g => g.Data.Month == mes && g.Data.Year == ano).ToList();
        }

        // Preenche um DataTable com os gastos
        public DataTable PreencherDataTable(List<Gasto> gastos, List<string> formasValidas)
        {
            var dt = new DataTable();
            dt.Columns.Add("Descrição", typeof(string));
            dt.Columns.Add("Valor", typeof(string)); // <-- ALTERADO para string
            dt.Columns.Add("Dia", typeof(int));
            dt.Columns.Add("Categoria", typeof(string));
            dt.Columns.Add("Forma de Pagamento", typeof(string));
            dt.Columns.Add("Observações", typeof(string));

            foreach (var gasto in gastos)
            {
                var forma = formasValidas.Contains(gasto.FormaPagamento) ? gasto.FormaPagamento : formasValidas[0];
                dt.Rows.Add(
                    gasto.Descricao,
                    gasto.Valor.ToString(CultureInfo.InvariantCulture), // <-- Salva como string com ponto
                    gasto.Data.Day,
                    gasto.Categoria,
                    forma,
                    gasto.Observacoes
                );
            }

            return dt;
        }
    }
}
