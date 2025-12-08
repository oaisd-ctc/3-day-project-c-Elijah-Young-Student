using System.Runtime.ExceptionServices;
using Chess;
using static Chess.Line;

namespace chess
{
    public class PieceKnight : PiecesGeneral
    {
        public PieceKnight() : base() { }

        public static string? SafeGet(string[,] array, int row, int col)
        {
            return (row >= 0 && row < array.GetLength(0) &&
                    col >= 0 && col < array.GetLength(1))
                ? array[row, col]
                : null;
        }

        public string[,] CreateValidMoveArray(string piece, string location)
        {
            int locationLoc1 = 0;
            int locationLoc2 = 0;
            for (int i = 0; i < PieceLocations.BoardLocations.GetLength(0); i++)
            {
                for (int t = 0; t < PieceLocations.BoardLocations.GetLength(1); t++)
                {
                    if (location == PieceLocations.BoardLocations[i, t])
                    {
                        locationLoc1 = i;
                        locationLoc2 = t;
                        break;
                    }
                }
            }
            string iString = ""; // for debugging if needed
            string p2String = ""; // for testpoint
            string[,] ValidLocations = new string[8, 8];

            for (int i = 1; i <= 77; i++)
            {
                if (i < 10)
                {
                    iString = $"0{i}";
                    p2String = iString;
                }
                else
                {
                    iString = $"{i}";
                    p2String = iString;
                }
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
                if
                (
                    p2String == SafeGet(PieceLocations.BoardLocations, locationLoc1 - 2, locationLoc2 - 1) || p2String == SafeGet(PieceLocations.BoardLocations, locationLoc1 - 2, locationLoc2 + 1) || 
                    p2String == SafeGet(PieceLocations.BoardLocations, locationLoc1 - 1, locationLoc2 - 2) || p2String == SafeGet(PieceLocations.BoardLocations, locationLoc1 - 1, locationLoc2 + 2) || 
                    p2String == SafeGet(PieceLocations.BoardLocations, locationLoc1 + 1, locationLoc2 - 2) || p2String == SafeGet(PieceLocations.BoardLocations, locationLoc1 + 1, locationLoc2 + 2) ||
                    p2String == SafeGet(PieceLocations.BoardLocations, locationLoc1 + 2, locationLoc2 - 1) || p2String == SafeGet(PieceLocations.BoardLocations, locationLoc1 + 2, locationLoc2 + 1)
                )
                {
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
                        }
                    }
                }
            }

            string h = "\n";
            int g = 1;
            foreach (var item in ValidLocations)
            {
                h += item;
                if (g % 8 == 0) h += "\n";
                g++;
            }
            Console.WriteLine(h);
            Console.ReadLine();

            return ValidLocations;
        }
    }
}