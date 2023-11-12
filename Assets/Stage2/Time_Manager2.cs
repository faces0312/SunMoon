using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_Manager2 : MonoBehaviour
{
    public float music_time;

    public float sec;
    public int min;


    public Camera camera;

    void Awake()
    {
        //Application.targetFrameRate = 60;
    }
    private void Start()
    {
        camera.orthographicSize = 5f;
        StartCoroutine(nameof(Camera_6));
        StartCoroutine(nameof(Camera_5));
        StartCoroutine(nameof(Camera_6_2));

    }

    IEnumerator Camera_6()
    {
        yield return new WaitForSeconds(35f);

        for (int i = 0; i < 100; i++)
        {
            camera.orthographicSize += 0.01f;
            yield return new WaitForSeconds(0.01f);
        }
    }

    IEnumerator Camera_6_2()
    {
        yield return new WaitForSeconds(68f);

        for (int i = 0; i < 100; i++)
        {
            camera.orthographicSize += 0.01f;
            yield return new WaitForSeconds(0.01f);
        }
    }

    IEnumerator Camera_5()
    {
        yield return new WaitForSeconds(58f);

        for (int i = 0; i < 100; i++)
        {
            camera.orthographicSize -= 0.01f;
            yield return new WaitForSeconds(0.01f);
        }
    }

    private void Update()
    {
        Timer();
    }

    void Timer()
    {
        music_time += Time.deltaTime;
        sec += Time.deltaTime;

        //time.text = string.Format("{0:D2} : {1:D2}", min, (int)sec);

        if ((int)sec > 59)
        {
            sec = 0;
            min++;
        }
    }
}
