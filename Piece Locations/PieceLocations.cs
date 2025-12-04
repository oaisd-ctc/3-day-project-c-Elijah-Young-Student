#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.

using System.Reflection.Emit;

namespace Chess
{
    public class PieceLocations
    {
        // the array of the board
        public static string[,] boardLocations =
        {
            {"a1","a2","a3","a4","a5","a6","a7","a8"},
            {"b1","b2","b3","b4","b5","b6","b7","b8"},
            {"c1","c2","c3","c4","c5","c6","c7","c8"},
            {"d1","d2","d3","d4","d5","d6","d7","d8"},
            {"e1","e2","e3","e4","e5","e6","e7","e8"},
            {"f1","f2","f3","f4","f5","f6","f7","f8"},
            {"g1","g2","g3","g4","g5","g6","g7","g8"},
            {"h1","h2","h3","h4","h5","h6","h7","h8"}
        };

        // the array of where the pieces are currently
        public static string[,] pieceLocations =
        {
            {"wR","wK","wB","wQ","wK","wB","wK","wR"},
            {"wP","wP","wP","wP","wP","wP","wP","wP"},
            {null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null},
            {"bP","bP","bP","bP","bP","bP","bP","bP"},
            {"bR","bK","bB","bQ","bK","bB","bK","bR"}
        };

        // the array for the moves that are valid for the piece to move to
        private static string[,] pieceValidMove =
        {
            {null,"valid",null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null}
        };

        // method to move pieces around the board
        public static void MovePiece()
        {
        movePieceStart:
            //DisplayBoard();
            Console.WriteLine("Type in the location of the piece you would like to move.");
            string moveChoicePiece = Console.ReadLine().ToLower();
            Console.WriteLine("Checking your piece choice...");
            string pieceChosen;
            string pieceLocation;
            for (int i = 0; i < boardLocations.GetLength(0); i++)
            {
                for (int j = 0; j < boardLocations.GetLength(1); j++)
                {
                    if (boardLocations[i, j] == moveChoicePiece && pieceLocations[i, j] != null)
                    {
                        pieceChosen = pieceLocations[i, j];
                        pieceLocation = boardLocations[i, j];
                        goto checkChoiceGood;
                    }
                    else if (i == boardLocations.GetLength(0) - 1 && j == boardLocations.GetLength(1) - 1)
                    {
                        Console.WriteLine($"The square: {moveChoicePiece} either doesnt exist or there is no piece there.\nChoose a new piece.");
                        Thread.Sleep(1500);
                        goto movePieceStart;
                    }
                }
            }
        checkChoiceGood:
        // update pieceValidMove array
        // UpdateValidMove();

        moveToCheck:
            Console.WriteLine("Where do you want to move the piece too? [0 to change piece]");
            string moveChoiceLocation = Console.ReadLine();
            for (int i = 0; i < boardLocations.GetLength(0); i++)
            {
                for (int j = 0; j < boardLocations.GetLength(1); j++)
                {
                    if (boardLocations[i, j] == moveChoiceLocation && pieceValidMove[i, j] != null)
                    {
                        //movePiece(pieceLocation, moveChoiceLocation);
                        goto checkChoiceGood;
                    }
                    else if (i == boardLocations.GetLength(0) - 1 && j == boardLocations.GetLength(1) - 1)
                    {
                        Console.WriteLine($"The square: {moveChoicePiece} either doesnt exist or the move is invalid.\nChoose a new location.");
                        Thread.Sleep(1500);
                        goto movePieceStart;
                    }
                }
            }
            // checkMoveGood:

        }
    }
}