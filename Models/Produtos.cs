using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro_teste.Models
{
    public partial class List
    {
        List<ItemVenda> itensVenda = new List<ItemVenda>();
        new Venda
            Id,
            Nome,
            VendaId,
            ProdutoId,
            Quantidade,
            PrecoUnitario;
    }

        
    public class Produtos
    {        
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Categoria { get; set; } //Yakissoba, bebida, Acompanhamento
        public int Estoque { get; set; }
    }

    public class Venda
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; } 
        public List<ItemVenda> Itens { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal Total { get; set; }
        public string FormaPagamento { get; set; } //Dinheiro, cartão, pix
        public string Status { get; set; } //Pendente, Pago, Cancelado
    }

    public class ItemVenda
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int VendaId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal Total { get; set; }
    }

    public class Despesa
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Categoria { get; set; } //Aluguel, contas, fornecedores
    }

    public class Caixa
    {
        public DateTime Data { get; set; }
        public decimal SaldoInicial { get; set; }
        public decimal Entradas { get; set; }
        public decimal Saidas { get; set; }
        public decimal SaldoFinal { get; set; }

    }
}
