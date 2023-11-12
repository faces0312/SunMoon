using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_Manager_Tuto : MonoBehaviour
{
    public float music_time;

    public float sec;
    public int min;


    public Camera camera;

    void Awake()
    {
        //Application.targetFrameRate = 250;
    }

    private void Start()
    {
        camera.orthographicSize = 6f;
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
