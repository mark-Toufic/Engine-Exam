using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioClip BackgroundMusic;
    void Start()
    { 
        SoundManager.Instance.PlayMusic(BackgroundMusic);
    }
}
 