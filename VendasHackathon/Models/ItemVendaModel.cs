using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendasHackathon.Models
{
    [Table("tb_itens_vendas")]
    public class ItemVendaModel
    {
        [Key]
        [Column("id_item_venda")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe a descrição da venda!")]
        [Column("desc_venda")]
        [StringLength(60)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Informe o valor unitário da venda!")]
        [Column("valor_unit_venda")]
        public decimal ValorUnitario { get; set; }

        [Required(ErrorMessage = "Informe a quantidade do item da venda!")]
        [Column("qtd_venda")]
        public int Quantidade { get; set; }

        [Required]
        [Column("id_venda_associada")]
        public int VendaId { get; set; }

        // Propriedade de navegação do objeto venda
        public virtual VendaModel Venda { get; set; }

       /* 
        * Essa maneira foi sugerida pelo Felipe Euzébio, iremos ver se ela é apropriada na reta final de desenvolvimento.
        * 
        * 
        
        [NotMapped]
        public decimal ValorTotal
        {
            get
            {
                return ValorUnitario * Quantidade;
            }
        }
       
        */

        public decimal CalcularValorTotalVenda()
        {
            decimal valorTotal = ValorUnitario * Quantidade;
            return valorTotal;
        }

    }
}
