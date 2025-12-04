using pieces;

class Program
{
    public static void Main(string[] args)
    {
        pawn Pawn = new pawn();
        pawn.pawnArt();
        Thread.Sleep(2000);
        Console.Clear();
        pawn.rookPiece();
        Thread.Sleep(2000);
        Console.Clear();
        pawn.knightPiece();
        Thread.Sleep(2000);
        Console.Clear();
        pawn.bishopPiece();
        Thread.Sleep(2000);
        pawn.kingPiece();
    }
}