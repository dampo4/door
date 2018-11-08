using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {
    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;
    private AudioSource audioSource;
	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}

    private void Spin1()
    {
        audioSource.PlayOneShot(clip1);
    }
    private void Spin2()
    {
        audioSource.PlayOneShot(clip2);
    }
    private void OpenDoor()
    {
        audioSource.PlayOneShot(clip3);
    }
}
