using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnSpaceBar : MonoBehaviour
{
    public AudioSource someSound;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            someSound.Play();
        }
    }
}
