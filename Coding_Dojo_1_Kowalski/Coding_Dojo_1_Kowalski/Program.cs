using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Dojo_1_Kowalski
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            char inputeinheit;
            //inputeinheit solange eingeben bis gültig
            do {
                inputeinheit = Convert.ToChar(Console.ReadLine());
            } while (!validate(inputeinheit));

            Console.WriteLine("Wert eingeben:");
            float value = Convert.ToSingle(Console.ReadLine());
            switch (inputeinheit)
                {
                    case 'f':
                        value = FahrenheitCelsius(value);
                        break;
                    case 'r':
                        value = ReamurCelsius(value);
                        break;
                    case 'k':
                        value = KelvinCelsius(value);
                        break;
                    case 'c':
                        break;

                }
            Console.WriteLine("Outputeinheit eingeben [c, r, f, k]:");
            char outputeinheit;
            //outputeinheit eingeben solange bis gültig
            do
            {
                outputeinheit = Convert.ToChar(Console.ReadLine());
            }while (!validate(outputeinheit));
            
            // resultate berechnen
            float kelvinvalue = CelsiusKelvin(value);
            float fahrenheitvalue = CelsiusFahrenheit(value);
            float reamurvalue = CelsiusReamur(value);

            //gewünschten Output generieren
            switch (outputeinheit)
            {
                case 'f':
                    Console.WriteLine("Output: {0} Fahrenheit", fahrenheitvalue);
                    break;
                case 'r':
                    Console.WriteLine("Output: {0} Reamur", reamurvalue);
                    break;
                case 'k':
                    Console.WriteLine("Output: {0} Kelvin", kelvinvalue);
                    break;
                case 'c':
                    Console.WriteLine("Output: {0} Celsius", value);
                    break;

            }
            Console.ReadLine();
        }

        private static float CelsiusReamur(float value)
        {
            return value * 0.8f;
        }

        private static float CelsiusFahrenheit(float value)
        {
            return value * 1.8f + 32;
        }

        private static float CelsiusKelvin(float value)
        {
            return value + 273.15f;
        }

        private static bool validate(char inputeinheit)
        {
            if (inputeinheit == 'k' || inputeinheit == 'c' || inputeinheit == 'r' || inputeinheit == 'f')
            {
                Console.WriteLine("Gültige Einheit ausgewählt.");
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private static float KelvinCelsius(float v)
        {
            return v - 273.15f;
        }

        private static float ReamurCelsius(float v)
        {
            return v*1.25f;
        }

        private static float FahrenheitCelsius(float v)
        {
            return (v - 32) * (5f / 9f);
        }

        private static void Menu()
        {
            Console.WriteLine("Willkommen beim Coding Dojo 1! Bitte geben Sie die Input-Einheit ein:\nCelsius = c, Fahrenheit = f, Reamur = r, Kelvin = k");
        }
    }
}
