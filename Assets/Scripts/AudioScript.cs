using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour {

    public AudioClip sfxPop;
    AudioSource audioSource;
    static public bool IsPlay = false;
    
    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {

        if (IsPlay == true)
        {
            audioSource.PlayOneShot(sfxPop);
            IsPlay = false;
        }
	}
}
