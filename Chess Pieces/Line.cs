namespace Chess
{
    public class Line
    {
        public int Slope { get; private set; }
        public int YIntercept { get; private set; }

#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
        public enum lines
#pragma warning restore CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
        {
            Vertical,
            Horizontal,
            pDiag,
            nDiag
        }
        public bool vertical = false;
        public Line(lines line, Point p)
        {
            if (line == lines.Vertical)
            {
                Slope = (int)Math.Round(double.PositiveInfinity, 0);
                YIntercept = p.X;
                vertical = true;
            }
            else if (line == lines.Horizontal)
            {
                Slope = 0;
                YIntercept = p.Y;
            }
            else if (line == lines.pDiag)
            {
                Slope = 10 / 1;
                YIntercept = p.Y - Slope * p.X;
            }
            else if (line == lines.nDiag)
            {
                Slope = -10 / 1;
                YIntercept = p.Y - Slope * p.X;
            }
        }

        // public Line(Point p1, Point p2)
        // {
        //     if (p1.X == p2.X) // Vertical line
        //     {
        //         Slope = (int)Math.Round(double.PositiveInfinity, 0); // Or handle as a special case
        //         YIntercept = p1.X; // X-intercept for vertical lines
        //     }
        //     else
        //     {
        //         Slope = (p2.Y - p1.Y) / (p2.X - p1.X);
        //         YIntercept = p1.Y - Slope * p1.X;
        //     }
        // }

        public bool IsPointOnLine(Point p, double tolerance = 0.1)
        {
            if (vertical == true) // Vertical line
            {
                if (Math.Abs(p.X - YIntercept) < tolerance)
                {
                    return true;
                }
                return false;
            }
            else
            {
                double expectedY = Slope * p.X + YIntercept;
                return Math.Abs(p.Y - expectedY) < tolerance;
            }
        }

        public bool IsPointBad(Point currentPosition, Point boundaryPoint, Point testPoint, double tolerance = 0.1)
        {
            // Shift points into "current position" reference frame
            Point boundaryLocal = new Point(boundaryPoint.X - currentPosition.X, boundaryPoint.Y - currentPosition.Y);

            Point testLocal = new Point(testPoint.X - currentPosition.X, testPoint.Y - currentPosition.Y);

            // 1. Must be on the line (using original coordinates)
            // If desired, this could also be changed to line.IsPointOnLine(testLocal)
            if (!IsPointOnLine(testPoint, tolerance))
                return false;

            // 2. Determine direction of line
            bool isVertical = double.IsPositiveInfinity(Slope);

            if (isVertical)
            {
                // Compare Y in local reference frame
                return testLocal.Y > boundaryLocal.Y;
            }
            else
            {
                if (Slope > 0)
                {
                    // Positive slope: increasing left → right
                    return testLocal.X > boundaryLocal.X;
                }
                else if (Slope < 0)
                {
                    // Negative slope: decreasing left → right
                    return testLocal.X < boundaryLocal.X;
                }
                else
                {
                    // Horizontal line: use Y comparison
                    return testLocal.Y > boundaryLocal.Y;
                }
            }
        }


        public struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
    }
}