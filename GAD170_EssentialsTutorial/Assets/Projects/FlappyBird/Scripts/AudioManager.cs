using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public List<AudioClip> deathSounds = new List<AudioClip>();
    public List<AudioClip> collectCoinSounds = new List<AudioClip>();

    private AudioSource m_AudioSource; // reference to our Audio Source.

    // Start is called before the first frame update
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CollectCoin()
    {
        SelectRandomSoundFromListAndPlayOneShot(collectCoinSounds);
    }

    public void Dead()
    {
        SelectRandomSoundFromListAndPlayOneShot(deathSounds);
    }

    /// <summary>
    /// Takes in a list of audio clips, and selects a random one and plays it.
    /// </summary>
    /// <param name="audioClips"></param>
    private void SelectRandomSoundFromListAndPlayOneShot(List<AudioClip> audioClips)
    {
        AudioClip clipToPlay = audioClips[Random.Range(0, audioClips.Count)];
        m_AudioSource.PlayOneShot(clipToPlay);
    }
}
