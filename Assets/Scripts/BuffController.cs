using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffController : MonoBehaviour
{
   
    public GameObject player;
    private void Start()
    {
        
       
    }
    
    
    private void OnTriggerEnter2D(Collider2D coll)
    {
        
        
        
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        Destroy(this.gameObject);
    }
}


