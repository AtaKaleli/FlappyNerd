using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    [SerializeField] private AudioSource[] sfx;
    [SerializeField] private AudioSource bgm;




    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);
    }

    public void PlaySFX(int sfxIndex)
    {
        if (sfxIndex >= sfx.Length)
            return;

        sfx[sfxIndex].Play();
    }

    public void PlayBgm()
    {
        bgm.Play();
    }

    

}
