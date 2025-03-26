using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PagingUtil
{
    public static int GetTotalPage(int totalContent, int showPagePerData)
    {
        if (totalContent % showPagePerData != 0)
        {
            return totalContent / showPagePerData + 1;
        }
        return totalContent / showPagePerData;
    }

}
