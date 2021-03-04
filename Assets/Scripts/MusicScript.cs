using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MusicScript : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;
    private float musicVolume = 1f;
    void Start()
    {
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        audioSource.volume = musicVolume;
    }

    public void updateVolume(float volume)
    {
        musicVolume = volume;
    }
}
