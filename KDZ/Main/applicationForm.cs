using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fractals;

namespace Main
{
    public partial class applicationForm : Form
    {
        Pen pen = new Pen(Color.Black);
        private Bitmap canvas;
        private Color endColor;

        public applicationForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            MinimumSize = new Size(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2);
            Size = MinimumSize;
            drawBox.Height = 2 * (MinimumSize.Width - 486);
            drawBox.Width = 2 * (MinimumSize.Height - 12);
            canvas = new Bitmap(multyplyingCoefficient.Value * (drawBox.Height),
                multyplyingCoefficient.Value * (drawBox.Width));

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            savePictureButton.Visible = true;
            drawBox.Visible = true;
            fractalChoiceComboBox.Visible = true;
            recursionDepthTextBox.Visible = true;
            recursionDepthLabel.Visible = true;
            drawFractalButton.Visible = true;
            lengthLabel.Visible = true;
            lengthTextBox.Visible = true;
            multyplyingCoefficient.Visible = true;
            multiplyingLabel.Visible = true;
            startColorLabel.Visible = true;
            endColorChoiceButton.Visible = true;
            endColorLabel.Visible = true;
            startColorChoiceButton.Visible = true;
            if (fractalChoiceComboBox.Text == "Обдуваемое ветром фрактальное дерево")
            {
                AngleLeftLabel.Visible = true;
                AngleLeftTextBox.Visible = true;
                AngleRightLabel.Visible = true;
                AngleRightTextBox.Visible = true;
                diminishingCoefficientLabel.Visible = true;
                diminishingCoefficientTextBox.Visible = true;
            }
            else
            {
                AngleLeftLabel.Visible = false;
                AngleLeftTextBox.Visible = false;
                diminishingCoefficientLabel.Visible = false;
                diminishingCoefficientTextBox.Visible = false;
                AngleRightLabel.Visible = false;
                AngleRightTextBox.Visible = false;
            }

            if (fractalChoiceComboBox.Text == "Круговой фрактал")
            {
                lengthLabel.Text = "Радиус";
            }
            else
            {
                lengthLabel.Text = "Длина ребра";
            }

            savePictureButton.Visible = true;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int k;
            if (!int.TryParse(recursionDepthTextBox.Text, out k) || k <= 0 || k > 20)
            {
                if (!int.TryParse(recursionDepthTextBox.Text, out k) || recursionDepthTextBox.Text == "")
                {
                    recursionDepthTextBox.Text = "1";
                }

                MessageBox.Show(
                    "Неверно введена глубина рекурсии\nПожалейте свой ПК и мою оценку, не надо рекурсию >20",
                    "Ошибка-рыбка", MessageBoxButtons.OK);
            }



        }

        private void drawFractal_Click(object sender, EventArgs e)
        {
            try
            {
                canvas = new Bitmap(2 * (Width - 387) * multyplyingCoefficient.Value,
                   2 * (Height - 95) * multyplyingCoefficient.Value);
            }
            catch (ArgumentException)
            {
            }

            try
            {
                drawBox.Image.Dispose();
            }
            catch (NullReferenceException)
            {
            }

            Color[] colour = CalculateGradient(int.Parse(recursionDepthTextBox.Text), pen.Color, endColor);
            Graphics g = Graphics.FromImage(canvas);
            drawBox.Image = canvas;
            drawBox.Width = canvas.Width;
            drawBox.Height = canvas.Height;
            PointF[] points;
            multyplyingCoefficient.Visible = false;
            multiplyingLabel.Text = "Loading...";
            switch (fractalChoiceComboBox.Text)
            {
                case "Круговой фрактал":
                    points = new PointF[1];
                    int depth = Math.Min(int.Parse(recursionDepthTextBox.Text), 8);
                    points[0] = new PointF(drawBox.Width / 2, drawBox.Height / 2);
                    CircleFractal circleFractal = new CircleFractal(colour, g, pen,
                        drawBox.Width * multyplyingCoefficient.Value, drawBox.Height * multyplyingCoefficient.Value);
                    circleFractal.Draw(depth, int.Parse(lengthTextBox.Text) * multyplyingCoefficient.Value, points, 0);
                    drawBox.Update();
                    drawBox.SizeMode = PictureBoxSizeMode.CenterImage;
                    multyplyingCoefficient.Visible = true;
                    multiplyingLabel.Text = "Увеличение";
                    GC.Collect();
                    return;
                case "Обдуваемое ветром фрактальное дерево":
                    points = new PointF[1];
                    points[0] = new PointF(drawBox.Width / 2, (drawBox.Height - 24 * multyplyingCoefficient.Value));
                    PifagorTree pifagorTreeFractal = new PifagorTree(colour, g, pen,
                        drawBox.Width * multyplyingCoefficient.Value, drawBox.Height * multyplyingCoefficient.Value);
                    pifagorTreeFractal.DiminishingCoefficient = double.Parse(diminishingCoefficientTextBox.Text);
                    pifagorTreeFractal.Ang1 = int.Parse(AngleLeftTextBox.Text) * Math.PI / 180F;
                    pifagorTreeFractal.Ang2 = int.Parse(AngleRightTextBox.Text) * Math.PI / 180F;
                    pifagorTreeFractal.Draw(int.Parse(recursionDepthTextBox.Text),
                        int.Parse(lengthTextBox.Text) * multyplyingCoefficient.Value, points, Math.PI / 2);
                    drawBox.Update();
                    drawBox.SizeMode = PictureBoxSizeMode.CenterImage;
                    multyplyingCoefficient.Visible = true;
                    multiplyingLabel.Text = "Увеличение";
                    GC.Collect();
                    return;

                case "С-Кривая Леви":
                    points = new PointF[2];
                    points[0] = new PointF(
                        (int)((canvas.Width - double.Parse(lengthTextBox.Text) * multyplyingCoefficient.Value) / 2),
                        2 * canvas.Height / 3);
                    points[1] = new PointF(
                        (int)(canvas.Width -
                               (canvas.Width - double.Parse(lengthTextBox.Text) * multyplyingCoefficient.Value) / 2),
                        2 * canvas.Height / 3);
                    LeviCurve leviCurveFractal = new LeviCurve(colour, g, pen,
                        drawBox.Width * multyplyingCoefficient.Value, drawBox.Height * multyplyingCoefficient.Value);
                    leviCurveFractal.Draw(int.Parse(recursionDepthTextBox.Text),
                        int.Parse(lengthTextBox.Text) * multyplyingCoefficient.Value, points,
                        0);
                    drawBox.SizeMode = PictureBoxSizeMode.CenterImage;
                    multyplyingCoefficient.Visible = true;
                    multiplyingLabel.Text = "Увеличение";
                    GC.Collect();
                    return;

                default: //TODO: messageBox
                    return;
            }


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void AngleLabel_Click(object sender, EventArgs e)
        {

        }

        private void endColorLabel_Click(object sender, EventArgs e)
        {

        }

        private void endColorChoiceButton_Click(object sender, EventArgs e)
        {
            if (pickEndColorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            endColor = pickEndColorDialog.Color;
        }

        private Color[] CalculateGradient(int iterations, Color startColor, Color endColor)
        {
            int rStart = startColor.R;
            int rEnd = endColor.R;
            int bStart = startColor.B;
            int bEnd = endColor.B;
            int gStart = startColor.G;
            int gEnd = endColor.G;
            Color[] gradient = new Color[iterations];
            for (int i = 0; i < iterations; i++)
            {
                var rAverage = rStart + (int)((rEnd - rStart) * i / iterations);
                var gAverage = gStart + (int)((gEnd - gStart) * i / iterations);
                var bAverage = bStart + (int)((bEnd - bStart) * i / iterations);
                gradient[i] = Color.FromArgb(rAverage, gAverage, bAverage);
            }

            return gradient;
        }

        private void startColorChoiceButton_Click(object sender, EventArgs e)
        {
            if (pickStartColorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            pen.Color = pickStartColorDialog.Color;
        }

        private void diminishingCoefficientTextBox_TextChanged(object sender, EventArgs e)
        {
            if (diminishingCoefficientTextBox.Text.Length >= 2 && diminishingCoefficientTextBox.Text[1] == '.')
            {
                char[] array = diminishingCoefficientTextBox.Text.ToCharArray();
                array[1] = ',';
                diminishingCoefficientTextBox.Text = array.ToString();
            }

            double diminishingCoefficient;
            if (!double.TryParse(diminishingCoefficientTextBox.Text, out diminishingCoefficient) ||
                diminishingCoefficient < double.Epsilon || diminishingCoefficient >= 1)
            {
                MessageBox.Show("Неверно введен коэффициент", "Ошибка-рыбка", MessageBoxButtons.OK);
                diminishingCoefficientTextBox.Text = "0,85";
            }

            drawFractalButton.PerformClick();

        }

        private void applicationForm_Resize(object sender, EventArgs e)
        {
            try
            {
                canvas = new Bitmap(Width - 387, Height - 95);
            }
            catch (ArgumentException)
            {
            }

            drawBoxFlowLayoutPanel.Height = canvas.Height;
            drawBoxFlowLayoutPanel.Width = canvas.Width;
            drawBox.Height = canvas.Height;
            drawBox.Width = canvas.Width;

            if (fractalChoiceComboBox.SelectedIndex != -1)
                drawFractalButton.PerformClick();

        }

        private void AngleTextBox_TextChanged(object sender, EventArgs e)
        {
            int k;
            if (!int.TryParse(AngleLeftTextBox.Text, out k) || k > 90 || k < 0)
            {

                MessageBox.Show("Угол введен неверно", "Ошибка-рыбка", MessageBoxButtons.OK);
                AngleLeftTextBox.Text = "45";
            }
        }

        private void multyplyingCoefficient_Scroll(object sender, EventArgs e)
        {
            canvas = new Bitmap(2 * (Width - 387) * multyplyingCoefficient.Value,
                2 * (Height - 95) * multyplyingCoefficient.Value);
            drawFractalButton.PerformClick();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AngleRightTextBox_TextChanged(object sender, EventArgs e)
        {
            int k;
            if (!int.TryParse(AngleRightTextBox.Text, out k) || k > 90 || k < 0)
            {

                MessageBox.Show("Угол введен неверно", "Ошибка-рыбка", MessageBoxButtons.OK);
                AngleLeftTextBox.Text = "30";
            }
        }

        
    }
}
