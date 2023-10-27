using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1_encuestas.Modelo
{
class Evaluador
{
    List<Comentario> comentarios = new List<Comentario>();
    static Random azar = new Random();
    public List<Comentario> Evaluar(List<Comentario> entrada)
    {
        List<Comentario> salida = entrada;
        foreach (Comentario c in entrada)
        {
            c.Valoracion = azar.Next(0, 6);
        }
        return salida;
    }
}
 }
