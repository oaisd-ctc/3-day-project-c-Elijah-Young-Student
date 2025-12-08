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
            if (boardArray[answer-1] == pawnArray)
            {
                int angleLeft = answerTwo- answer;
                int angleRight = answerTwo-answer;
                if (((answerTwo-1 == answer + 15 || answerTwo - 1 == answer + 7) && boardArray[answerTwo-1] == empty) || ((boardArray[answerTwo-1] == pawnArrayTwo || boardArray[answerTwo-1] == rookArrayTwo  || boardArray[answerTwo-1] == knightArrayTwo || boardArray[answerTwo-1] == bishopArrayTwo || boardArray[answerTwo-1] == queenArrayTwo  || boardArray[answerTwo-1] == kingArrayTwo) && (angleLeft == 7 || angleRight == 9)))
                {
                    string[] save = boardArray[answer-1];
                    boardArray[answer-1] = empty;
                    boardArray[answerTwo-1] = save;
                }
                else
                {
                    Console.WriteLine("That is not an available space");
                }
            }
            else if (boardArray[answer-1] == pawnArrayTwo)
            {
                int angleLeft = answer- answerTwo;
                int angleRight = answer-answerTwo;
                if (((answerTwo-1 == answer - 9 || answerTwo - 1 == answer -17) && boardArray[answerTwo-1] == empty) || ((boardArray[answerTwo-1] == pawnArray || boardArray[answerTwo-1] == rookArray  || boardArray[answerTwo-1] == knightArray || boardArray[answerTwo-1] == bishopArray || boardArray[answerTwo-1] == queenArray  || boardArray[answerTwo-1] == kingArray) && (angleLeft == 9 || angleRight == 7)))
                {
                    string[] save = boardArray[answer-1];
                    boardArray[answer-1] = empty;
                    boardArray[answerTwo-1] = save;
                }
                else
                {
                    Console.WriteLine("That is not an available space");
                }
            }else if (boardArray[answer-1] == rookArray || boardArray[answer-1] == rookArrayTwo)
            {
                int checkDistanceForward = answerTwo - answer;
                int checkDistanceBackward = answer-answerTwo;
                if ((answerTwo <= 8 && answerTwo >= 1 && answer<=8 && answer>=1) || (answerTwo <= 16 && answerTwo >= 9 && answer<=16 && answer>=9) || (answerTwo <= 24 && answerTwo >= 17 && answer<=24 && answer>=17) || (answerTwo <= 32 && answerTwo >= 25 && answer<=32 && answer>=25) || (answerTwo <= 40 && answerTwo >= 33 && answer<=40 && answer>=33) || (answerTwo <= 48 && answerTwo >= 41 && answer<=48 && answer>=41)||(answerTwo <= 56 && answerTwo >= 49 && answer<=56 && answer>=49)||(answerTwo <= 64 && answerTwo >= 57 && answer<=64 && answer >= 57))
                {
                    if (boardArray[answerTwo-1] == empty || (boardArray[answer-1] == rookArray && (boardArray[answerTwo-1] == pawnArrayTwo || boardArray[answerTwo-1] == rookArrayTwo || boardArray[answerTwo-1] == knightArrayTwo ||boardArray[answerTwo-1] == bishopArrayTwo || boardArray[answerTwo-1] == kingArrayTwo ||boardArray[answerTwo-1] == queenArrayTwo)))
                    {
                        string[] save = boardArray[answer-1];
                        boardArray[answer-1] = empty;
                        boardArray[answerTwo-1] = save;
                    }
                    else if (boardArray[answerTwo-1] == empty || (boardArray[answer-1] == rookArrayTwo && (boardArray[answerTwo-1] == pawnArray || boardArray[answerTwo-1] == rookArray || boardArray[answerTwo-1] == knightArray ||boardArray[answerTwo-1] == bishopArray || boardArray[answerTwo-1] == kingArray ||boardArray[answerTwo-1] == queenArray)))
                    {
                        string[] save = boardArray[answer-1];
                        boardArray[answer-1] = empty;
                        boardArray[answerTwo-1] = save;
                    }
                    else
                    {
                        Console.WriteLine("That space is not available");
                    }
                }
                else if(checkDistanceForward %8 == 0 || checkDistanceBackward %8 == 0)
                {
                    if (boardArray[answerTwo-1] == empty || (boardArray[answer-1] == rookArray && (boardArray[answerTwo-1] == pawnArrayTwo || boardArray[answerTwo-1] == rookArrayTwo || boardArray[answerTwo-1] == knightArrayTwo ||boardArray[answerTwo-1] == bishopArrayTwo || boardArray[answerTwo-1] == kingArrayTwo ||boardArray[answerTwo-1] == queenArrayTwo)))
                    {
                        string[] save = boardArray[answer-1];
                        boardArray[answer-1] = empty;
                        boardArray[answerTwo-1] = save;
                    }
                    else if (boardArray[answerTwo-1] == empty || (boardArray[answer-1] == rookArrayTwo && (boardArray[answerTwo-1] == pawnArray || boardArray[answerTwo-1] == rookArray || boardArray[answerTwo-1] == knightArray ||boardArray[answerTwo-1] == bishopArray || boardArray[answerTwo-1] == kingArray ||boardArray[answerTwo-1] == queenArray)))
                    {
                        string[] save = boardArray[answer-1];
                        boardArray[answer-1] = empty;
                        boardArray[answerTwo-1] = save;
                    }
                    else
                    {
                        Console.WriteLine("That space is not available");
                    }
                }
                else
                {
                    Console.WriteLine("That is not an available space!");
                }
            }else if (boardArray[answer -1] == bishopArray || boardArray[answer-1] == bishopArrayTwo)
            {
                int checkAngleUpLeft = answerTwo - answer;
                int checkAngleUpRight = answerTwo -answer;
                int checkAngleDownLeft = answer - answerTwo;
                int checkAngleDownRight = answer - answerTwo;
                if (checkAngleUpLeft %7 == 0 || checkAngleUpRight %9 == 0 || checkAngleDownLeft %9==0 || checkAngleDownRight %7 == 0)
                {
                    if (boardArray[answerTwo-1] == empty || (boardArray[answer-1] == bishopArray && (boardArray[answerTwo-1] == pawnArrayTwo || boardArray[answerTwo-1] == rookArrayTwo || boardArray[answerTwo-1] == knightArrayTwo ||boardArray[answerTwo-1] == bishopArrayTwo || boardArray[answerTwo-1] == kingArrayTwo ||boardArray[answerTwo-1] == queenArrayTwo)))
                    {
                        string[] save = boardArray[answer-1];
                        boardArray[answer-1] = empty;
                        boardArray[answerTwo-1] = save;
                    }
                    else if (boardArray[answerTwo-1] == empty || (boardArray[answer-1] == bishopArrayTwo && (boardArray[answerTwo-1] == pawnArray || boardArray[answerTwo-1] == rookArray || boardArray[answerTwo-1] == knightArray ||boardArray[answerTwo-1] == bishopArray || boardArray[answerTwo-1] == kingArray ||boardArray[answerTwo-1] == queenArray)))
                    {
                        string[] save = boardArray[answer-1];
                        boardArray[answer-1] = empty;
                        boardArray[answerTwo-1] = save;
                    }
                    else
                    {
                        Console.WriteLine("That space is not available");
                    }
                }
                else
                {
                    Console.WriteLine("That space is not available");
                }
            }else if (boardArray[answer-1] == queenArray || boardArray[answer-1] == queenArrayTwo)
            {
                int checkAngleUpLeft = answerTwo - answer;
                int checkAngleUpRight = answerTwo -answer;
                int checkAngleDownLeft = answer - answerTwo;
                int checkDistanceForward = answerTwo - answer;
                int checkDistanceBackward = answer-answerTwo;
                int checkAngleDownRight = answer - answerTwo;
                if (checkAngleUpLeft %7 == 0 || checkAngleUpRight %9 == 0 || checkAngleDownLeft %9==0 || checkAngleDownRight %7 == 0)
                {
                   if (boardArray[answerTwo-1] == empty || (boardArray[answer-1] == queenArray && (boardArray[answerTwo-1] == pawnArrayTwo || boardArray[answerTwo-1] == rookArrayTwo || boardArray[answerTwo-1] == knightArrayTwo ||boardArray[answerTwo-1] == bishopArrayTwo || boardArray[answerTwo-1] == kingArrayTwo ||boardArray[answerTwo-1] == queenArrayTwo)))
                    {
                        string[] save = boardArray[answer-1];
                        boardArray[answer-1] = empty;
                        boardArray[answerTwo-1] = save;
                    }
                    else if (boardArray[answerTwo-1] == empty || (boardArray[answer-1] == queenArrayTwo && (boardArray[answerTwo-1] == pawnArray || boardArray[answerTwo-1] == rookArray || boardArray[answerTwo-1] == knightArray ||boardArray[answerTwo-1] == bishopArray || boardArray[answerTwo-1] == kingArray ||boardArray[answerTwo-1] == queenArray)))
                    {
                        string[] save = boardArray[answer-1];
                        boardArray[answer-1] = empty;
                        boardArray[answerTwo-1] = save;
                    }
                    else
                    {
                        Console.WriteLine("That space is not available");
                    }
                }
                else if ((answerTwo <= 8 && answerTwo >= 1 && answer<=8 && answer>=1) || (answerTwo <= 16 && answerTwo >= 9 && answer<=16 && answer>=9) || (answerTwo <= 24 && answerTwo >= 17 && answer<=24 && answer>=17) || (answerTwo <= 32 && answerTwo >= 25 && answer<=32 && answer>=25) || (answerTwo <= 40 && answerTwo >= 33 && answer<=40 && answer>=33) || (answerTwo <= 48 && answerTwo >= 41 && answer<=48 && answer>=41)||(answerTwo <= 56 && answerTwo >= 49 && answer<=56 && answer>=49)||(answerTwo <= 64 && answerTwo >= 57 && answer<=64 && answer >= 57))
                {
                    if (boardArray[answerTwo-1] == empty || (boardArray[answer-1] == queenArray && (boardArray[answerTwo-1] == pawnArrayTwo || boardArray[answerTwo-1] == rookArrayTwo || boardArray[answerTwo-1] == knightArrayTwo ||boardArray[answerTwo-1] == bishopArrayTwo || boardArray[answerTwo-1] == kingArrayTwo ||boardArray[answerTwo-1] == queenArrayTwo)))
                    {
                        string[] save = boardArray[answer-1];
                        boardArray[answer-1] = empty;
                        boardArray[answerTwo-1] = save;
                    }
                    else if (boardArray[answerTwo-1] == empty || (boardArray[answer-1] == queenArrayTwo && (boardArray[answerTwo-1] == pawnArray || boardArray[answerTwo-1] == rookArray || boardArray[answerTwo-1] == knightArray ||boardArray[answerTwo-1] == bishopArray || boardArray[answerTwo-1] == kingArray ||boardArray[answerTwo-1] == queenArray)))
                    {
                        string[] save = boardArray[answer-1];
                        boardArray[answer-1] = empty;
                        boardArray[answerTwo-1] = save;
                    }
                    else
                    {
                        Console.WriteLine("That space is not available");
                    }
                }
                else if(checkDistanceForward %8 == 0 || checkDistanceBackward %8 == 0)
                {
                    if (boardArray[answerTwo-1] == empty || (boardArray[answer-1] == queenArray && (boardArray[answerTwo-1] == pawnArrayTwo || boardArray[answerTwo-1] == rookArrayTwo || boardArray[answerTwo-1] == knightArrayTwo ||boardArray[answerTwo-1] == bishopArrayTwo || boardArray[answerTwo-1] == kingArrayTwo ||boardArray[answerTwo-1] == queenArrayTwo)))
                    {
                        string[] save = boardArray[answer-1];
                        boardArray[answer-1] = empty;
                        boardArray[answerTwo-1] = save;
                    }
                    else if (boardArray[answerTwo-1] == empty || (boardArray[answer-1] == queenArrayTwo && (boardArray[answerTwo-1] == pawnArray || boardArray[answerTwo-1] == rookArray || boardArray[answerTwo-1] == knightArray ||boardArray[answerTwo-1] == bishopArray || boardArray[answerTwo-1] == kingArray ||boardArray[answerTwo-1] == queenArray)))
                    {
                        string[] save = boardArray[answer-1];
                        boardArray[answer-1] = empty;
                        boardArray[answerTwo-1] = save;
                    }
                    else
                    {
                        Console.WriteLine("That space is not available");
                    }
                }
                else
                {
                    Console.WriteLine("That is not an available space!");
                }
            }else if (boardArray[answer-1] == kingArray || boardArray[answer-1] == kingArrayTwo)
            {
                int checkAngleUpLeft = answerTwo - answer;
                int checkAngleUpRight = answerTwo -answer;
                int checkAngleDownLeft = answer - answerTwo;
                int checkDistanceForward = answerTwo - answer;
                int checkRight = answerTwo - answer;
                int checkLeft = answer - answerTwo;
                int checkDistanceBackward = answer-answerTwo;
                int checkAngleDownRight = answer - answerTwo;
                if (checkAngleDownLeft == 7 || checkAngleDownRight == 9 || checkAngleUpLeft == 9 || checkAngleUpRight == 7 || checkDistanceForward == 8 || checkDistanceBackward == 8 || checkLeft == 1 || checkRight == 1 )
                {
                    if (boardArray[answerTwo-1] == empty || (boardArray[answer-1] == kingArray && (boardArray[answerTwo-1] == pawnArrayTwo || boardArray[answerTwo-1] == rookArrayTwo || boardArray[answerTwo-1] == knightArrayTwo ||boardArray[answerTwo-1] == bishopArrayTwo || boardArray[answerTwo-1] == kingArrayTwo ||boardArray[answerTwo-1] == queenArrayTwo)))
                    {
                        string[] save = boardArray[answer-1];
                        boardArray[answer-1] = empty;
                        boardArray[answerTwo-1] = save;
                    }
                    else if (boardArray[answerTwo-1] == empty || (boardArray[answer-1] == kingArrayTwo && (boardArray[answerTwo-1] == pawnArray || boardArray[answerTwo-1] == rookArray || boardArray[answerTwo-1] == knightArray ||boardArray[answerTwo-1] == bishopArray || boardArray[answerTwo-1] == kingArray ||boardArray[answerTwo-1] == queenArray)))
                    {
                        string[] save = boardArray[answer-1];
                        boardArray[answer-1] = empty;
                        boardArray[answerTwo-1] = save;
                    }
                    else
                    {
                        Console.WriteLine("That space is not available");
                    }
                }
                else
                {
                    Console.WriteLine("That space is not available");
                }
            }else if (boardArray[answer -1] == knightArray || boardArray[answer-1] == knightArrayTwo)
            {
                int Up = answerTwo - answer;
                int Down = answer - answerTwo;
                if (Up == 17 || Up == 15 || Up == 10 || Up == 6 || Down == 17 || Down == 15 || Down == 10 || Down == 6)
                {
                    if (boardArray[answerTwo-1] == empty || (boardArray[answer-1] == knightArray && (boardArray[answerTwo-1] == pawnArrayTwo || boardArray[answerTwo-1] == rookArrayTwo || boardArray[answerTwo-1] == knightArrayTwo ||boardArray[answerTwo-1] == bishopArrayTwo || boardArray[answerTwo-1] == kingArrayTwo ||boardArray[answerTwo-1] == queenArrayTwo)))
                    {
                        string[] save = boardArray[answer-1];
                        boardArray[answer-1] = empty;
                        boardArray[answerTwo-1] = save;
                    }
                    else if (boardArray[answerTwo-1] == empty || (boardArray[answer-1] == knightArrayTwo && (boardArray[answerTwo-1] == pawnArray || boardArray[answerTwo-1] == rookArray || boardArray[answerTwo-1] == knightArray ||boardArray[answerTwo-1] == bishopArray || boardArray[answerTwo-1] == kingArray ||boardArray[answerTwo-1] == queenArray)))
                    {
                        string[] save = boardArray[answer-1];
                        boardArray[answer-1] = empty;
                        boardArray[answerTwo-1] = save;
                    }
                    else
                    {
                        Console.WriteLine("That space is not available");
                    }
                }
                else
                {
                    Console.WriteLine("That space is not avaiable");
                }                 
                
            }
            else
            {
                Console.WriteLine("That is not a piece!");
            }
            
                
                if (boardArray.Contains(kingArray) && boardArray.Contains(kingArrayTwo))
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