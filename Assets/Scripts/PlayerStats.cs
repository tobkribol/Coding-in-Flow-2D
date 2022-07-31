using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerStats
{
    public static float health = 1.00f;
    public static void Init(float starthealth)
    {
        health = starthealth;
        HelthBarFunction.SetHealthBarValue(starthealth);

    }
}