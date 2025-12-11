#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.

using System;
using System.Reflection.Emit;
using GameElements;

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
            {"bR","bN","bB","bK","bQ","bB","bN","bR"},
            {"bP1","bP2","bP3","bP4","bP5","bP6","bP7","bP8"},
            {"null","null","null","null","null","null","null","null"},
            {"null","null","null","null","null","null","null","null"},
            {"null","null","null","null","null","null","null","null"},
            {"null","null","null","null","null","null","null","null"},
            {"wP1","wP2","wP3","wP4","wP5","wP6","wP7","wP8"},
            {"wR","wN","wB","wK","wQ","wB","wN","wR"}
        };

        // the pieces that are still in play
        public static string[,] PiecesInPlay =
        {
            {"wR","wK","wB","wQ","wK","wB","wK","wR","wP","wP","wP","wP","wP","wP","wP","wP"},
            {"bR","bK","bB","bQ","bK","bB","bK","bR","bP","bP","bP","bP","bP","bP","bP","bP"}
        };

        // the peices that have been taken
        public static string[,] PiecesTaken = new string[2, 16];

        // the array for the moves that are valid for the piece to move to
        private static string[,] PieceValidMove =
        { // "Valid"
            {null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null}
        };

        public static string[] NotatedMoves = { "Game Start" };

        // method to edit the pieceValidMove array
        public static string[,] UpdateValidMove(string piece, string location)
        {
            string[,] validMove = { { " " } };
            switch (piece)
            {
                case "wQ":
                    validMove = PieceConstructor.wQ.CreateValidMoveArray(piece, location);
                    break;
                case "wK":
                    validMove = PieceConstructor.wK.CreateValidMoveArray(piece, location);
                    break;
                case "wN":
                    validMove = PieceConstructor.wN.CreateValidMoveArray(piece, location);
                    break;
                case "wR":
                    validMove = PieceConstructor.wR.CreateValidMoveArray(piece, location);
                    break;
                case "wB":
                    validMove = PieceConstructor.wB.CreateValidMoveArray(piece, location);
                    break;

                case "bQ":
                    validMove = PieceConstructor.bQ.CreateValidMoveArray(piece, location);
                    break;
                case "bK":
                    validMove = PieceConstructor.bK.CreateValidMoveArray(piece, location);
                    break;
                case "bN":
                    validMove = PieceConstructor.bN.CreateValidMoveArray(piece, location);
                    break;
                case "bR":
                    validMove = PieceConstructor.bR.CreateValidMoveArray(piece, location);
                    break;
                case "bB":
                    validMove = PieceConstructor.bB.CreateValidMoveArray(piece, location);
                    break;
            }
            switch (piece[0], piece[1])
            {
                case ('w', 'P'):
                    switch (piece[2])
                    {
                        case '1':
                            validMove = PieceConstructor.wP1.CreateValidMoveArray(piece, location);
                            break;
                        case '2':
                            validMove = PieceConstructor.wP2.CreateValidMoveArray(piece, location);
                            break;
                        case '3':
                            validMove = PieceConstructor.wP3.CreateValidMoveArray(piece, location);
                            break;
                        case '4':
                            validMove = PieceConstructor.wP4.CreateValidMoveArray(piece, location);
                            break;
                        case '5':
                            validMove = PieceConstructor.wP5.CreateValidMoveArray(piece, location);
                            break;
                        case '6':
                            validMove = PieceConstructor.wP6.CreateValidMoveArray(piece, location);
                            break;
                        case '7':
                            validMove = PieceConstructor.wP7.CreateValidMoveArray(piece, location);
                            break;
                        case '8':
                            validMove = PieceConstructor.wP8.CreateValidMoveArray(piece, location);
                            break;
                    }
                    break;
                case ('b', 'P'):
                    switch (piece[2])
                    {
                        case '1':
                            validMove = PieceConstructor.bP1.CreateValidMoveArray(piece, location);
                            break;
                        case '2':
                            validMove = PieceConstructor.bP2.CreateValidMoveArray(piece, location);
                            break;
                        case '3':
                            validMove = PieceConstructor.bP3.CreateValidMoveArray(piece, location);
                            break;
                        case '4':
                            validMove = PieceConstructor.bP4.CreateValidMoveArray(piece, location);
                            break;
                        case '5':
                            validMove = PieceConstructor.bP5.CreateValidMoveArray(piece, location);
                            break;
                        case '6':
                            validMove = PieceConstructor.bP6.CreateValidMoveArray(piece, location);
                            break;
                        case '7':
                            validMove = PieceConstructor.bP7.CreateValidMoveArray(piece, location);
                            break;
                        case '8':
                            validMove = PieceConstructor.bP8.CreateValidMoveArray(piece, location);
                            break;
                    }
                    break;
            }
            return validMove;
        }

        // public static string[,] UpdateValidMoveWithoutKing(string piece, string location)
        // {
        //     string[,] validMove = { { " " } };
        //     switch (piece)
        //     {
        //         case "wQ":
        //             validMove = PieceConstructor.wQ.CreateValidMoveArray(piece, location);
        //             break;
        //         case "wN":
        //             validMove = PieceConstructor.wN.CreateValidMoveArray(piece, location);
        //             break;
        //         case "wR":
        //             validMove = PieceConstructor.wR.CreateValidMoveArray(piece, location);
        //             break;
        //         case "wB":
        //             validMove = PieceConstructor.wB.CreateValidMoveArray(piece, location);
        //             break;
// 
        //         case "bQ":
        //             validMove = PieceConstructor.bQ.CreateValidMoveArray(piece, location);
        //             break;
        //         case "bN":
        //             validMove = PieceConstructor.bN.CreateValidMoveArray(piece, location);
        //             break;
        //         case "bR":
        //             validMove = PieceConstructor.bR.CreateValidMoveArray(piece, location);
        //             break;
        //         case "bB":
        //             validMove = PieceConstructor.bB.CreateValidMoveArray(piece, location);
        //             break;
        //     }
        //     switch (piece[0], piece[1])
        //     {
        //         case ('w', 'P'):
        //             switch (piece[2])
        //             {
        //                 case '1':
        //                     validMove = PieceConstructor.wP1.CreateValidMoveArrayWithoutForwardMove(piece, location);
        //                     break;
        //                 case '2':
        //                     validMove = PieceConstructor.wP2.CreateValidMoveArrayWithoutForwardMove(piece, location);
        //                     break;
        //                 case '3':
        //                     validMove = PieceConstructor.wP3.CreateValidMoveArrayWithoutForwardMove(piece, location);
        //                     break;
        //                 case '4':
        //                     validMove = PieceConstructor.wP4.CreateValidMoveArrayWithoutForwardMove(piece, location);
        //                     break;
        //                 case '5':
        //                     validMove = PieceConstructor.wP5.CreateValidMoveArrayWithoutForwardMove(piece, location);
        //                     break;
        //                 case '6':
        //                     validMove = PieceConstructor.wP6.CreateValidMoveArrayWithoutForwardMove(piece, location);
        //                     break;
        //                 case '7':
        //                     validMove = PieceConstructor.wP7.CreateValidMoveArrayWithoutForwardMove(piece, location);
        //                     break;
        //                 case '8':
        //                     validMove = PieceConstructor.wP8.CreateValidMoveArrayWithoutForwardMove(piece, location);
        //                     break;
        //             }
        //             break;
        //         case ('b', 'P'):
        //             switch (piece[2])
        //             {
        //                 case '1':
        //                     validMove = PieceConstructor.bP1.CreateValidMoveArrayWithoutForwardMove(piece, location);
        //                     break;
        //                 case '2':
        //                     validMove = PieceConstructor.bP2.CreateValidMoveArrayWithoutForwardMove(piece, location);
        //                     break;
        //                 case '3':
        //                     validMove = PieceConstructor.bP3.CreateValidMoveArrayWithoutForwardMove(piece, location);
        //                     break;
        //                 case '4':
        //                     validMove = PieceConstructor.bP4.CreateValidMoveArrayWithoutForwardMove(piece, location);
        //                     break;
        //                 case '5':
        //                     validMove = PieceConstructor.bP5.CreateValidMoveArrayWithoutForwardMove(piece, location);
        //                     break;
        //                 case '6':
        //                     validMove = PieceConstructor.bP6.CreateValidMoveArrayWithoutForwardMove(piece, location);
        //                     break;
        //                 case '7':
        //                     validMove = PieceConstructor.bP7.CreateValidMoveArrayWithoutForwardMove(piece, location);
        //                     break;
        //                 case '8':
        //                     validMove = PieceConstructor.bP8.CreateValidMoveArrayWithoutForwardMove(piece, location);
        //                     break;
        //             }
        //             break;
        //     }
        //     return validMove;
        // }

        // method to Notate the moves, for special moves like el passant and castling
        private static void NotateMove(string pieceLocation, string piece, string moveLocation, string pieceMove)
        {
            switch (piece[1])
            {
                case 'P':
                    if (pieceMove != "null")
                        NotatedMoves.Append($"{piece[0]}{pieceLocation}x{moveLocation}");
                    else
                    {
                        switch (piece[0], piece[2])
                        {
                            case ('w', '1'):
                                if (PieceConstructor.wP1.lastTurnWithPiece)
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}f");
                                else
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}");
                                break;
                            case ('w', '2'):
                                if (PieceConstructor.wP2.lastTurnWithPiece)
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}f");
                                else
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}");
                                break;
                            case ('w', '3'):
                                if (PieceConstructor.wP3.lastTurnWithPiece)
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}f");
                                else
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}");
                                break;
                            case ('w', '4'):
                                if (PieceConstructor.wP4.lastTurnWithPiece)
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}f");
                                else
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}");
                                break;
                            case ('w', '5'):
                                if (PieceConstructor.wP5.lastTurnWithPiece)
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}f");
                                else
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}");
                                break;
                            case ('w', '6'):
                                if (PieceConstructor.wP6.lastTurnWithPiece)
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}f");
                                else
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}");
                                break;
                            case ('w', '7'):
                                if (PieceConstructor.wP7.lastTurnWithPiece)
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}f");
                                else
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}");
                                break;
                            case ('w', '8'):
                                if (PieceConstructor.wP8.lastTurnWithPiece)
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}f");
                                else
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}");
                                break;


                            case ('b', '1'):
                                if (PieceConstructor.wP1.lastTurnWithPiece)
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}f");
                                else
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}");
                                break;
                            case ('b', '2'):
                                if (PieceConstructor.wP2.lastTurnWithPiece)
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}f");
                                else
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}");
                                break;
                            case ('b', '3'):
                                if (PieceConstructor.wP3.lastTurnWithPiece)
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}f");
                                else
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}");
                                break;
                            case ('b', '4'):
                                if (PieceConstructor.wP4.lastTurnWithPiece)
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}f");
                                else
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}");
                                break;
                            case ('b', '5'):
                                if (PieceConstructor.wP5.lastTurnWithPiece)
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}f");
                                else
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}");
                                break;
                            case ('b', '6'):
                                if (PieceConstructor.wP6.lastTurnWithPiece)
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}f");
                                else
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}");
                                break;
                            case ('b', '7'):
                                if (PieceConstructor.wP7.lastTurnWithPiece)
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}f");
                                else
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}");
                                break;
                            case ('b', '8'):
                                if (PieceConstructor.wP8.lastTurnWithPiece)
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}f");
                                else
                                    NotatedMoves.Append($"{piece[0]}{moveLocation}");
                                break;
                        }
                    }
                    break;
                case 'R':
                    if (pieceMove != "null")
                        NotatedMoves.Append($"{piece}{pieceLocation}x{moveLocation}");
                    else
                        NotatedMoves.Append($"{piece}{moveLocation}");

                    break;
                case 'B':
                    if (pieceMove != "null")
                        NotatedMoves.Append($"{piece}{pieceLocation}x{moveLocation}");
                    else
                        NotatedMoves.Append($"{piece}{moveLocation}");

                    break;
                case 'N':
                    if (pieceMove != "null")
                        NotatedMoves.Append($"{piece}{pieceLocation}x{moveLocation}");
                    else
                        NotatedMoves.Append($"{piece}{moveLocation}");

                    break;
                case 'Q':
                    if (pieceMove != "null")
                        NotatedMoves.Append($"{piece}{pieceLocation}x{moveLocation}");
                    else
                        NotatedMoves.Append($"{piece}{moveLocation}");

                    break;
                case 'K':
                    if (pieceMove != "null")
                        NotatedMoves.Append($"{piece}{pieceLocation}x{moveLocation}");
                    else
                        NotatedMoves.Append($"{piece}{moveLocation}");

                    break;
            }
        }

        // method to change from board squares to the corresponding number
        public static int Converter(string location)
        {
            switch (location)
            {
                case "a1": return 1;
                case "a2": return 2;
                case "a3": return 3;
                case "a4": return 4;
                case "a5": return 5;
                case "a6": return 6;
                case "a7": return 7;
                case "a8": return 8;
                case "b1": return 9;
                case "b2": return 10;
                case "b3": return 11;
                case "b4": return 12;
                case "b5": return 13;
                case "b6": return 14;
                case "b7": return 15;
                case "b8": return 16;
                case "c1": return 17;
                case "c2": return 18;
                case "c3": return 19;
                case "c4": return 20;
                case "c5": return 21;
                case "c6": return 22;
                case "c7": return 23;
                case "c8": return 24;
                case "d1": return 25;
                case "d2": return 26;
                case "d3": return 27;
                case "d4": return 28;
                case "d5": return 29;
                case "d6": return 30;
                case "d7": return 31;
                case "d8": return 32;
                case "e1": return 33;
                case "e2": return 34;
                case "e3": return 35;
                case "e4": return 36;
                case "e5": return 37;
                case "e6": return 38;
                case "e7": return 39;
                case "e8": return 40;
                case "f1": return 41;
                case "f2": return 42;
                case "f3": return 43;
                case "f4": return 44;
                case "f5": return 45;
                case "f6": return 46;
                case "f7": return 47;
                case "f8": return 48;
                case "g1": return 49;
                case "g2": return 50;
                case "g3": return 51;
                case "g4": return 52;
                case "g5": return 53;
                case "g6": return 54;
                case "g7": return 55;
                case "g8": return 56;
                case "h1": return 57;
                case "h2": return 58;
                case "h3": return 59;
                case "h4": return 60;
                case "h5": return 61;
                case "h6": return 62;
                case "h7": return 63;
                case "h8": return 64;
                default: return 0;
            }
        }

        // method to get were to move and check the locations
        public static void PlayGame()
        {
            bool kingAlive = true;
            while (kingAlive)
            {
                int pieceLocationNum = 0;
            movePieceStart:
                Console.Clear();
                Game.DisplayBoard();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Type in the location of the piece you would like to move.");
                string moveChoicePiece = Console.ReadLine().ToLower();
                if (moveChoicePiece == "0") goto movePieceStart;
                Console.WriteLine("Checking your piece choice...");
                string pieceChosen = "";
                string pieceLocation = "";
                int l = 0;
                int t = 0;
                for (int i = 0; i < BoardLocations.GetLength(0); i++)
                {
                    for (int j = 0; j < BoardLocations.GetLength(1); j++)
                    {
                        if (BoardLocations[i, j] == moveChoicePiece && PieceCurrentLocations[i, j] != "null")
                        {
                            pieceChosen = PieceCurrentLocations[i, j];
                            pieceLocation = BoardLocations[i, j];
                            l = i;
                            t = j;
                            pieceLocationNum = Converter(pieceLocation);
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
                PieceValidMove = UpdateValidMove(pieceChosen, pieceLocation);

            moveToCheck:
                Console.WriteLine("Where do you want to move the piece too? [any num to change piece]");
                string moveChoiceLocation = Console.ReadLine();
                int moveChoiceLocationNum = 0;
                if (int.TryParse(moveChoiceLocation, out moveChoiceLocationNum)) goto movePieceStart;
                for (int i = 0; i < BoardLocations.GetLength(0); i++)
                {
                    for (int j = 0; j < BoardLocations.GetLength(1); j++)
                    {
                        // Console.WriteLine(BoardLocations[i, j] == moveChoiceLocation);
                        // Console.WriteLine(PieceValidMove[i, j]);
                        if (BoardLocations[i, j] == moveChoiceLocation && PieceValidMove[i, j] != "null")
                        {
                            NotateMove(pieceLocation, pieceChosen, moveChoiceLocation, PieceCurrentLocations[i, j]);

                            moveChoiceLocationNum = Converter(BoardLocations[i, j]);
                            PieceCurrentLocations[i, j] = PieceCurrentLocations[l, t];
                            PieceCurrentLocations[l, t] = "null";
                            kingAlive = Game.MovePiece(pieceLocationNum, moveChoiceLocationNum);
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
}