using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioPlay : MonoBehaviour
{
    public int audioEnrty=0;
   
    public AudioManager audiomanager;
    private AudioClip audioClip;
    private AudioSource source;
    // Start is called before the first frame update
    private void Start()
    {
        source = gameObject.AddComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        audioClip =audiomanager.sounds[audioEnrty].clip;
        source.PlayOneShot(audioClip, 1.0f);
        Debug.Log("hello!");
        audiomanager.Test();
    }
    // Update is called once per frame
    
}
