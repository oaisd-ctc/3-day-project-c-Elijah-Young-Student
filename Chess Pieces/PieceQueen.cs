using static Chess.Line;
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.

namespace Chess
{
    public class PieceQueen : PiecesGeneral
    {
        public PieceQueen() : base() { }

        public string[,] CreateValidMoveArray(string piece, string location)
        {
            Point p1 = new Point { X = 0, Y = 0 };
            switch (location[0])
            {
                case 'a':
                    p1 = new Point { Y = 70, X = (int)char.GetNumericValue(location[1]) }; // location of the piece and | line
                    break;
                case 'b':
                    p1 = new Point { Y = 60, X = (int)char.GetNumericValue(location[1]) }; // location of the piece and | line    
                    break;
                case 'c':
                    p1 = new Point { Y = 50, X = (int)char.GetNumericValue(location[1]) }; // location of the piece and | line                
                    break;
                case 'd':
                    p1 = new Point { Y = 40, X = (int)char.GetNumericValue(location[1]) }; // location of the piece and | line             
                    break;
                case 'e':
                    p1 = new Point { Y = 30, X = (int)char.GetNumericValue(location[1]) }; // location of the piece and | line                
                    break;
                case 'f':
                    p1 = new Point { Y = 20, X = (int)char.GetNumericValue(location[1]) }; // location of the piece and | line                  
                    break;
                case 'g':
                    p1 = new Point { Y = 10, X = (int)char.GetNumericValue(location[1]) }; // location of the piece and | line              
                    break;
                case 'h':
                    p1 = new Point { Y = 00, X = (int)char.GetNumericValue(location[1]) }; // location of the piece and | line           
                    break;
            }

            Line line1 = new Line(lines.Vertical, p1); // | line
            Line line2 = new Line(lines.Horizontal, p1); // / line
            Line line3 = new Line(lines.nDiag, p1); // \ line
            Line line4 = new Line(lines.pDiag, p1); // - line
            Point p2 = new Point { X = 0, Y = 0 }; // for testpoint
            string iString = "";
            string p2String = ""; // for testpoint
            string[,] ValidLocations = new string[8, 8];

            for (int i = 1; i <= 64; i++)
            {
                /*
                70 {"a1","a2","a3","a4","a5","a6","a7","a8"}
                60 {"b1","b2","b3","b4","b5","b6","b7","b8"}
                50 {"c1","c2","c3","c4","c5","c6","c7","c8"}
                40 {"d1","d2","d3","d4","d5","d6","d7","d8"}
                30 {"e1","e2","e3","e4","e5","e6","e7","e8"}
                20 {"f1","f2","f3","f4","f5","f6","f7","f8"}
                10 {"g1","g2","g3","g4","g5","g6","g7","g8"}
                00 {"h1","h2","h3","h4","h5","h6","h7","h8"}
                     1   2    3    4    5    6    7    8
                */
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
                if (line1.IsPointOnLine(p2) || line2.IsPointOnLine(p2) || line3.IsPointOnLine(p2) || line4.IsPointOnLine(p2))
                {
                    switch (p2String[0])
                    {
                        case '7':
                            p2String = $"a{p2String[1]}";
                            break;
                        case '6':
                            p2String = $"b{p2String[1]}";
                            break;
                        case '5':
                            p2String = $"c{p2String[1]}";
                            break;
                        case '4':
                            p2String = $"d{p2String[1]}";
                            break;
                        case '3':
                            p2String = $"e{p2String[1]}";
                            break;
                        case '2':
                            p2String = $"f{p2String[1]}";
                            break;
                        case '1':
                            p2String = $"g{p2String[1]}";
                            break;
                        case '0':
                            p2String = $"h{p2String[1]}";
                            break;
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
                                ValidLocations[l, j] = null;
                            }
                        }
                    }
                }
                if (iString[1] == '8') i += 2;
            }

            ;
            //p1 is equal to the current location of the chosen piece
            for (int i = 0; i < PieceLocations.BoardLocations.GetLength(0); i++)
            {
                for (int j = 0; j < PieceLocations.BoardLocations.GetLength(1); j++)
                {
                }
            }

            // need to get the nearest white/black piece to the chosen piece determine
            // weather pieces past that nearest boarder piece and test any valid pieces
            // are on the line past the bad peice using: 
            // [line].IsPointBad(location, boundaryPoint, test point)
            // if that is true then make the "Valid" null other wise do nothing and
            // after return the array
            return ValidLocations;
        }
    }
}