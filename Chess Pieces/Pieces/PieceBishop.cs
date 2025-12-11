using Chess;
using static Chess.Line;

namespace chess
{
    public class PieceBishop : PiecesGeneral
    {
        public PieceBishop() : base() { }

        public string[,] CreateValidMoveArray(string piece, string location)
        {
            // Console.WriteLine(piece);
            Point p1 = new Point { X = 0, Y = 0 };
            // Map location to grid coordinates
            switch (location[0])
            {
                case 'a': p1 = new Point { Y = 70, X = (int)char.GetNumericValue(location[1]) }; break;
                case 'b': p1 = new Point { Y = 60, X = (int)char.GetNumericValue(location[1]) }; break;
                case 'c': p1 = new Point { Y = 50, X = (int)char.GetNumericValue(location[1]) }; break;
                case 'd': p1 = new Point { Y = 40, X = (int)char.GetNumericValue(location[1]) }; break;
                case 'e': p1 = new Point { Y = 30, X = (int)char.GetNumericValue(location[1]) }; break;
                case 'f': p1 = new Point { Y = 20, X = (int)char.GetNumericValue(location[1]) }; break;
                case 'g': p1 = new Point { Y = 10, X = (int)char.GetNumericValue(location[1]) }; break;
                case 'h': p1 = new Point { Y = 0, X = (int)char.GetNumericValue(location[1]) }; break;
            }


            Line line3 = new Line(lines.nDiag, p1); // \ line
            Line line4 = new Line(lines.pDiag, p1); // / line
            Point p2 = new Point { X = 0, Y = 0 }; // for testpoint
            string iString = "";
            string p2String = ""; // for testpoint
            string[,] ValidLocations = new string[8, 8];

            for (int i = 1; i <= 77; i++)
            {
                if (i < 10)
                {
                    iString = $"0{i}";
                    p2String = iString;
                    p2 = new Point { X = i, Y = 0 };
                }
                else
                {
                    iString = $"{i}";
                    p2String = iString;
                    p2 = new Point { X = (int)char.GetNumericValue(p2String[1]), Y = (int)char.GetNumericValue(p2String[0]) * 10 };
                }
                if (line3.IsPointOnLine(p2) || line4.IsPointOnLine(p2))
                {
                    switch (p2String[0])
                    {
                        case '7': p2String = $"a{p2String[1]}"; break;
                        case '6': p2String = $"b{p2String[1]}"; break;
                        case '5': p2String = $"c{p2String[1]}"; break;
                        case '4': p2String = $"d{p2String[1]}"; break;
                        case '3': p2String = $"e{p2String[1]}"; break;
                        case '2': p2String = $"f{p2String[1]}"; break;
                        case '1': p2String = $"g{p2String[1]}"; break;
                        case '0': p2String = $"h{p2String[1]}"; break;
                    }
                    for (int l = 0; l < PieceLocations.BoardLocations.GetLength(0); l++)
                    {
                        for (int j = 0; j < ValidLocations.GetLength(1); j++)
                        {
                            if (PieceLocations.BoardLocations[l, j] == p2String && p2String != location)
                            {
                                ValidLocations[l, j] = $"Valid";
                            }
                        }
                    }
                    for (int l = 0; l < PieceLocations.BoardLocations.GetLength(0); l++)
                    {
                        for (int j = 0; j < ValidLocations.GetLength(1); j++)
                        {
                            if (ValidLocations[l, j] != "Valid")
                            {
                                ValidLocations[l, j] = "null";
                            }
                        }
                    }
                }
                if (iString[1] == '8') i += 2;
            }

            // string h = "\n";
            // int g = 1;
            // foreach (var item in ValidLocations)
            // {
            //     h += item;
            //     if (g % 8 == 0) h += "\n";
            //     g++;
            // }
            // Console.WriteLine(h);
            // Console.ReadLine();

            for (int i = 0; i < PieceLocations.BoardLocations.GetLength(0); i++)
            {
                for (int j = 0; j < ValidLocations.GetLength(1); j++)
                {
                    if (ValidLocations[i, j] == "Valid")
                    {
                        string borderPiece = "";
                        borderPiece = PieceLocations.PieceCurrentLocations[i, j];
                        // Console.WriteLine("location: valid" + "    locations:" + PieceLocations.BoardLocations[i, j] + "     piece:" + borderPiece);

                        if (borderPiece != "null")
                        {
                            if (borderPiece[0] == piece[0])
                            {
                                // Console.WriteLine("Same Color: nulled");
                                ValidLocations[i, j] = "null";
                            }
                            if (borderPiece == piece) continue;
                            borderPiece = PieceLocations.BoardLocations[i, j];
                            // Convert board position to coordinates for comparison
                            Point borderLocation = new Point { X = 0, Y = 0 };
                            switch (PieceLocations.BoardLocations[i, j][0])
                            {
                                case 'a': borderLocation = new Point { Y = 70, X = (int)char.GetNumericValue(borderPiece[1]) }; break;
                                case 'b': borderLocation = new Point { Y = 60, X = (int)char.GetNumericValue(borderPiece[1]) }; break;
                                case 'c': borderLocation = new Point { Y = 50, X = (int)char.GetNumericValue(borderPiece[1]) }; break;
                                case 'd': borderLocation = new Point { Y = 40, X = (int)char.GetNumericValue(borderPiece[1]) }; break;
                                case 'e': borderLocation = new Point { Y = 30, X = (int)char.GetNumericValue(borderPiece[1]) }; break;
                                case 'f': borderLocation = new Point { Y = 20, X = (int)char.GetNumericValue(borderPiece[1]) }; break;
                                case 'g': borderLocation = new Point { Y = 10, X = (int)char.GetNumericValue(borderPiece[1]) }; break;
                                case 'h': borderLocation = new Point { Y = 0, X = (int)char.GetNumericValue(borderPiece[1]) }; break;
                            }
                            // Console.WriteLine("y,x: " + borderLocation.Y + "," + borderLocation.X);
                            if (p1.Y > borderLocation.Y)
                            {
                                for (int l = i; l < PieceLocations.BoardLocations.GetLength(0); l++)
                                {
                                    for (int t = 0; t < ValidLocations.GetLength(1); t++)
                                    {
                                        string testPiece = PieceLocations.BoardLocations[l, t];
                                        Point testLocation = new Point { X = 0, Y = 0 };
                                        switch (PieceLocations.BoardLocations[l, t][0])
                                        {
                                            case 'a': testLocation = new Point { Y = 70, X = (int)char.GetNumericValue(testPiece[1]) }; break;
                                            case 'b': testLocation = new Point { Y = 60, X = (int)char.GetNumericValue(testPiece[1]) }; break;
                                            case 'c': testLocation = new Point { Y = 50, X = (int)char.GetNumericValue(testPiece[1]) }; break;
                                            case 'd': testLocation = new Point { Y = 40, X = (int)char.GetNumericValue(testPiece[1]) }; break;
                                            case 'e': testLocation = new Point { Y = 30, X = (int)char.GetNumericValue(testPiece[1]) }; break;
                                            case 'f': testLocation = new Point { Y = 20, X = (int)char.GetNumericValue(testPiece[1]) }; break;
                                            case 'g': testLocation = new Point { Y = 10, X = (int)char.GetNumericValue(testPiece[1]) }; break;
                                            case 'h': testLocation = new Point { Y = 0, X = (int)char.GetNumericValue(testPiece[1]) }; break;
                                        }
                                        // Console.WriteLine("y,x: " + testLocation.Y + "," + testLocation.X);

                                        if (borderLocation.Y > testLocation.Y)
                                        {
                                            // Console.Write("below queen: " + "    locations: " + PieceLocations.BoardLocations[l, t]);
                                            if (p1.X < borderLocation.X)
                                            {
                                                // Console.Write(" : on line \\");
                                                if (line3.IsPointBad(p1, borderLocation, testLocation))
                                                {
                                                    // Console.WriteLine("        bad on line3 \\: nulled");
                                                    // Console.Write("before: " + ValidLocations[l, t]);
                                                    ValidLocations[l, t] = "null";
                                                    // Console.Write("         after:" + ValidLocations[l, t] + "\n");
                                                    continue;
                                                }
                                            }
                                            if (p1.X > borderLocation.X)
                                            {
                                                // Console.WriteLine(" : on line /");
                                                if (line4.IsPointBad(p1, borderLocation, testLocation))
                                                {
                                                    // Console.WriteLine("        bad on line4 /: nulled");
                                                    // Console.Write("before: " + ValidLocations[l, t]);
                                                    ValidLocations[l, t] = "null";
                                                    // Console.Write("         after:" + ValidLocations[l, t] + "\n");
                                                    continue;
                                                }
                                            }
                                            // Console.Write("\n");
                                        }
                                    }
                                }
                            }
                            if (p1.Y < borderLocation.Y)
                            {
                                for (int l = i; l >= 0; l--)
                                {
                                    for (int t = 7; t >= 0; t--)
                                    {
                                        string testPiece = PieceLocations.BoardLocations[l, t];
                                        Point testLocation = new Point { X = 0, Y = 0 };
                                        switch (PieceLocations.BoardLocations[l, t][0])
                                        {
                                            case 'a': testLocation = new Point { Y = 70, X = (int)char.GetNumericValue(testPiece[1]) }; break;
                                            case 'b': testLocation = new Point { Y = 60, X = (int)char.GetNumericValue(testPiece[1]) }; break;
                                            case 'c': testLocation = new Point { Y = 50, X = (int)char.GetNumericValue(testPiece[1]) }; break;
                                            case 'd': testLocation = new Point { Y = 40, X = (int)char.GetNumericValue(testPiece[1]) }; break;
                                            case 'e': testLocation = new Point { Y = 30, X = (int)char.GetNumericValue(testPiece[1]) }; break;
                                            case 'f': testLocation = new Point { Y = 20, X = (int)char.GetNumericValue(testPiece[1]) }; break;
                                            case 'g': testLocation = new Point { Y = 10, X = (int)char.GetNumericValue(testPiece[1]) }; break;
                                            case 'h': testLocation = new Point { Y = 0, X = (int)char.GetNumericValue(testPiece[1]) }; break;
                                        }
                                        // Console.WriteLine("y,x: " + testLocation.Y + "," + testLocation.X);

                                        if (borderLocation.Y < testLocation.Y)
                                        {
                                            //Console.WriteLine("below queen: " + "    locations: " + PieceLocations.BoardLocations[l, t]);
                                            if (p1.X > borderLocation.X)
                                            {
                                                // Console.Write(" : on line \\");
                                                // Console.WriteLine("\n         p1 X: " + p1.X + "         borderLocation X: " + borderLocation.X + "         testLocation X: " + testLocation.X); 
                                                if (line3.IsPointBad(p1, borderLocation, testLocation))
                                                {
                                                    // Console.WriteLine("        bad on line3 \\: nulled");
                                                    // Console.Write("before: " + ValidLocations[l, t]);
                                                    ValidLocations[l, t] = "null";
                                                    // Console.Write("         after:" + ValidLocations[l, t] + "\n");
                                                    continue;
                                                }
                                            }
                                            if (p1.X < borderLocation.X)
                                            {
                                                // Console.Write(" : on line /");
                                                // Console.WriteLine("\n         p1 X: " + p1.X + "         borderLocation X: " + borderLocation.X + "         testLocation X: " + testLocation.X);
                                                if (line4.IsPointBad(p1, borderLocation, testLocation))
                                                {
                                                    // Console.WriteLine("        bad on line4 /: nulled");
                                                    // Console.Write("before: " + ValidLocations[l, t]);
                                                    ValidLocations[l, t] = "null";
                                                    // Console.Write("         after:" + ValidLocations[l, t] + "\n");
                                                    continue;
                                                }
                                            }
                                            // Console.Write("\n");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            // string h = "\n";
            // int g = 1;
            // foreach (var item in ValidLocations)
            // {
            //     h += item;
            //     if (g % 8 == 0) h += "\n";
            //     g++;
            // }
            // Console.WriteLine(h);
            // Console.ReadLine();

            return ValidLocations;
        }
    }
}