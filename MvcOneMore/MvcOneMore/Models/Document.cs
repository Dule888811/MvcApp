using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOneMore.Models
{
    public class Document
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(10)]
      //  [Remote("IsExist", "Place", ErrorMessage = "BrojDokumenta exist!")]
        public string BrojDokumenta { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Datum
        {
            get
            {
                return DateTime.Now;
            }
        }

        public int? Ukupno
        {
            get
            {
                return this.Ukupno;
            }
        
            set
            {
                int zbir = 0;
                foreach (var v in Tasks)
                {
                    zbir += v.Kolicina;

               }
                this.Ukupno = zbir;
            }

        }
        public ICollection<Task> Tasks { get; set; }


        public class DocumentDBContext : DbContext
        {
            public DbSet<Document> Document { get; set; }
        }
    }



}

