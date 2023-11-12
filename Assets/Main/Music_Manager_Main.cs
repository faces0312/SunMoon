using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_Manager_Main : MonoBehaviour
{
    public AudioSource stage1;
    public AudioSource stage2;
    public AudioSource stage3;
    public AudioSource stage4;


    public AudioSource button;
    public AudioSource window;

    // Start is called before the first frame update
    void Start()
    {
        if (Data.Instance.gameData.music_off == true)
            gameObject.SetActive(false);
        else
        {
            stage1.Play();
            stage2.Stop();
            stage3.Stop();
            stage4.Stop();
        }
    }
}
