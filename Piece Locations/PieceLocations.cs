#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.

using System.Reflection.Emit;

namespace Chess
{
    public class PieceLocations
    {
        // the array of the board
        public static string[,] BoardLocations =
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
        public static string[,] PieceCurrentLocations =
        {
            {"bR","bN","bB",null,"bK","bB","bN","bR"},
            {"bP","bP","bP","bP","bP","bP","bP","bP"},
            {null,null,null,null,null,null,null,null},
            {null,null,null,"bQ",null,null,null,null},
            {null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null},
            {"wP","wP","wP","wP","wP","wP","wP","wP"},
            {"wR","wN","wB","wQ","wK","wB","wN","wR"}
        };

        // the pieces that are still in play
        public static string[,] PiecesInPlay =
        {
            {"wR","wK","wB","wQ","wK","wB","wK","wR","wP","wP","wP","wP","wP","wP","wP","wP"},
            {"bR","bK","bB","bQ","bK","bB","bK","bR","bP","bP","bP","bP","bP","bP","bP","bP"}
        };

        // the peices that have been taken
        public static string[,] PiecesTaken = new string[16, 16];

        // the array for the moves that are valid for the piece to move to
        private static string[,] PieceValidMove =
        {
            {null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null}
        };

        // method to edit the pieceValidMove array
        public static void UpdateValidMove(string piece, string location)
        {
            string[,] validMoveArray = new string[8, 8]; ;
            switch (piece)
            {
                case "wQ":
                    PieceValidMove = PieceConstructor.wQ.CreateValidMoveArray(piece, location);
                    break;
                //case "wK":
                //    validMoveArray = PieceConstructor.wK.CreateValidMoveArray(piece, location);
                //    lines = PieceConstructor.wQ.GetLines();
                //    break;
                //case "wN":
                //    validMoveArray = PieceConstructor.wN.CreateValidMoveArray(piece, location);
                //    lines = PieceConstructor.wQ.GetLines();
                //    break;
                //case "wR":
                //    validMoveArray = PieceConstructor.wR.CreateValidMoveArray(piece, location);
                //    lines = PieceConstructor.wQ.GetLines();
                //    break;
                //case "WB":
                //    validMoveArray = PieceConstructor.wB.CreateValidMoveArray(piece, location);
                //    lines = PieceConstructor.wQ.GetLines();
                //    break;
                //case "wP":
                //    validMoveArray = PieceConstructor.wP.CreateValidMoveArray(piece, location);
                //    lines = PieceConstructor.wQ.GetLines();
                //    break;
                case "bQ":
                    PieceValidMove = PieceConstructor.bQ.CreateValidMoveArray(piece, location);
                    break;
                    //case "bK":
                    //    validMoveArray = PieceConstructor.bK.CreateValidMoveArray(piece, location);
                    //    lines = PieceConstructor.bK.GetLines();
                    //    break;
                    //case "bN":
                    //    validMoveArray = PieceConstructor.bN.CreateValidMoveArray(piece, location);
                    //    lines = PieceConstructor.bN.GetLines();
                    //    break;
                    //case "bR":
                    //    validMoveArray = PieceConstructor.bR.CreateValidMoveArray(piece, location);
                    //    lines = PieceConstructor.bR.GetLines();
                    //    break;
                    //case "bB":
                    //    validMoveArray = PieceConstructor.bB.CreateValidMoveArray(piece, location);
                    //    lines = PieceConstructor.bB.GetLines();
                    //    break;
                    //case "bP":
                    //    validMoveArray = PieceConstructor.bP.CreateValidMoveArray(piece, location);
                    //    lines = PieceConstructor.bP.GetLines();
                    //    break;
            }
        }

        // method to move pieces around the board
        public static void MovePiece()
        {
        movePieceStart:
            Console.Clear();
            //DisplayBoard();
            Console.WriteLine("Type in the location of the piece you would like to move.");
            string moveChoicePiece = Console.ReadLine().ToLower();
            if (moveChoicePiece == "0") goto movePieceStart;
            Console.WriteLine("Checking your piece choice...");
            string pieceChosen = "";
            string pieceLocation = "";
            for (int i = 0; i < BoardLocations.GetLength(0); i++)
            {
                for (int j = 0; j < BoardLocations.GetLength(1); j++)
                {
                    if (BoardLocations[i, j] == moveChoicePiece && PieceCurrentLocations[i, j] != null)
                    {
                        pieceChosen = PieceCurrentLocations[i, j];
                        pieceLocation = BoardLocations[i, j];
                        goto checkChoiceGood;
                    }
                    else if (i == BoardLocations.GetLength(0) - 1 && j == BoardLocations.GetLength(1) - 1)
                    {
                        Console.WriteLine($"The square: {moveChoicePiece} either doesnt exist or there is no piece there.\nChoose a new piece.");
                        Thread.Sleep(1500);
                        goto movePieceStart;
                    }
                }
            }
        checkChoiceGood:
            // update pieceValidMove array
            UpdateValidMove(pieceChosen, pieceLocation);
            // foreach (string item in PieceValidMove)
            // {
            //     Console.WriteLine(item);
            // }

        moveToCheck:
            Console.WriteLine("Where do you want to move the piece too? [any num to change piece]");
            string moveChoiceLocation = Console.ReadLine();
            int moveChoiceLocationInt;
            if (int.TryParse(moveChoiceLocation, out moveChoiceLocationInt)) goto movePieceStart;
            for (int i = 0; i < BoardLocations.GetLength(0); i++)
            {
                for (int j = 0; j < BoardLocations.GetLength(1); j++)
                {
                    if (BoardLocations[i, j] == moveChoiceLocation && PieceValidMove[i, j] != null)
                    {
                        //movePiece(pieceLocation, moveChoiceLocation);
                        goto checkMoveGood;
                    }
                    else if (i == BoardLocations.GetLength(0) - 1 && j == BoardLocations.GetLength(1) - 1)
                    {
                        Console.WriteLine($"The square: {moveChoiceLocation} either doesnt exist or the move is invalid.\nChoose a new location.");
                        Thread.Sleep(1500);
                        goto moveToCheck;
                    }
                }
            }
        checkMoveGood:;

        }
    }
}