using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : Singleton<Sounds>
{
    [SerializeField] AudioSource audioSource;
    public AudioClip hit;
    private void Start()
    {
       audioSource.volume = DataGameSave.data.isSound ? 1f : 0f;
    }
    public void PlaySound(AudioClip audioClip)
    {
        if(DataGameSave.data.isSound)
        {
            audioSource.PlayOneShot(audioClip);
        }
    }
}
