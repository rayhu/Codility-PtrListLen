using System;
using System.Collections.Generic;


class Solution {
    public int solution(IntList L) {
        if (L.next!=null)
            return solution(L.next) +1;
        else return 1;
    }
}
