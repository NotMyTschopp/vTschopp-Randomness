using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Combinatorics
{

    private const int RANDOMSEED = 123;
    // public static System.Random rnd = new System.Random(RANDOMSEED);
    public static System.Random rnd = new System.Random();

    public static void Shuffle<T>(this IList<T> list)
    {
        int n = list.Count; // number of objects in list
        while (n > 1)
        {
            n--; // while n > 1, substract in each loop 1
            int k = rnd.Next(n + 1); // integer k is a random number between 0 and n + 1
            T value = list[k]; // new value of 'T' is a random list object
            list[k] = list[n]; // new value of list[k] is list[n]
            list[n] = value; // new value of list[n] is list[k]
        }
    }
}