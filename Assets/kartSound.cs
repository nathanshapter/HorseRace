using UnityEngine.Audio;
using UnityEngine;

public class kartSound : MonoBehaviour
{
    AudioSource clip;
    void Start()
    {
        clip = GetComponent<AudioSource>();
        Invoke("playAudio", 11.38f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void playAudio()
    {
        clip.Play();
    }
}
