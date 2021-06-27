using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using WildarChallenge.Data.FormasGeometricas;

namespace WildarChallenge.Data.Impresoras
{
    struct Acumulador
    {
        public decimal Area;
        public decimal Perimetro;

        public Acumulador(decimal area, decimal perimetro)
        {
            this.Area = area;
            this.Perimetro = perimetro;
        }
    }

    public class ImpresoraFormaGeometrica
    {
        public IConstructorMensaje ConstructorMensaje { get; set; }
        public ImpresoraFormaGeometrica(IConstructorMensaje constructorMensaje)
        {
            this.ConstructorMensaje = constructorMensaje;
        }

        public string Imprimir(ICollection<IFormaGeometrica> formasGeometricas)
        {

            if (formasGeometricas.Count == 0)
            {
                return $"<h1>{this.ConstructorMensaje.ListaDeFormasVacia()}</h1>";
            }

            StringBuilder sb = new StringBuilder();
            int cantidadFormas = 0;
            decimal area = 0m;
            decimal perimetro = 0m;

            sb.Append($"<h1>{this.ConstructorMensaje.ReporteDeFormas()}</h1>");
            IEnumerable<IGrouping<TipoFormaGeometrica, IFormaGeometrica>> formasAgupadas =
                formasGeometricas.GroupBy(forma => forma.Tipo);

            foreach (var agrupadas in formasAgupadas)
            {
                //Se filtran las formas obtenidas en base al tipo actual.
                //IEnumerable<IFormaGeometrica> formasFiltradas = formasAgupadas.Where(forma => forma.Tipo == agrupadas.Key);
                int cantidad = agrupadas.Count();

                if (cantidad == 0)
                {
                    continue;
                }

                //Se acumula el area y el perimetro
                Acumulador acumulado = agrupadas.Aggregate(
                    new Acumulador(0m, 0m),
                    (acum, forma) => new Acumulador(acum.Area + forma.CalcularArea(), acum.Perimetro + forma.CalcularPerimetro())
                );



                //Se agrega lo calculado a los totalizadores
                cantidadFormas += cantidad;
                area += acumulado.Area;
                perimetro += acumulado.Perimetro;

                bool plural = cantidad != 1;
                sb.Append($"{cantidad} {this.ConstructorMensaje.NombreForma(agrupadas.Key, plural)}");
                sb.Append($" | {this.ConstructorMensaje.Area()} {acumulado.Area:#.##}");
                sb.Append($" | {this.ConstructorMensaje.Perimetro()} {acumulado.Perimetro:#.##}");
                sb.Append(" <br/>");
            }

            /*
            foreach (TipoFormaGeometrica enumType in  Enum.GetValues(typeof(TipoFormaGeometrica)))
            {
                //Se filtran las formas obtenidas en base al tipo actual.
                IEnumerable<IFormaGeometrica> formasFiltradas = formasGeometricas.Where(forma => forma.Tipo == enumType);
                int cantidad = formasFiltradas.Count();

                if (cantidad == 0)
                {
                    continue;
                }

                //Se acumula el area y el perimetro
                Acumulador acumulado = formasFiltradas.Aggregate(
                    new Acumulador(0m, 0m),
                    (acum, forma) => new Acumulador(acum.Area + forma.CalcularArea(), acum.Perimetro + forma.CalcularPerimetro())
                );

                

                //Se agrega lo calculado a los totalizadores
                cantidadFormas += cantidad;
                area += acumulado.Area;
                perimetro += acumulado.Perimetro;

                bool plural = cantidad != 1;
                sb.Append($"{cantidad} {this.ConstructorMensaje.NombreForma(enumType, plural)}");
                sb.Append($" | {this.ConstructorMensaje.Area()} {acumulado.Area:#.##}");
                sb.Append($" | {this.ConstructorMensaje.Perimetro()} {acumulado.Perimetro:#.##}");
                sb.Append(" <br/>");
            }
            */
            sb.Append($"{this.ConstructorMensaje.Total()}:<br/>");
            sb.Append($"{cantidadFormas} {this.ConstructorMensaje.Formas()} ");
            sb.Append($"{this.ConstructorMensaje.Perimetro()} {perimetro.ToString("#.##")} ");
            sb.Append($"{this.ConstructorMensaje.Area()} {area.ToString("#.##")}");

            return sb.ToString();
        }
    }
}
