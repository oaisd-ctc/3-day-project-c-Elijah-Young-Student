namespace GameElements;


class game
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
        string[] empty = {"|                  |", "|                  |", "|                  |", "|                  |", "|                  |", "|                  |",
        "|                  |","|                  |","|                  |","|                  |","--------------------",};
       
        string[] pawnArray = {"|                  |","|                  |","|       :#@*       |", "|      %@@@@@      |", "|      %@@@@@      |",
        "|      =@@@@#:     |","|      =@@@@+      |", "|    -+*@@@@#@-    |", "|    %@@@@@@@@@    |","|   -@@@@@@@@@@+   |","--------------------"};
        string[] pawnArrayTwo = {"|                  |","|                  |","|       :#@*       |", "|      %@@@@@      |", "|      %@@@@@      |",
        "|      =@@@@#:     |","|      =@@@@+      |", "|    -+*@@@@#@-    |", "|    %@@@@@@@@@    |","|   -@@@@@@@@@@+   |","--------------------"};
        string[] rookArray = {"|    :. .:. .:     |", "|    @%#%@%#%@     |","|    %@@@@@@@%     |", "|     -*###*-      |",
        "|     :@@@@@-      |", "|     :@@@@@-      |", "|     -@@@@@=      |" , "|     *@@@@@*.     |" , "|    ::::::::.     |",
        "|  :==--------=-   |" , "--------------------"};
         string[] rookArrayTwo = {"|    :. .:. .:     |", "|    @%#%@%#%@     |","|    %@@@@@@@%     |", "|     -*###*-      |",
        "|     :@@@@@-      |", "|     :@@@@@-      |", "|     -@@@@@=      |" , "|     *@@@@@*.     |" , "|    ::::::::.     |",
        "|  :==--------=-   |" , "--------------------"};
        string[] knightArray = { "|       =@@@@#@    |", "|    .@@@@@@@@#@   |", "|    @@@@@@@@@@@#  |",
        "|         @@@@+@+  |", "|       +@@@@@@@   |", "|      @#@@@@@@@   |", "|     @#@@@@@@@@   |", "|      @@@@@@@#-   |","|      @@@@@@@#    |",
        "|     @-@@@@@@@%   |" , "--------------------"};
         string[] knightArrayTwo = { "|       =@@@@#@    |", "|    .@@@@@@@@#@   |", "|    @@@@@@@@@@@#  |",
        "|         @@@@+@+  |", "|       +@@@@@@@   |", "|      @#@@@@@@@   |", "|     @#@@@@@@@@   |", "|      @@@@@@@#-   |","|      @@@@@@@#    |",
        "|     @-@@@@@@@%   |" , "--------------------"};
        string[] bishopArray = {"|       :#@@*      |", "|      %@@@@@@     |", "|      %@@@@@@     |", "|      =@ | @#     |",
        "|      =@-|-@+     |", "|       @ | @      |", "|       @ | @      |", "|      =@@@@@+     |", "|    -+*@@@@#@-    |",
        "|    %@@@@@@@@@    |", "--------------------"};
        string[] bishopArrayTwo = {"|       :#@@*      |", "|      %@@@@@@     |", "|      %@@@@@@     |", "|      =@ | @#     |",
        "|      =@-|-@+     |", "|       @ | @      |", "|       @ | @      |", "|      =@@@@@+     |", "|    -+*@@@@#@-    |",
        "|    %@@@@@@@@@    |", "--------------------"};
        string[] kingArray = {"|        @@        |", "|     #--##--#     |", "|        @@        |", "|       :#@*       |", "|      %@@@@@      |",
        "|      %@@@@@      |","|      =@@@@#:     |", "|      =@@@@+      |","|    -+*@@@@#@-    |","|    %@@@@@@@@@    |","--------------------"};
        string[] kingArrayTwo = {"|        @@        |", "|     #--##--#     |", "|        @@        |", "|       :#@*       |", "|      %@@@@@      |",
        "|      %@@@@@      |","|      =@@@@#:     |", "|      =@@@@+      |","|    -+*@@@@#@-    |","|    %@@@@@@@@@    |","--------------------"};
        string[] queenArray = {"|    -@ *@@@* @-   |", "|      @@@@@@@     |", "|      @@@+@@@     |", "|      =@@@@@#     |", "|      =@@@@@+     |", 
        "|       @@@@@      |","|       @@@@@      |","|      =@@@@@+     |","|    -+@@@@@#@-    |","|    %@@@@@@@@@    |","--------------------"};
        string[] queenArrayTwo = {"|    -@ *@@@* @-   |", "|      @@@@@@@     |", "|      @@@+@@@     |", "|      =@@@@@#     |", "|      =@@@@@+     |", 
        "|       @@@@@      |","|       @@@@@      |","|      =@@@@@+     |","|    -+@@@@@#@-    |","|    %@@@@@@@@@    |","--------------------"};
        
        string[][] boardArray = {rookArray, knightArray, bishopArray, kingArray, queenArray, bishopArray, knightArray, rookArray, pawnArray, pawnArray, pawnArray, pawnArray, pawnArray, pawnArray, pawnArray, pawnArray,
             empty, empty, empty, empty,empty,empty, empty, empty, empty, empty, empty, empty,empty,empty, empty, empty, empty, empty, empty, empty,empty,empty, empty, empty,empty, empty, empty, empty,empty,empty, empty, empty,
             pawnArrayTwo, pawnArrayTwo, pawnArrayTwo, pawnArrayTwo, pawnArrayTwo, pawnArrayTwo, pawnArrayTwo, pawnArrayTwo, 
             rookArrayTwo, knightArrayTwo, bishopArrayTwo, kingArrayTwo, queenArrayTwo, bishopArrayTwo, knightArrayTwo, rookArrayTwo};
        
        while (true)
        {



                for (int o = 0; o < 11; o++)
                {
                    for (int r = 0; r < 8; r++)
                    {
                        if (boardArray[r] == kingArrayTwo || boardArray[r] == queenArrayTwo || boardArray[r] == bishopArrayTwo ||boardArray[r] == knightArrayTwo ||boardArray[r] == rookArrayTwo ||boardArray[r] == pawnArrayTwo){Console.ForegroundColor = ConsoleColor.Green;}else{Console.ForegroundColor = ConsoleColor.White;}
                        Console.Write(boardArray[r][o]);
                    }
                    
                   
                    Console.WriteLine("");
                }
                for (int e = 0; e < 11; e++)
                {
                    for (int r = 8; r <16; r++)
                    {
                        if (boardArray[r] == kingArrayTwo || boardArray[r] == queenArrayTwo || boardArray[r] == bishopArrayTwo ||boardArray[r] == knightArrayTwo ||boardArray[r] == rookArrayTwo ||boardArray[r] == pawnArrayTwo){Console.ForegroundColor = ConsoleColor.Green;}else{Console.ForegroundColor = ConsoleColor.White;}
                        Console.Write(boardArray[r][e]);
                    }
                    Console.WriteLine("");
                }
                for (int o = 0; o < 11; o++)
                {
                    for (int r = 16; r < 24; r++)
                    {
                        if (boardArray[r] == kingArrayTwo || boardArray[r] == queenArrayTwo || boardArray[r] == bishopArrayTwo ||boardArray[r] == knightArrayTwo ||boardArray[r] == rookArrayTwo ||boardArray[r] == pawnArrayTwo){Console.ForegroundColor = ConsoleColor.Green;}else{Console.ForegroundColor = ConsoleColor.White;}
                        Console.Write(boardArray[r][o]);
                    }
                    Console.WriteLine("");
                }
                for (int o = 0; o < 11; o++)
                {
                    for (int r = 24; r < 32; r++)
                    {
                        if (boardArray[r] == kingArrayTwo || boardArray[r] == queenArrayTwo || boardArray[r] == bishopArrayTwo ||boardArray[r] == knightArrayTwo ||boardArray[r] == rookArrayTwo ||boardArray[r] == pawnArrayTwo){Console.ForegroundColor = ConsoleColor.Green;}else{Console.ForegroundColor = ConsoleColor.White;}
                        Console.Write(boardArray[r][o]);
                    }
                    Console.WriteLine("");
                }
                for (int o = 0; o < 11; o++)
                {
                    for (int r = 32; r < 40; r++)
                    {
                        if (boardArray[r] == kingArrayTwo || boardArray[r] == queenArrayTwo || boardArray[r] == bishopArrayTwo ||boardArray[r] == knightArrayTwo ||boardArray[r] == rookArrayTwo ||boardArray[r] == pawnArrayTwo){Console.ForegroundColor = ConsoleColor.Green;}else{Console.ForegroundColor = ConsoleColor.White;}
                        Console.Write(boardArray[r][o]);
                    }
                    Console.WriteLine("");
                }
                for (int o = 0; o < 11; o++)
                {
                    for (int r = 40; r < 48; r++)
                    {
                        if (boardArray[r] == kingArrayTwo || boardArray[r] == queenArrayTwo || boardArray[r] == bishopArrayTwo ||boardArray[r] == knightArrayTwo ||boardArray[r] == rookArrayTwo ||boardArray[r] == pawnArrayTwo){Console.ForegroundColor = ConsoleColor.Green;}else{Console.ForegroundColor = ConsoleColor.White;}
                        Console.Write(boardArray[r][o]);
                    }
                    Console.WriteLine("");
                }
                for (int o = 0; o < 11; o++)
                {
                    for (int r = 48; r < 56; r++)
                    {
                        if (boardArray[r] == kingArrayTwo || boardArray[r] == queenArrayTwo || boardArray[r] == bishopArrayTwo ||boardArray[r] == knightArrayTwo ||boardArray[r] == rookArrayTwo ||boardArray[r] == pawnArrayTwo){Console.ForegroundColor = ConsoleColor.Green;}else{Console.ForegroundColor = ConsoleColor.White;}
                        Console.Write(boardArray[r][o]);
                    }
                    Console.WriteLine("");
                }
                for (int o = 0; o < 11; o++)
                {
                    for (int r = 56; r < 64; r++)
                    {
                        if (boardArray[r] == kingArrayTwo || boardArray[r] == queenArrayTwo || boardArray[r] == bishopArrayTwo ||boardArray[r] == knightArrayTwo ||boardArray[r] == rookArrayTwo ||boardArray[r] == pawnArrayTwo){Console.ForegroundColor = ConsoleColor.Green;}else{Console.ForegroundColor = ConsoleColor.White;}
                        Console.Write(boardArray[r][o]);
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("What piece move?");
            int answer = int.Parse(Console.ReadLine());
            Console.WriteLine("To where?");
            int answerTwo = int.Parse(Console.ReadLine());
            
                string[] save = boardArray[answer-1];
                boardArray[answer-1] = empty;
                boardArray[answerTwo-1] = save;
                if (boardArray.Contains(kingArray) && boardArray.Contains(kingArray))
                {
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                
                
            

        }

        
    }
    
    
}