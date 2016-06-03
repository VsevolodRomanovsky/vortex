using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnstileCodeFirst
{
    public class Visitor
    {
        public int Id { get; set; }
        public int PermitId { get; set; } //ID таблетки

        [StringLength(200)]
        public string FirstName { get; set; }

        [StringLength(200)]
        public string LastName { get; set; }

        [StringLength(200)]
        public string MiddleName { get; set; }
        public bool IsValid { get; set; } //дуйствует пропуск или нет
        public DateTime RegistrationDate { get; set; } //дата первой регистрации
        public byte[] Picture { get; set; }

        public virtual List<Visit> Visits { get; set; }

        public Visitor()
        {
            this.Visits = new List<Visit>();
        }
    }
}
