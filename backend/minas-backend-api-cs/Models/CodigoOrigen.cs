/*
 * @fileoverview    {CodigoOrigen}
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
 * TODO: Definición de {@code CodigoOrigen}.
 *
 * @author Dyson Parra
 */
namespace Project.Models {

    public class CodigoOrigen {

        [Key]
        public Int32? IntId { get; set; }
        public String? StrCodigo { get; set; }

    }

}