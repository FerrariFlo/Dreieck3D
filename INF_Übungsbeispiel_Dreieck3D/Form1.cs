namespace INF_Übungsbeispiel_Dreieck3D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            try
            {
                // Eingabewerte für Punkt A
                double x1 = Convert.ToDouble(txtAX.Text);
                double y1 = Convert.ToDouble(txtAY.Text);
                double z1 = Convert.ToDouble(txtAZ.Text);

                // Eingabewerte für Punkt B
                double x2 = Convert.ToDouble(txtBX.Text);
                double y2 = Convert.ToDouble(txtBY.Text);
                double z2 = Convert.ToDouble(txtBZ.Text);

                // Berechnungen
                double abstandAB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
                double abstandA0 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2) + Math.Pow(z1, 2));
                double abstandB0 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2) + Math.Pow(z2, 2));

                // Vektoren OA und OB
                double[] oa = { x1, y1, z1 };
                double[] ob = { x2, y2, z2 };

                // Fläche des Dreiecks
                double flaecheDreieck = 0.5 * Math.Sqrt(
                    Math.Pow(y1 * z2 - z1 * y2, 2) +
                    Math.Pow(z1 * x2 - x1 * z2, 2) +
                    Math.Pow(x1 * y2 - y1 * x2, 2));

                // Winkel berechnen
                double skalarProdukt = oa[0] * ob[0] + oa[1] * ob[1] + oa[2] * ob[2];
                double betragOA = Math.Sqrt(Math.Pow(oa[0], 2) + Math.Pow(oa[1], 2) + Math.Pow(oa[2], 2));
                double betragOB = Math.Sqrt(Math.Pow(ob[0], 2) + Math.Pow(ob[1], 2) + Math.Pow(ob[2], 2));
                double cosWinkel = skalarProdukt / (betragOA * betragOB);
                double winkel = Math.Acos(cosWinkel) * (180 / Math.PI); // In Grad umrechnen

                // Ergebnisse anzeigen
                lblErgebnis.Text = $"Abstand A zu B: {abstandAB:F2}\n" +
                                   $"Abstand A zu Ursprung: {abstandA0:F2}\n" +
                                   $"Abstand B zu Ursprung: {abstandB0:F2}\n" +
                                   $"Fläche des Dreiecks: {flaecheDreieck:F2}\n" +
                                   $"Winkel A-0-B: {winkel:F2}°";
            }
            catch (Exception ex)
            {
                lblErgebnis.Text = $"Fehler: {ex.Message}";
            }
        }
    }
}
