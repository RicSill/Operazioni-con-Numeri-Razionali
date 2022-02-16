using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazioni_Esame
{
    public class Frazione
    {
        public int Numeratore { get; set; }

        public int Denominatore { get; set; }

        //public double Value { get; set; }

        public Frazione()
        {
            Numeratore = 0;
            Denominatore = 1;
            //Value = this.Numeratore / this.Denominatore;
        }

        public Frazione(int numeratore, int denominatore)
        {
            this.Numeratore = numeratore;
            this.Denominatore = denominatore;
            //this.Value = numeratore / denominatore;
        }

        public override string ToString()
        {
            return Numeratore + "/" + Denominatore;
        }

        public static Frazione Addizione(Frazione f1, Frazione f2)
        {
            Frazione addizione = new Frazione();
            int num1, num2;
            num1 = f1.Numeratore * f2.Denominatore;
            num2 = f2.Numeratore * f1.Denominatore;
            addizione.Numeratore = num1 + num2;
            addizione.Denominatore = f1.Denominatore * f2.Denominatore;
            addizione.Semplifica();
            return addizione;
        }

        public static Frazione Sottrazione(Frazione f1, Frazione f2)
        {
            Frazione sottrazione = new Frazione();
            int num1, num2;
            num1 = f1.Numeratore * f2.Denominatore;
            num2 = f2.Numeratore * f1.Denominatore;
            sottrazione.Numeratore = num1 - num2;
            sottrazione.Denominatore = f1.Denominatore * f2.Denominatore;
            sottrazione.Semplifica();
            return sottrazione;
        }

        public static Frazione Moltiplicazione(Frazione f1, Frazione f2)
        {
            Frazione moltiplicazione = new Frazione();
            moltiplicazione.Numeratore = f1.Numeratore * f2.Numeratore;
            moltiplicazione.Denominatore = f1.Denominatore * f2.Denominatore;
            moltiplicazione.Semplifica();
            return moltiplicazione;
        }

        public static Frazione Divisione(Frazione f1, Frazione f2)
        {
            Frazione divisione = new Frazione();
            divisione.Numeratore = f1.Numeratore * f2.Denominatore;
            divisione.Denominatore = f2.Numeratore * f1.Denominatore;
            divisione.Semplifica();
            return divisione;
        }
        public void Semplifica()
        {
            int gcd = 0;
            for (int x = 1; x >= Denominatore; x++)
            {
                if ((Numeratore % x == 0) && (Denominatore % x == 0))
                    gcd = x;
            }
            if (gcd != 0)
            {
                Numeratore = Numeratore / gcd;
                Denominatore = Denominatore / gcd;
            }
        }


    }
}
