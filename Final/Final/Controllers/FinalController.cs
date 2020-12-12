using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Final.Controllers
{
    public class FinalController : ApiController
    {
        public string operaciones(int numero) 
        {
            string mensaje;
            if (numero<0)
            {
                mensaje = "ERROR";
            }
            else
            {
                if (numero==0)
                {
                    mensaje = "Realizado por Cristhian Arispe Vargas";
                }
                else
                {
                    mensaje = "https://image.freepik.com/vector-gratis/numeros-cartel-imagen_1639-6453.jpg";
                }
            }
            return mensaje;
        }
    }
}
