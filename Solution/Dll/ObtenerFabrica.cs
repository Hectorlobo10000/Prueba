namespace Dll
{
    public class ObtenerFabrica
    {
        public static void ConfiguracionFabrica(string operador)
        {
            IOperaciones operar = null;
            if (operador == "+")
            {
                operar = new SumarNumero();
            }
            else if (operador == "-")
            {
                operar = new RestarNumero();
            }
            else if (operador == "*")
            {
                operar = new MultiplicarNumero();
            }
            else if (operador == "/")
            {
                operar = new DividirNumero();
            }
           return operar;
        }
    }
}