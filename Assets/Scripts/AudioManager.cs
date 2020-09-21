using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public Music[] sounds;
    //public AudioClip intro;
    //public AudioClip background;
    // Start is called before the fi    rst frame update



    void Awake()
    {
        foreach (Music m in sounds)
        {
            m.source = gameObject.AddComponent<AudioSource>();
            m.source.clip = m.clip;
            m.source.volume = m.volume;
            m.source.pitch = m.pitch;
            m.source.loop = m.loop;
        }

    }

    // Update is called once per frame
    void Start()
    {
        Play("intro");
        Invoke("delay", 8f);
    }
    public void Play(string name)
    {
        Music m = Array.Find(sounds, sound => sound.name == name);
        //if (s == null)
        //return;
        m.source.Play();
    }

    public void delay()
    {
        Play("background");
    }



    void Update()
    {

    }
}
