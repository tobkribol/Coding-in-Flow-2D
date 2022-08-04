using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onStart : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        PlayerPrefs.DeleteAll();
        Items.Init(0, 0);
        PlayerStats.Init(1.0f);
        HelthBarFunction.SetHealthBarValue(1.0f);
        Debug.Log("Health start: " + HelthBarFunction.GetHealthBarValue());
        Debug.Log("Items start: " + Items.cherries + " and " + Items.melon);
    }
}
