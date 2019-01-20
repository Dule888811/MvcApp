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
        public Document()
        {
            _ukupno = 0;
            Tasks = new List<Task>();
        }

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

        int? _ukupno;
        public int? Ukupno
        {
            get
            {
                return this._ukupno;
            }
        
            set
            {
                int zbir = 0;
                foreach (var v in Tasks)
                {
                    zbir += v.Kolicina;

               }
                this._ukupno = zbir;
            }

        }
        public ICollection<Task> Tasks { get; set; }


        // DocumentDBContext bi trebao biti zasebna klasa, a ne sub klasa u okviru Document klase. Ali radi i ovako pa ti to nisam menjao.
        public class DocumentDBContext : DbContext
        {
            public DbSet<Document> Document { get; set; }
        }
    }



}

