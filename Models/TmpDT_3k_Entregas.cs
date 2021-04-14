namespace WebAPI_DT_3k.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TmpDT_3k_Entregas
    {
        public int Campania { get; set; }

        public int Despacho { get; set; }

        public int Manifiesto { get; set; }

        [Key]
        [StringLength(20)]
        public string Pedido { get; set; }

        [StringLength(120)]
        public string Id { get; set; }

        [StringLength(120)]
        public string DestinoFinal { get; set; }

        [StringLength(120)]
        public string Depto { get; set; }

        [StringLength(120)]
        public string Ciudad { get; set; }

        [StringLength(250)]
        public string Direccion { get; set; }

        [StringLength(120)]
        public string Tel { get; set; }

        public double Asignado { get; set; }

        [StringLength(120)]
        public string Conductor { get; set; }

        public double? Cond_Celular { get; set; }

        [StringLength(100)]
        public string Vehi_Placa { get; set; }

        [StringLength(100)]
        public string Vehi_Tipo { get; set; }

        [StringLength(100)]
        public string Vehi_Color { get; set; }

        public int? Relacion_Id { get; set; }

        public DateTime? Relacion_Fec { get; set; }

        public double? PreRuta { get; set; }

        public int? Estado { get; set; }

        public int? Causal_Id { get; set; }

        public DateTime? Entrega_Fec { get; set; }

        public Byte[] Foto { get; set; }

        public double? Lat { get; set; }

        public double? Lng { get; set; }

        public double? Prec { get; set; }
    }
}
