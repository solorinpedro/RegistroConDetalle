using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroConDetalle.Entidades
{
   public class Roles
    {
        [Key]
        public int RoiID { get; set; }
        public string Descripcion { get; set; }
        public bool EsActivo { get; set; }

        [ForeignKey("RoiID")]
        public virtual List<RolesDetalle> RolesDetalle { get; set; }

        public Roles()
        {
            RoiID = 0;
            RolesDetalle = new List<RolesDetalle>();
        }
    }
}

