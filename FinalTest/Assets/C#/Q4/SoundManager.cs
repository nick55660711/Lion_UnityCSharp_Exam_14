using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public Runner runner;
    public AudioClip sound;


    public void endsound()
    {
        GetComponent<AudioSource>().PlayOneShot(sound);

    }


    void Start()
    {
        runner.OnGoal += endsound;
    }


}
