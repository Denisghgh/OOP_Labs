using MyShapes;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace hexagon
{
    [XmlRoot(ElementName = "Shape")]
    [Serializable]
    public class hexagon : Shape
    { 
        
        public hexagon() { }
        public hexagon(Point firstPoint, Point secondPoint, Color color, int thickness, string name) : base(firstPoint, secondPoint, name, color, thickness)
        {
            
        }
        public override void Draw(Graphics graphic)
        {
            int NumberOfTop = 11;
            Point[] points = new Point[NumberOfTop + 1];
            int n = NumberOfTop;
            double angle = (double)(360.0 / (double)n);

            int Radius = Math.Abs(secondPoint.X - firstPoint.X);
            Point Cntr = new Point(Math.Abs((secondPoint.X - firstPoint.X) / 2 + firstPoint.X), Math.Abs((secondPoint.Y - firstPoint.Y) / 2  + firstPoint.Y));
            double z = 0;
            int i = 0;
            while (i < n + 1)
            {
                points[i].X = Cntr.X + (int)(Math.Round(Math.Cos(z / 180 * Math.PI) * Radius));
                points[i].Y = Cntr.Y - (int)(Math.Round(Math.Sin(z / 180 * Math.PI) * Radius));
                z = z + angle;
                i++;
            }
            Pen pen = new Pen(Color.FromArgb(color), thickness);
            graphic.DrawPolygon(pen, points);
        }

        public override void ShowShapeParameters(DataGridView parametersGrid)
        {
            parametersGrid.Rows.Clear();
            parametersGrid.Rows.Add("Тип:", name);
            parametersGrid.Rows.Add("X1:", firstPoint.X);
            parametersGrid.Rows.Add("Y1:", firstPoint.Y);
            parametersGrid.Rows.Add("X2:", secondPoint.X);
            parametersGrid.Rows.Add("Y2:", secondPoint.Y);
            parametersGrid.Rows.Add("Цвет:", "");
            parametersGrid[1, 5].Style.BackColor = Color.FromArgb(color);
            parametersGrid.Rows.Add("Толщина:", thickness);
        }

        public override void ConfirmShapeParametersChange(DataGridView parametersGrid)
        {
            name = parametersGrid[PropertyColumnIndex, NameIndex].Value.ToString();
            firstPoint.X = int.Parse(parametersGrid[PropertyColumnIndex, FirstPointXIndex].Value.ToString());
            firstPoint.Y = int.Parse(parametersGrid[PropertyColumnIndex, FirstPointYIndex].Value.ToString());
            secondPoint.X = int.Parse(parametersGrid[PropertyColumnIndex, SecondPointXIndex].Value.ToString());
            secondPoint.Y = int.Parse(parametersGrid[PropertyColumnIndex, SecondPointYIndex].Value.ToString());
            color = parametersGrid[PropertyColumnIndex, ColorIndex].Style.BackColor.ToArgb();
            thickness = int.Parse(parametersGrid[PropertyColumnIndex, ThicknessIndex].Value.ToString());
        }
    }
}
