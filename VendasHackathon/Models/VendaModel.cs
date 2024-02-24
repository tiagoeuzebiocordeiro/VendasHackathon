using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendasHackathon.Models
{
    [Table("tb_vendas")]
    public class VendaModel
    {
        [Key]
        [Column("id_venda")]
        public int Id { get; set; }
        [Required]
        [Column("id_cliente_associado")]
        public int ClienteId { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "0:{dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        [Column("data_efetuacao_venda")]
        public DateTime DataVenda { get; set; }

        // Propriedade de navegação, verificar se futuramente será possivel cadastrar sem passar como null.
        public virtual ClienteModel Cliente { get; set; }
        public ICollection<ItemVendaModel> ItemsVenda { get; set; } = new List<ItemVendaModel>();
    }
}
