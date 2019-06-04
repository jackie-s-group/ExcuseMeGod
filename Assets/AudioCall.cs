using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioCall : MonoBehaviour
{
    public AudioManager audioManager;
    // Start is called before the first frame update
    void Start()
    {
        GameObject camera = GameObject.Find("Main Camera");
        audioManager = camera.GetComponent<AudioManager>();
        Debug.Log("hello world!!");
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
