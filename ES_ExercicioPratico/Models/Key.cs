using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ES_ExercicioPratico.Models
{
    public class Key
    {
        public Key()
        {
            CreatedAt = DateTime.Now;
            IsRandomKey = false; 
        }

        [Key]
        public Guid Id { get; set; }

        #region numbers
        [Required, Range(1, 50), DisplayName("1")]
        public int? Number1 { get; set; }
        [Required, Range(1, 50), DisplayName("2")]
        public int? Number2 { get; set; }
        [Required, Range(1, 50), DisplayName("3")]
        public int? Number3 { get; set; }
        [Required, Range(1, 50), DisplayName("4")]
        public int? Number4 { get; set; }
        [Required, Range(1, 50), DisplayName("5")]
        public int? Number5 { get; set; }
        #endregion

        #region stars
        [Required, Range(1, 11), DisplayName("1 ⭐")]
        public int? Star1 { get; set; }
        [Required, Range(1, 11), DisplayName("2 ⭐")]
        public int? Star2 { get; set; }
        #endregion

        [DisplayName("Data"), DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
        
        [DisplayName("Utilizador")]
        public string User { get; set; }

        [DisplayName("Chave aleatória?")]
        public bool IsRandomKey { get; set; }

        [NotMapped, DisplayName("Nº certos")]
        public int CorrectNumbers { get; set; }

        [NotMapped, DisplayName("Estrelas certas")]
        public int CorrectStars { get; set; }
        
        [NotMapped, DisplayName("Prémio")]
        public string? Prize { get; set; }

        public bool IsValid()
        {
            int?[] selectedKeyNumbers = new[] { Number1, Number2, Number3, Number4, Number5 };
            int?[] selectedKeyStars = new[] { Star1, Star2 };

            return selectedKeyNumbers.Distinct().Count() == 5 && selectedKeyStars.Distinct().Count() == 2;

            //Most simple possible
            //return (Number1 != Number2 && Number1 != Number3 && Number1 != Number4 && Number1 != Number5 &&
            //    Number2 != Number3 && Number2 != Number4 && Number2 != Number5 &&
            //    Number3 != Number4 && Number3 != Number5 &&
            //    Number4 != Number5 &&
            //    Star1 != Star2);
        }

        public string PrizePosition(Key selectedKey)
        {
            int?[] selectedKeyNumbers = new[] { selectedKey.Number1, selectedKey.Number2, selectedKey.Number3, selectedKey.Number4, selectedKey.Number5 };
            int?[] selectedKeyStars = new[] { selectedKey.Star1, selectedKey.Star2 };

            int?[] keyNumbers = new[] { this.Number1, this.Number2, this.Number3, this.Number4, this.Number5 };
            int?[] keyStars = new[] { this.Star1, this.Star2 };

            int correctNumbers = selectedKeyNumbers.Intersect(keyNumbers).Count();
            CorrectNumbers = correctNumbers;

            int correctStars = selectedKeyStars.Intersect(keyStars).Count();
            CorrectStars = correctStars;

            if (correctNumbers == 5 && correctStars == 2)
            {
                return "1º prémio";
            }

            if (correctNumbers == 5 && correctStars == 1)
            {
                return "2º prémio";
            }

            if (correctNumbers == 5)
            {
                return "3º prémio";
            }

            if (correctNumbers == 4 && correctStars == 2)
            {
                return "4º prémio";
            }

            if (correctNumbers == 4 && correctStars == 1)
            {
                return "5º prémio";
            }

            if (correctNumbers == 3 && correctStars == 2)
            {
                return "6º prémio";
            }

            if (correctNumbers == 4)
            {
                return "7º prémio";
            }

            if (correctNumbers == 3 && correctStars == 2)
            {
                return "8º prémio";
            }

            if (correctNumbers == 3 && correctStars == 1)
            {
                return "9º prémio";
            }

            if (correctNumbers == 3)
            {
                return "10º prémio";
            }

            if (correctNumbers == 1 && correctStars == 2)
            {
                return "11º prémio";
            }

            if (correctNumbers == 2 && correctStars == 1)
            {
                return "13º prémio";
            }

            if (correctNumbers == 2)
            {
                return "13º prémio";
            }

            return "Sem prémio";
        }
    }
}
