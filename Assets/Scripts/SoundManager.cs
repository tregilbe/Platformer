using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip jump;
    // public AudioClip risingTide;
    // public AudioClip hmmm;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.clip = jump;
            audioSource.Play();
        }
    }

    // Use for reference
     // if (Input.GetKeyDown(KeyCode.A))
        //{
            // audioSource.clip = risingTide;
            // audioSource.Play();
        //}
        // if (Input.GetKeyDown(KeyCode.S))
        //{
            // audioSource.clip = hmmm;
            // audioSource.Play();
        //}
        // if (Input.GetKeyDown(KeyCode.D))
        //{
          //  audioSource.Stop();
        //}
        // if (Input.GetKeyDown(KeyCode.Space))
        //{
             //if (audioSource.isPlaying)
          //  {
               // audioSource.Pause();
            //}
           // else
            //{
               // audioSource.Play();
            //}
        //}
}
