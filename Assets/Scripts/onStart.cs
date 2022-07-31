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
        //Debug.Log("awake: " + Items.cherries + " and " + Items.melon);
    }
}
