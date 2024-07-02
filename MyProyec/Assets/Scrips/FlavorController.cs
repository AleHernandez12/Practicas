using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeImage : MonoBehaviour
{
    
    public TMP_Dropdown ColorOptions;

    
    public Image Pastel;

    
    public Sprite graySprite;
    public Sprite yellowSprite;
    public Sprite magentaSprite;

    private void Start()
    {
        
        if (ColorOptions == null)
        {
            ColorOptions = GetComponent<TMP_Dropdown>();
        }

        
        if (Pastel == null)
        {
            Pastel = GameObject.Find("Pastel").GetComponent<Image>();
        }

        
        ColorOptions.onValueChanged.AddListener(delegate { ChangeFlavor(); });
    }

    public void ChangeFlavor()
    {
        
        switch (ColorOptions.value)
        {
            case 0:
                Pastel.sprite = graySprite;
                break;

            case 1:
                Pastel.sprite = yellowSprite;
                break;

            case 2:
                Pastel.sprite = magentaSprite;
                break;

            default:
                
                break;
        }
    }
}
