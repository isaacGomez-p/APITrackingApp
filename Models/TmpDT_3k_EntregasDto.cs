using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPI_DT_3k.Models
{
    public partial class TmpDT_3k_EntregasDto
    {
        public int Campania { get; set; }

        public int Despacho { get; set; }

        public int Manifiesto { get; set; }

        public string Pedido { get; set; }

        public string Id { get; set; }

        public string DestinoFinal { get; set; }

        public string Depto { get; set; }

        public string Ciudad { get; set; }

        public string Direccion { get; set; }

        public string Tel { get; set; }

        public double Asignado { get; set; }

        public string Conductor { get; set; }

        public double? Cond_Celular { get; set; }
        
        public string Vehi_Placa { get; set; }

        public string Vehi_Tipo { get; set; }

        public string Vehi_Color { get; set; }

        public int? Relacion_Id { get; set; }

        public DateTime? Relacion_Fec { get; set; }

        public double? PreRuta { get; set; }

        public int? Estado { get; set; }

        public int? Causal_Id { get; set; }

        public DateTime? Entrega_Fec { get; set; }

        public string Foto { get; set; }

        public double? Lat { get; set; }

        public double? Lng { get; set; }

        public double? Prec { get; set; }
    }
}