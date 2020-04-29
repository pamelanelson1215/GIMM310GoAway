using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems;

public class StreamVideo : MonoBehaviour
{
    //public RawImage rawImage;
    public VideoPlayer videoPlayer;

    Slider tracking;
    bool slide = false;

    void Start()
    {
        tracking = GetComponent<Slider>();
    }

    public void onPointerDown(PointerEventData a)
    {
        slide = true;
    }

    public void onPointerUp(PointerEventData a)
    {
        float frame = (float)tracking.value * (float)videoPlayer.frameCount;
        videoPlayer.frame = (long)frame;
        slide = false;
    }

     void Update()
    {
        if (!slide && videoPlayer.isPlaying)
        {
            tracking.value = (float)videoPlayer.frame / (float)videoPlayer.frameCount;
        }
    }
}