using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerStats
{
    public static float health;
    public static void Init(float starthealth)
    {
        health = starthealth;
        HelthBarFunction.SetHealthBarValue(starthealth);

    }
}