using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Calculos
    {

        public double resK;
        public double resFlujLum;
        public double resNumLamp;
        public double resIlum;
        public double anchoLamp;
        public double largoLamp;
        public double sepLampLargo;
        public double sepLampAncho;
        public double sepParedLargo;
        public double sepParedAncho;
        public double LampTotal;
        public double PotTotal;



        public string IndiceK(string largo, string ancho, string altura)
        {
            Double Largo = Convert.ToDouble(largo);
            Double Ancho = Convert.ToDouble(ancho);
            Double Altura = Convert.ToDouble(altura);


            resK = Largo * Ancho / (Altura * (Largo + Ancho));

            return Convert.ToString(resK);
        }

        public string FlujoLuminoso(string largo, string ancho, string ilumSol, string mant, string utiliz)
        {

            Double Largo = Convert.ToDouble(largo);
            Double Ancho = Convert.ToDouble(ancho);
            Double IlumSol = Convert.ToDouble(ilumSol);
            Double Mant = Convert.ToDouble(mant);
            Double Utiliz = Convert.ToDouble(utiliz);

            resFlujLum = (Largo * Ancho * IlumSol) / (Utiliz * Mant);

            return Convert.ToString(resFlujLum);

        }

        public string NumLamp(string lumenes)
        {
            Double Lumenes = Convert.ToDouble(lumenes);

            resNumLamp = Math.Ceiling(resFlujLum / Lumenes);

            return Convert.ToString(resNumLamp);
        }

        public string Iluminancia(string potencia, string lumenes, string mant, string utiliz, string largo, string ancho)
        {
            Double Largo = Convert.ToDouble(largo);
            Double Ancho = Convert.ToDouble(ancho);
            Double Mant = Convert.ToDouble(mant);
            Double Utiliz = Convert.ToDouble(utiliz);
            Double Lumenes = Convert.ToDouble(lumenes);
            Double Potencia = Convert.ToDouble(potencia);

            resIlum = (resNumLamp * Lumenes * Utiliz * Mant) / (Largo * Ancho);

            return Convert.ToString(resIlum);
        }

        public string[] LampFinales(string ancho, string largo, string nlamp, string potencia)
        {
            string [] LampFinales = new string[8];

            Double Largo = Convert.ToDouble(largo);
            Double Ancho = Convert.ToDouble(ancho);
            Double NLamp = Convert.ToDouble(nlamp);
            Double Potencia = Convert.ToDouble(potencia);

            anchoLamp = Math.Sqrt((NLamp / Largo) * Ancho);

            largoLamp = Math.Ceiling(anchoLamp * (Largo / Ancho));


            sepLampLargo = Largo / largoLamp;

            sepLampAncho = Ancho / Math.Ceiling(anchoLamp);

            sepParedLargo = sepLampLargo / 2;

            sepParedAncho = sepLampAncho / 2;

            LampTotal = largoLamp * Math.Ceiling(anchoLamp);

            PotTotal = LampTotal * Potencia;
            
            LampFinales[0] = Convert.ToString(Math.Ceiling(anchoLamp)); 

            LampFinales[1] = Convert.ToString(largoLamp); 

            LampFinales[2] = Convert.ToString(sepLampLargo); 

            LampFinales[3] = Convert.ToString(sepLampAncho); 

            LampFinales[4] = Convert.ToString(sepParedLargo);

            LampFinales[5] = Convert.ToString(sepParedAncho);

            LampFinales[6] = Convert.ToString(LampTotal);

            LampFinales[7] = Convert.ToString(PotTotal);

            return LampFinales;


        }


    }



}



