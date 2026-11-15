namespace Sesion09
{
    public class ConversorTemperatura
    {
        public double Convertir(double valor, string origen, string destino)
        {
           
            if (origen == destino) return valor;

           
            double enCelsius = origen switch
            {
                "°C" => valor,
                "°F" => (valor - 32) * 5.0 / 9.0,
                "K" => valor - 273.15,
                _ => valor
            };

            double resultado = destino switch
            {
                "°C" => enCelsius,
                "°F" => (enCelsius * 9.0 / 5.0) + 32,
                "K" => enCelsius + 273.15,
                _ => enCelsius
            };

            return resultado;
        }
    }
}