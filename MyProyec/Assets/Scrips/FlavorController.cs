using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeImage : MonoBehaviour
{
    // Referencia al TMP_Dropdown
    public TMP_Dropdown ColorOptions;

    // Referencia al componente Image
    public Image Pastel;

    // Referencias a los sprites
    public Sprite graySprite;
    public Sprite yellowSprite;
    public Sprite magentaSprite;

    private void Start()
    {
        // Obtener el componente TMP_Dropdown si no se ha asignado
        if (ColorOptions == null)
        {
            ColorOptions = GetComponent<TMP_Dropdown>();
        }

        // Obtener el componente Image si no se ha asignado
        if (Pastel == null)
        {
            Pastel = GameObject.Find("Pastel").GetComponent<Image>();
        }

        // Asignar el método al evento onValueChanged
        ColorOptions.onValueChanged.AddListener(delegate { ChangeFlavor(); });
    }

    public void ChangeFlavor()
    {
        // Cambiar el sprite del componente Image basado en el valor del dropdown
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
                // Opcional: manejar casos adicionales o valores por defecto
                break;
        }
    }
}
