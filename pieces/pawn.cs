namespace pieces;


class pawn
{

    

    public static void pawnArt()
    {
        Console.Clear();
        Console.WriteLine("        :#@*        ");
        Console.WriteLine("       %@@@@@       ");
        Console.WriteLine("       %@@@@@       ");
        Console.WriteLine("       =@@@@#:      ");
        Console.WriteLine("       =@@@@+       ");
        Console.WriteLine("     -+*@@@@#@-     ");
        Console.WriteLine("     %@@@@@@@@@     ");
        Console.WriteLine("    -@@@@@@@@@@+    ");
        
    }
    public static void rookPiece()
    {
        Console.WriteLine("     :. .:. .:      ");
        Console.WriteLine("     @%#%@%#%@      ");
        Console.WriteLine("     %@@@@@@@%      ");
        Console.WriteLine("      -*###*-       ");
        Console.WriteLine("      :@@@@@-       ");
        Console.WriteLine("      :@@@@@-       ");
        Console.WriteLine("      -@@@@@=       ");
        Console.WriteLine("      *@@@@@*.      ");
        Console.WriteLine("     ::::::::.      ");
        Console.WriteLine("   :==--------=-    ");
        Console.WriteLine("    .:::::::::.     ");
    }
    public static void knightPiece()
    {
        Console.WriteLine("          *#        ");
        Console.WriteLine("        =@@@@#@     ");
        Console.WriteLine("     .@@@@@@@@#@    ");
        Console.WriteLine("     @@@@@@@@@@@#   ");
        Console.WriteLine("          @@@@+@+   ");
        Console.WriteLine("        +@@@@@@@    ");
        Console.WriteLine("       @#@@@@@@@    ");
        Console.WriteLine("      @#@@@@@@@@    ");
        Console.WriteLine("       @@@@@@@#-    ");
        Console.WriteLine("       @@@@@@@#     ");
        Console.WriteLine("      @-@@@@@@@%    ");
        Console.WriteLine("     -#*+====+*#    ");               
    }
    public static void bishopPiece()
    {
        Console.Clear();
        Console.WriteLine("        :#@@*       ");
        Console.WriteLine("       %@@@@@@      ");
        Console.WriteLine("       %@@@@@@      ");
        Console.WriteLine("       =@@|@@#      ");
        Console.WriteLine("       =@-|-@+      ");
        Console.WriteLine("        @@|@@       ");
        Console.WriteLine("        @@|@@       ");
        Console.WriteLine("       =@@@@@+      ");
        Console.WriteLine("     -+*@@@@#@-     ");
        Console.WriteLine("     %@@@@@@@@@     ");
        Console.WriteLine("    -@@@@@@@@@@+    ");
    }
    public static void kingPiece()
    {
        Console.Clear();
        Console.WriteLine("         @@         ");
        Console.WriteLine("      #--##--#      ");
        Console.WriteLine("         @@         ");
        Console.WriteLine("        :#@*        ");
        Console.WriteLine("       %@@@@@       ");
        Console.WriteLine("       %@@@@@       ");
        Console.WriteLine("       =@@@@#:      ");
        Console.WriteLine("       =@@@@+       ");
        Console.WriteLine("     -+*@@@@#@-     ");
        Console.WriteLine("     %@@@@@@@@@     ");
        Console.WriteLine("    -@@@@@@@@@@+    ");
    }
    public static void queenPiece()
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Clear();
        Console.WriteLine("     -@ *@@@* @-    ");
        Console.WriteLine("       @@@@@@@      ");
        Console.WriteLine("       @@@+@@@      ");
        Console.WriteLine("       =@@@@@#      ");
        Console.WriteLine("       =@@@@@+      ");
        Console.WriteLine("        @@@@@       ");
        Console.WriteLine("        @@@@@       ");
        Console.WriteLine("       =@@@@@+      ");
        Console.WriteLine("     -+@@@@@#@-     ");
        Console.WriteLine("     %@@@@@@@@@     ");
        Console.WriteLine("    -@@@@@@@@@@+    ");
        Console.ResetColor();
    }
    public static void run()
    {
        string[] empty = {"                    ", "                    ", "                    ", "                    ", "                    ", "                    ",
        "                    ","                    ","                    ","                    ","                    ","                    ",};
       
        string[] pawnArray = {"                    ","                    ","        :#@*        ", "       %@@@@@       ", "       %@@@@@       ",
        "       =@@@@#:      ","       =@@@@+       ", "     -+*@@@@#@-     ", "     %@@@@@@@@@     ","    -@@@@@@@@@@+    ","                    ","                    "};
        string[] rookArray = {"     :. .:. .:      ", "     @%#%@%#%@      ","     %@@@@@@@%      ", "      -*###*-       ",
        "      :@@@@@-       ", "      :@@@@@-       ", "      -@@@@@=       " , "      *@@@@@*.      " , "     ::::::::.      ",
        "   :==--------=-    " , "    .:::::::::.     ", "                    "};
        string[] knightArray = {"          *#        ", "        =@@@@#@     ", "     .@@@@@@@@#@    ", "     @@@@@@@@@@@#   ",
        "          @@@@+@+   ", "        +@@@@@@@    ", "       @#@@@@@@@    ", "      @#@@@@@@@@    ", "       @@@@@@@#-    ","       @@@@@@@#     ",
        "      @-@@@@@@@%    " , "     -#*+====+*#    "};
        string[] bishopArray = {"        :#@@*       ", "       %@@@@@@      ", "       %@@@@@@      ", "       =@ | @#      ",
        "       =@-|-@+      ", "        @ | @       ", "        @ | @       ", "       =@@@@@+      ", "     -+*@@@@#@-     ",
        "     %@@@@@@@@@     ", "    -@@@@@@@@@@+    ", "                    "};
        string[] kingArray = {"         @@         ", "      #--##--#      ", "         @@         ", "        :#@*        ", "       %@@@@@       ",
        "       %@@@@@       ","       =@@@@#:      ", "       =@@@@+       ","     -+*@@@@#@-     ","     %@@@@@@@@@     ","    -@@@@@@@@@@+    ","                    "};
        string[] queenArray = {"     -@ *@@@* @-    ", "       @@@@@@@      ", "       @@@+@@@      ", "       =@@@@@#      ", "       =@@@@@+      ", 
        "        @@@@@       ","        @@@@@       ","       =@@@@@+      ","     -+@@@@@#@-     ","     %@@@@@@@@@     ","    -@@@@@@@@@@+    ", "                    "};
        
        string[][] boardArray = {rookArray, knightArray, bishopArray, kingArray, queenArray, bishopArray, knightArray, rookArray, pawnArray, pawnArray, pawnArray, pawnArray, pawnArray, pawnArray, pawnArray, pawnArray,
             empty, empty, empty, empty,empty,empty, empty, empty, empty, empty, empty, empty,empty,empty, empty, empty, empty, empty, empty, empty,empty,empty, empty, empty,empty, empty, empty, empty,empty,empty, empty, empty,
             pawnArray, pawnArray, pawnArray, pawnArray, pawnArray, pawnArray, pawnArray, pawnArray, 
             rookArray, knightArray, bishopArray, kingArray, queenArray, bishopArray, knightArray, rookArray};
        int i = 0;
        while (true)
        {


                for (int o = 0; o < 12; o++)
                {
                    Console.Write(boardArray[0][o]);
                    Console.Write(boardArray[1][o]);
                    Console.Write(boardArray[2][o]);
                    Console.Write(boardArray[3][o]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(boardArray[4][o]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(boardArray[5][o]);
                    Console.Write(boardArray[6][o]);
                    Console.Write(boardArray[7][o]);
                    Console.WriteLine("");
                }
                Console.WriteLine("");
                for (int e = 0; e < 12; e++)
                {
                    Console.Write(boardArray[8][e]);
                    Console.Write(boardArray[9][e]);
                    Console.Write(boardArray[10][e]);
                    Console.Write(boardArray[11][e]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(boardArray[12][e]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(boardArray[13][e]);
                    Console.Write(boardArray[14][e]);
                    Console.Write(boardArray[15][e]);
                    Console.WriteLine("");
                }
                for (int o = 0; o < 12; o++)
                {
                    Console.Write(boardArray[16][o]);
                    Console.Write(boardArray[17][o]);
                    Console.Write(boardArray[18][o]);
                    Console.Write(boardArray[19][o]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(boardArray[20][o]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(boardArray[21][o]);
                    Console.Write(boardArray[22][o]);
                    Console.Write(boardArray[23][o]);
                    Console.WriteLine("");
                }
                for (int o = 0; o < 12; o++)
                {
                    Console.Write(boardArray[24][o]);
                    Console.Write(boardArray[25][o]);
                    Console.Write(boardArray[26][o]);
                    Console.Write(boardArray[27][o]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(boardArray[28][o]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(boardArray[29][o]);
                    Console.Write(boardArray[30][o]);
                    Console.Write(boardArray[31][o]);
                    Console.WriteLine("");
                }
                for (int o = 0; o < 12; o++)
                {
                    Console.Write(boardArray[32][o]);
                    Console.Write(boardArray[33][o]);
                    Console.Write(boardArray[34][o]);
                    Console.Write(boardArray[35][o]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(boardArray[36][o]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(boardArray[37][o]);
                    Console.Write(boardArray[38][o]);
                    Console.Write(boardArray[39][o]);
                    Console.WriteLine("");
                }
                for (int o = 0; o < 12; o++)
                {
                    Console.Write(boardArray[40][o]);
                    Console.Write(boardArray[41][o]);
                    Console.Write(boardArray[42][o]);
                    Console.Write(boardArray[43][o]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(boardArray[44][o]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(boardArray[45][o]);
                    Console.Write(boardArray[46][o]);
                    Console.Write(boardArray[47][o]);
                    Console.WriteLine("");
                }
                for (int o = 0; o < 12; o++)
                {
                    Console.Write(boardArray[48][o]);
                    Console.Write(boardArray[49][o]);
                    Console.Write(boardArray[50][o]);
                    Console.Write(boardArray[51][o]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(boardArray[52][o]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(boardArray[53][o]);
                    Console.Write(boardArray[54][o]);
                    Console.Write(boardArray[55][o]);
                    Console.WriteLine("");
                }
                for (int o = 0; o < 12; o++)
                {
                    Console.Write(boardArray[56][o]);
                    Console.Write(boardArray[57][o]);
                    Console.Write(boardArray[58][o]);
                    Console.Write(boardArray[59][o]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(boardArray[60][o]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(boardArray[61][o]);
                    Console.Write(boardArray[62][o]);
                    Console.Write(boardArray[63][o]);
                    Console.WriteLine("");
                }
                Console.WriteLine("What piece move?");
            int answer = int.Parse(Console.ReadLine());
            Console.WriteLine("To where?");
            int answerTwo = int.Parse(Console.ReadLine());
            
                string[] save = boardArray[answer-1];
                boardArray[answer-1] = empty;
                boardArray[answerTwo-1] = save;
                Thread.Sleep(1000);
                i++;
                Console.Clear();
                
            
            
        }
        
    }
    
}