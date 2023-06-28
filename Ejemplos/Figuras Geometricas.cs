using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos
{
    ///Plantilla de metodos y atributos
    public  class Figuras_Geometricas
    {
        ////Metodos 
        public void CalcularArea()
        {

        }
        public void CalcularPerimetro()
        {

        }
        public void ObtenerTipo()
        {

        }
        public void ObtenerLado()
        {

        }
        //////Atributos
        public Decimal Area { get; set; }
        public Decimal Lado { get; set; }
        public Decimal Perimetro { get; set; }
        public Decimal Tipo { get; set; }
        ///Cobnstructor 
        private decimal area;
        private decimal perimetro;
        private decimal tipo;
        private decimal lado;

        //Sobrecarga Metodos
        public void CalculaPerimetro()
        {

        }
        public void CalculaPerimetro(decimal Perimetro)
        {
            
        }
        ////Sobre Carga Construtores 
        public  string IPerimetro;
        public decimal ICalculaPerimetro;
        

            }
}
