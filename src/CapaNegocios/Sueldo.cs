using System;

namespace CapaNegocios
{
    public static class Sueldo
    {
        
        private static int valorHora = 5000;
        private static int valorExtra = 7000;
        private static string afp;
        private static string salud;

        public static int SueldoBruto(int horasTrabajadas, int horasExtra) => 
            horasTrabajadas * valorHora + horasExtra * valorExtra;

        public static decimal DescuentoAfp(int sueldoBruto, string afp)
        {
            double descuento;
            switch (afp.ToLower())
            {
                case "cuprum":
                    descuento = 0.07;
                    break;
                case "modelo":
                    descuento = 0.09;
                    break;
                case "capital":
                    descuento = 0.12;
                    break;
                case "provida":
                    descuento = 0.13;
                    break;
                default:
                    throw new ArgumentException("Argumento incorrecto");
            }

            return sueldoBruto * (decimal)descuento;
        }
        public static decimal DescuentoSalud(int sueldoBruto, string sistemaSalud)
        {
            double descuento;
            switch (sistemaSalud.ToLower())
            {
                case "fonasa":
                    descuento = 0.12;
                    break;
                case "consalud":
                    descuento = 0.13;
                    break;
                case "masvida":
                    descuento = 0.14;
                    break;
                case "banmedica":
                    descuento = 0.15;
                    break;
                default:
                    throw new ArgumentException("Argumento incorrecto");
            }

            return sueldoBruto * (decimal)descuento;
        }

        public static decimal SueldoLiquido(int horasTrabajadas, int horasExtra, string afp, string sistemaSalud)
        {
            int sueldoBruto = SueldoBruto(horasTrabajadas, horasExtra);
            return (decimal)sueldoBruto - (decimal)DescuentoAfp(sueldoBruto, afp) - (decimal)DescuentoSalud(sueldoBruto, sistemaSalud);
        }
    }
}
