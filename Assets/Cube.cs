using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public AudioSource applause_sound;
    public AudioSource Boo_sound;
    // Start is called before the first frame update
    void Start()
    {
        GenerateColor();
    }

    public void GenerateColor()
    {
        GetComponent<Renderer>().sharedMaterial.color = Random.ColorHSV();
    }

    public void Reset()
    {
        GetComponent<Renderer>().sharedMaterial.color = Color.white;
    }

    public void Applause()
    {
        applause_sound.Play();
    }

    public void Boo()
    {
        Boo_sound.Play();
    }

    public void stopAudio()
    {
        if (applause_sound.isPlaying || Boo_sound.isPlaying)
        {
            applause_sound.Stop();
            Boo_sound.Stop();
        }
    }

}