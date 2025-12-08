#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.

namespace Chess
{
    public class Line
    {
        public int Slope { get; private set; }
        public int YIntercept { get; private set; }

        public enum lines
        {
            Vertical,
            Horizontal,
            pDiag,
            nDiag
        }
        public bool vertical = false;
        public Line(lines line, Point p)
        {
            if (line == lines.Vertical) // | -> slope
            {
                Slope = (int)Math.Round(double.PositiveInfinity, 0);
                YIntercept = p.X;
                vertical = true;
            }
            else if (line == lines.Horizontal) // - -> slope
            {
                Slope = 0;
                YIntercept = p.Y;
            }
            else if (line == lines.pDiag) // / -> slope
            {
                Slope = 10 / 1;
                YIntercept = p.Y - Slope * p.X;
            }
            else if (line == lines.nDiag) // \ -> slope
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
            if (vertical) // Vertical line
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

        public bool IsPointBad(Point currentPosition, Point boundaryPoint, Point testPoint)
        {
            bool i = false;
            // Shift points into "current position" reference frame
            Point boundaryLocal = new Point(boundaryPoint.X - currentPosition.X, boundaryPoint.Y - currentPosition.Y);
            // above left cP: cp= 4 bp= 2    cp= 40 bp= 60  // above right cP: cp= 4 bp= 6    cp= 40 bp= 60
            //   neg slope 0    -2                20        //   pos slope        2                20
            //        cP.y > bp.y = bp.x > tp.x             //              cP.y < bp.y = bp.x > tp.x

            // below left cP: cp= 4 bp= 2    cp= 40 bp= 30  // below right cP: cp= 4 bp= 6    cp= 40 bp= 20
            //   neg slope 0     -2               -10        //   pos slope        2               -20
            //        cP.y > bp.y = bp.x > tp.x             //              cP.y < bp.y = bp.x < tp.x

            // equal left cP: cp= 4 bp= 2    cp= 40 bp= 40  // equal right cP: cp= 4 bp= 6    cp= 40 bp= 40
            //   neg slope 0    -2                0         //   pos slope        2                0
            //        cP.x > bp.x = bp.x > tp.x             //              cP.x < bp.x = bp.x < tp.x

            Point testLocal = new Point(testPoint.X - currentPosition.X, testPoint.Y - currentPosition.Y);
            // above left cP: cp= 4 tp= 1    cp= 40 tp= 70  // above right cP: cp= 4 tp= 7    cp= 40 tp= 70
            //                  -3                30        //                    3                30

            // below left cP: cp= 4 tp= 1    cp= 40 tp= 20  // below right cP: cp= 4 tp= 7    cp= 40 tp= 10
            //                  -3               -20        //                    3               -30

            // equal left cP: cp= 4 tp= 1    cp= 40 tp= 40  // equal right cP: cp= 4 tp= 7    cp= 40 tp= 40
            //                  -3                0         //                    3                0

            // If desired, this could also be changed to line.IsPointOnLine(testLocal)
            if (!IsPointOnLine(testPoint))
                return false;
            // 2. Determine direction of line
            /*
                               70 {"find","a2","a3","emptyfind","a5","a6","find","a8"}
                               60 {"b1","Border","b3","border","b5","border","b7","b8"}
                               50 {"c1","c2","c3","c4","c5","c6","c7","c8"}
                               40 {"d1","d2","d3","bQ","d5","d6","d7","d8"}
                               30 {"e1","e2","e3","e4","e5","e6","e7","e8"}
                               20 {"f1","f2","f3","f4","f5","border","f7","f8"}
                               10 {"border","g2","border","g4","g5","g6","emmptyFind","g8"}
                               00 {"h1","h2","h3","find","h5","h6","h7","find"}
                                    1    2    3    4    5    6    7    8
                            */ // -3 against -4 cp > bp      ||||||          2 against 3 cp < bp
            if (vertical)
            {
                // Compare Y in local reference frame
                if (currentPosition.Y > boundaryPoint.Y)
                    i = testLocal.Y < boundaryLocal.Y;
                if (currentPosition.Y < boundaryPoint.Y)
                    i = testLocal.Y > boundaryLocal.Y;
                return i;
            }
            else
            {
                if (Slope > 0)
                {
                    // Positive slope: increasing left -> right
                    if (currentPosition.Y > boundaryPoint.Y)
                        i = testLocal.X < boundaryLocal.X;
                    if (currentPosition.Y < boundaryPoint.Y)
                        i = testLocal.X > boundaryLocal.X;
                    return i;

                }
                if (Slope < 0)
                {
                    // Negative slope: decreasing left -> right
                    if (currentPosition.Y > boundaryPoint.Y) // above cP
                        i = testLocal.X > boundaryLocal.X;
                    if (currentPosition.Y < boundaryPoint.Y) // below cP
                        i = testLocal.X < boundaryLocal.X;
                    return i;

                }
                if (Slope == 0)
                {
                    // Horizontal line: use X comparison
                    if (currentPosition.X > boundaryPoint.X)
                        i = testLocal.X < boundaryLocal.X;
                    if (currentPosition.X < boundaryPoint.X)
                        i = testLocal.X > boundaryLocal.X;
                    return i;
                }
            }
            return false;
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