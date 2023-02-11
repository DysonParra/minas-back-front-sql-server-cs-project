/*
 * @fileoverview    {FicherosProveedor} se encarga de realizar tareas específicas.
 *
 * @version         2.0
 *
 * @author          Dyson Arley Parra Tilano <dysontilano@gmail.com>
 *
 * @copyright       Dyson Parra
 * @see             github.com/DysonParra
 *
 * History
 * @version 1.0     Implementación realizada.
 * @version 2.0     Documentación agregada.
 */
using System;
using System.ComponentModel.DataAnnotations;

/**
 * TODO: Definición de {@code FicherosProveedor}.
 *
 * @author Dyson Parra
 */
namespace Project.Models {

    public class FicherosProveedor {

        [Key]
        public String? StrCif { get; set; }
        public String? StrNombre { get; set; }
        public Int32? IntTopeMensual { get; set; }
        public DateTime? DtFechaHoraCarga { get; set; }
        public String? StrIdUsuario { get; set; }

    }

}