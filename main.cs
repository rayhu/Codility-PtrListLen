using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(IntList L) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        if (L.next!=null)
            return solution(L.next) +1;
        else return 1;
    }
}
