using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Clear : MonoBehaviour
{
    public Time_Manager time;
    public TextMeshProUGUI timer;

    public GameObject clear_light;
    public GameObject clear_flower1;
    public GameObject clear_flower2;
    public GameObject clear_flower3;
    public GameObject clear_flower4;
    public GameObject clear_flower5;
    public GameObject clear_flower6;

    public GameObject clear_button;
    public GameObject home;
    private void OnEnable()
    {
        StartCoroutine(nameof(Light_Rotation));
        StartCoroutine(nameof(Down_Flower));

        timer.text = string.Format("{0:D2} : {1:D2}", time.min, (int)time.sec);
    }

    IEnumerator Light_Rotation()
    {
        for (int i = 0; i < 50; i++)
        {
            clear_light.transform.Rotate(new Vector3(0, 0, 0.3f));
            yield return new WaitForSecondsRealtime(0.01f);
        }

        StartCoroutine(nameof(Light_Rotation));
    }

    IEnumerator Down_Flower()
    {
        for (int i = 0; i < 500; i++)
        {
            clear_flower1.transform.Translate(0, -16 , 0);
            clear_flower2.transform.Translate(0, 16, 0);
            clear_flower3.transform.Translate(0, -16, 0);
            clear_flower4.transform.Translate(0, 16, 0);
            clear_flower5.transform.Translate(0, -16, 0);
            clear_flower6.transform.Translate(0, 16, 0);
            yield return new WaitForSecondsRealtime(0.01f);
        }

    }

    public void Clear_Button()
    {
        clear_button.gameObject.SetActive(false);
        home.gameObject.SetActive(true);
    }

    public void Home()
    {
        Data.Instance.gameData.stage_return = 3;
        Time.timeScale = 1;
        Data.Instance.SaveGameData();
        SceneManager.LoadScene("MainPage");
    }
}
