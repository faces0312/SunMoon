using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public Music_Manager3 music;
    public GameObject clear_Page;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sun" || collision.gameObject.tag == "Moon")
        {
            music.stage3.Stop();
            music.clear.Play();
            Data.Instance.gameData.stage3_checkpoint = 5;
            Data.Instance.gameData.stage3_bestcheck = 5;
            Data.Instance.SaveGameData();
            clear_Page.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
