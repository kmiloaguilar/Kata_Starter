using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata.specs
{
    public class cuando_envio_una_cadena_vacia
    {
        static Calculadora calculadora;
        static int _resultado;
        Establish contexto = () => 
        {
            calculadora = new Calculadora();
        };

        Because of = () => _resultado = calculadora.Sumar("");

        It deberia_retornar_0 = () => _resultado.ShouldEqual(0);
    }
}
