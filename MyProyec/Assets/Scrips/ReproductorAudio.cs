using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReproductorAudio : MonoBehaviour
{
    public AudioSource repAudio;
    public  List  <AudioClip> album_01 = new List<AudioClip>();
    public Transform trackContaner;
    public GameObject trackObj;
    public int currentTrack;
   

    
    void Start()
    {
        for (int i = 0; i <album_01.Count  ; i++)
        {
            Instantiate(trackObj, trackContaner);
            trackObj.GetComponent<Track>().clip = album_01[i];
           trackObj.GetComponent<Track>().idTrack = i;

        }
    }

    
   

   
}
