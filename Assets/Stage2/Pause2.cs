using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause2 : MonoBehaviour
{
    public Music_Manager2 music;
    public Time_Manager2 time;


    public GameObject pause_page;
    public GameObject puaue_Count;
    public GameObject puaue_Count3;
    public GameObject puaue_Count2;
    public GameObject puaue_Count1;
    float x_scale;
    float y_scale;


    public void Pause_Button()
    {
        music.stage2.Stop();
        music.button.Play();

        pause_page.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void Home()
    {
        Data.Instance.gameData.stage_return = 2;
        Time.timeScale = 1;
        Data.Instance.SaveGameData();
        SceneManager.LoadScene("MainPage");
    }

    public void Continue()
    {
        music.button.Play();

        pause_page.gameObject.SetActive(false);
        puaue_Count.gameObject.SetActive(true);
        puaue_Count3.gameObject.SetActive(false);
        puaue_Count2.gameObject.SetActive(false);
        puaue_Count1.gameObject.SetActive(false);
        StartCoroutine(nameof(Puaue_Count3));
    }

    IEnumerator Puaue_Count3()
    {
        x_scale = 1f;
        y_scale = 1f;

        puaue_Count3.gameObject.SetActive(true);
        for (int i = 0; i < 100; i++)
        {
            puaue_Count3.transform.localScale = new Vector3(x_scale, y_scale);
            x_scale -= 0.003f;
            y_scale -= 0.003f;
            yield return new WaitForSecondsRealtime(0.01f);
        }

        puaue_Count3.gameObject.SetActive(false);
        StartCoroutine(nameof(Puaue_Count2));
    }
    IEnumerator Puaue_Count2()
    {
        x_scale = 1f;
        y_scale = 1f;

        puaue_Count2.gameObject.SetActive(true);
        for (int i = 0; i < 100; i++)
        {
            puaue_Count2.transform.localScale = new Vector3(x_scale, y_scale);
            x_scale -= 0.003f;
            y_scale -= 0.003f;
            yield return new WaitForSecondsRealtime(0.01f);
        }

        puaue_Count2.gameObject.SetActive(false);
        StartCoroutine(nameof(Puaue_Count1));
    }
    IEnumerator Puaue_Count1()
    {
        x_scale = 1f;
        y_scale = 1f;

        puaue_Count1.gameObject.SetActive(true);
        for (int i = 0; i < 100; i++)
        {
            puaue_Count1.transform.localScale = new Vector3(x_scale, y_scale);
            x_scale -= 0.003f;
            y_scale -= 0.003f;
            yield return new WaitForSecondsRealtime(0.01f);
        }

        music.stage2.time = time.music_time;
        music.stage2.Play();
        puaue_Count1.gameObject.SetActive(false);
        puaue_Count.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Stage2");
    }
}
