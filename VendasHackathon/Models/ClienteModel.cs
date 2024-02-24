using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendasHackathon.Models
{
    [Table("tb_clientes")]
    public class ClienteModel
    {
        [Key]
        [Column("id_cliente")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do cliente deve ser informado!")]
        [Column("nome_cliente")]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O CPF do cliente deve ser informado!")]
        [Column("cpf_cliente")]
        [StringLength(11)]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "A data de nascimento do cliente deve ser informada!")]
        [Column("data_nasc_cliente")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime DataNascimento { get; set; }
    }
}
