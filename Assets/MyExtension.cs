using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public class MyExtension
{
    static public string ToNumber(this int value)
    {
        return $"{value:N0}";
    }
}
