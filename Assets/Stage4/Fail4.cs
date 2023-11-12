using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Fail4 : MonoBehaviour
{
    public Music_Manager4 music;

    public int check_point;
    public GameObject[] chek;

    public Time_Manager4 time;
    public TextMeshProUGUI timer;


    private void OnEnable()
    {
        Time.timeScale = 0;

        music.stage4.Stop();
        music.window.Play();

        for (int i = 0; i < 5; i++)
        {
            chek[i].gameObject.SetActive(false);
        }
        chek[check_point].gameObject.SetActive(true);

        timer.text = string.Format("{0:D2} : {1:D2}", time.min, (int)time.sec);
    }

    public void Home()
    {
        Data.Instance.gameData.stage_return = 4;
        Time.timeScale = 1;
        Data.Instance.SaveGameData();
        SceneManager.LoadScene("MainPage");
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Stage4");
    }
}
