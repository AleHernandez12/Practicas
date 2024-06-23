using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class FlavorController : MonoBehaviour
{
    private TMP_Dropdown ColorOptions;
    public Image Pastel;

    private void Start()
    {
        ColorOptions = GetComponent<TMP_Dropdown>();
        Pastel = GameObject.Find("Pastel").GetComponent<Image>();
    }

    public void ChangeFlavor()
    {
        switch (ColorOptions.value)
        {
            case 0:
            Pastel.color = Color.gray;
            break;

            case 1:
                Pastel.color = Color.yellow;
                break;

            case 2:
                Pastel.color = Color.magenta;
                break;
        }
    }
}
