using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo de título é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo de diretor é obrigatório")]
        public string Diretor { get; set; }
        public string Genero { get; set; }
        [Range(1, 300, ErrorMessage = "A duração deve ser entre 1 minuto e 5 horas")]
        public int Duracao { get; set; }
    }
}
