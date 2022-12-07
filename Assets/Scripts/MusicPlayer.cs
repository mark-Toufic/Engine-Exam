using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public static MusicPlayer instance;

    public AudioSource BackgroundMusic;
    public AudioClip musicOne;
    public AudioClip musicTwo;

    private float musicVolume = 1f;
  
    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        BackgroundMusic.Play();
    }
    void Update()
    {
        BackgroundMusic.volume = musicVolume;
    }
    public void updateVolume(float volume)
    { 
        musicVolume = volume;
    }

    public void chooseSongOne()
	{
        BackgroundMusic.clip = musicOne;
        BackgroundMusic.Play();
	}
    public void chooseSongTwo()
	{
        BackgroundMusic.clip = musicTwo;
        BackgroundMusic.Play();
    }
}

