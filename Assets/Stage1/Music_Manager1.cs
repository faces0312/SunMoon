using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_Manager1 : MonoBehaviour
{
    public AudioSource stage1;

    public AudioSource button;
    public AudioSource window;

    public AudioSource clear;
    public AudioSource flower;

    // Start is called before the first frame update
    void Start()
    {
        if(Data.Instance.gameData.music_off == true)
            gameObject.SetActive(false);
        else
        {
            stage1.Play();
        }
    }
}
