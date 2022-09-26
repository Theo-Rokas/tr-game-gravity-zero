using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetMaxScript : MonoBehaviour
{
    private Text crystalsMax;

    void Start()
    {
        crystalsMax = GetComponent<Text>();

        if (PlayerPrefs.GetInt("CrystalsMax") != 0)
            crystalsMax.text = "Crystals Max: " + PlayerPrefs.GetInt("CrystalsMax");            
    }
}
