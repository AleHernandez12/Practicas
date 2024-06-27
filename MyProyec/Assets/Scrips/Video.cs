using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Video : MonoBehaviour
{
    public VideoPlayer _VideoPlayer;
    public VideoClip ClipVideo;



    void Start()
    {
        _VideoPlayer.clip = ClipVideo;
    }

    
    void Update()
    {
        
    }
}
