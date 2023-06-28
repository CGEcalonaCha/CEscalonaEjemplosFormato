using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos
{
    ///Herencia 
    public class Cuadrado : Figuras_Geometricas
    {
        ///Instancia de una clase 
        Figuras_Geometricas Figuras_Geometricas = new Figuras_Geometricas();
        /// Polimorfismo
        public string CalcularArea()
        {
            return "Calcula el area triangulo";
        }
        public string CulcularArea()
        {
            return "Calcula el area del Cuadrado";
        }

        //Abstracion
        /// Objeto de la vida real Cuadrado
        /// ////Metodos 
        public void iCalcularArea()
        {

        }
        public void CalcularPerimetro()
        {

        }
        public void ObtenerTipo()
        {

        }
        public void Obtener()
        {

        }
        //////Atributos /// Propiedades 
        public Decimal Area { get; set; }
        public Decimal Lado { get; set; }
        public Decimal Perimetro { get; set; }
        public Decimal Tipo { get; set; }
    }
}
