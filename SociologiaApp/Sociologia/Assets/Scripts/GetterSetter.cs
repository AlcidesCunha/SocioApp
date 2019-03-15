using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterSetter : MonoBehaviour
{
    public static string[] getArray(String texto)
    {
        string[] trimm = texto.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        return trimm;
    }
}
