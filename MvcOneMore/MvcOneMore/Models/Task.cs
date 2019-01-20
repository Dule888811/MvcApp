using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOneMore.Models
{
    public class Task
    {
        public int ID { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int Kolicina { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int Cena { get; set; }
        [Required]
        [Remote("IsExist", "Place", ErrorMessage = "BrojDokumenta exist!")]
        public int RedniBroj { get; set; }



        public int? Ukupno
        {
            get
            {
                return this.Ukupno;
            }
            set
            {
                this.Ukupno = this.Cena * this.Kolicina;
            }
        }
        [ForeignKey("Document")]
        public int DocumentID { get; set; }
        public Document Document { get; set; }

        public class TaskDBContext : DbContext
        {
            public DbSet<Task> Tasks { get; set; }
        }

    }
}