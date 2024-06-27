using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscenas : MonoBehaviour
{
    
    public void ControlEscena(string escena)
    {
        SceneManager.LoadScene(escena);
    }
}
