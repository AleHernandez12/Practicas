using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;


public class Track : MonoBehaviour
{

    public AudioClip clip;
    public TMP_Text clipName;
    public Button thisbutton;
    public AudioSource audioSource;
    public int idTrack;
  

    void Start()
    {
        try
        {
            clipName.text = clip.name;
            audioSource = FindAnyObjectByType<AudioSource>();
        }
        catch
        {
            Destroy(gameObject);
        }
       
    }

    public void PlayTrack()
    {
        audioSource.clip = clip;
        audioSource.Play();
    }
}
