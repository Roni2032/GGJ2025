using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioSource audioSource;

    [SerializeField]
    List<AudioClip> clips = new List<AudioClip>();

    public enum SE
    {
        BOBBLE_BURST,
        BUBBLE,
        WIND
    }
    
    static SoundManager instance;
    void Awake()
    {
        instance = this;
        audioSource = GetComponent<AudioSource>();
    }
    public static bool CheckInstance()
    {
        return true;
    }
    public static SoundManager GetInstance()
    {
        CheckInstance();
        return instance;
    }

    public void PlaySE(SE se)
    {
        audioSource.PlayOneShot(clips[(int)se]);
    }
    public void StopSE()
    {
        audioSource.Stop();
    }

   
}
