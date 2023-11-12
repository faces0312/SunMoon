using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enter : MonoBehaviour
{
    public Music_Manager_Main music;

    public GameObject[] stage1_CheckPoint;
    public GameObject[] stage2_CheckPoint;
    public GameObject[] stage3_CheckPoint;
    public GameObject[] stage4_CheckPoint;

    public GameObject bg1;
    public GameObject bg2;
    public GameObject bg3;
    public GameObject bg4;

    public GameObject enter1;
    public GameObject enter2;
    public GameObject enter3;
    public GameObject enter4;

    public GameObject setting;
    public GameObject music_on;
    public GameObject music_off;

    void Awake()
    {
        //Application.targetFrameRate = 45;
    }
    private void Start()
    {
        Time.timeScale = 1;

        bg1.gameObject.SetActive(false);
        bg2.gameObject.SetActive(false);
        bg3.gameObject.SetActive(false);
        bg4.gameObject.SetActive(false);

        enter1.gameObject.SetActive(false);
        enter2.gameObject.SetActive(false);
        enter3.gameObject.SetActive(false);
        enter4.gameObject.SetActive(false);

        for (int i = 0; i < 6; i++)
        {
            stage1_CheckPoint[i].gameObject.SetActive(false);
            stage2_CheckPoint[i].gameObject.SetActive(false);
            stage3_CheckPoint[i].gameObject.SetActive(false);
            stage4_CheckPoint[i].gameObject.SetActive(false);
        }
        stage1_CheckPoint[Data.Instance.gameData.stage1_bestcheck].gameObject.SetActive(true);
        stage2_CheckPoint[Data.Instance.gameData.stage2_bestcheck].gameObject.SetActive(true);
        stage3_CheckPoint[Data.Instance.gameData.stage3_bestcheck].gameObject.SetActive(true);
        stage4_CheckPoint[Data.Instance.gameData.stage4_bestcheck].gameObject.SetActive(true);

        if (Data.Instance.gameData.stage_return == 0)
        {
            bg1.gameObject.SetActive(true);
            enter1.gameObject.SetActive(true);
        }
        else if (Data.Instance.gameData.stage_return == 2)
        {
            bg2.gameObject.SetActive(true);
            enter2.gameObject.SetActive(true);
        }
        else if (Data.Instance.gameData.stage_return == 3)
        {
            bg3.gameObject.SetActive(true);
            enter3.gameObject.SetActive(true);
        }
        else if (Data.Instance.gameData.stage_return == 4)
        {
            bg4.gameObject.SetActive(true);
            enter4.gameObject.SetActive(true);
        }
    }

    public void Settings()
    {
        music.button.Play();
        setting.gameObject.SetActive(true);
        if(Data.Instance.gameData.music_off == true)
        {
            music_off.gameObject.SetActive(true);
            music_on.gameObject.SetActive(false);
        }
        else
        {
            music_off.gameObject.SetActive(false);
            music_on.gameObject.SetActive(true);
        }
    }

    public void Music_On()
    {
        Data.Instance.gameData.music_off = false;
        music.gameObject.SetActive(true);

        music_off.gameObject.SetActive(false);
        music_on.gameObject.SetActive(true);

        if(bg1.gameObject.activeSelf == true)
        {
            music.stage1.Play();
        }
        else if (bg2.gameObject.activeSelf == true)
        {
            music.stage2.Play();
        }
        else if (bg3.gameObject.activeSelf == true)
        {
            music.stage3.Play();
        }
        else 
        {
            music.stage4.Play();
        }
    }
    public void Music_Off()
    {
        Data.Instance.gameData.music_off = true;
        music.gameObject.SetActive(false);
        
        music_off.gameObject.SetActive(true);
        music_on.gameObject.SetActive(false);
    }
    public void Go_Cafe()
    {
        Application.OpenURL("https://cafe.naver.com/fallofsunandmoon");
    }
    public void Personal_Information()
    {
        Application.OpenURL("https://cafe.naver.com/fallofsunandmoon/2");
    }
    public void Use_Information()
    {
        Application.OpenURL("https://cafe.naver.com/fallofsunandmoon/3");
    }
    public void Setting_Off()
    {
        music.button.Play();
        setting.gameObject.SetActive(false);
    }

    public void Left()
    {
        music.button.Play();
        if(bg1.gameObject.activeSelf == true)
        {
            bg1.gameObject.SetActive(false);
            enter1.gameObject.SetActive(false);

            bg4.gameObject.SetActive(true);
            enter4.gameObject.SetActive(true);

            music.stage1.Stop();
            music.stage4.time = 0f;
            music.stage4.Play();
        }
        else if(bg2.gameObject.activeSelf == true)
        {
            bg2.gameObject.SetActive(false);
            enter2.gameObject.SetActive(false);

            bg1.gameObject.SetActive(true);
            enter1.gameObject.SetActive(true);

            music.stage2.Stop();
            music.stage1.time = 0f;
            music.stage1.Play();
        }
        else if (bg3.gameObject.activeSelf == true)
        {
            bg3.gameObject.SetActive(false);
            enter3.gameObject.SetActive(false);

            bg2.gameObject.SetActive(true);
            enter2.gameObject.SetActive(true);

            music.stage3.Stop();
            music.stage2.time = 0f;
            music.stage2.Play();
        }
        else
        {
            bg4.gameObject.SetActive(false);
            enter4.gameObject.SetActive(false);

            bg3.gameObject.SetActive(true);
            enter3.gameObject.SetActive(true);

            music.stage4.Stop();
            music.stage3.time = 0f;
            music.stage3.Play();
        }
    }

    public void Right()
    {
        music.button.Play();
        if (bg1.gameObject.activeSelf == true)
        {
            bg1.gameObject.SetActive(false);
            enter1.gameObject.SetActive(false);

            bg2.gameObject.SetActive(true);
            enter2.gameObject.SetActive(true);

            music.stage1.Stop();
            music.stage2.time = 0f;
            music.stage2.Play();
        }
        else if (bg2.gameObject.activeSelf == true)
        {
            bg2.gameObject.SetActive(false);
            enter2.gameObject.SetActive(false);

            bg3.gameObject.SetActive(true);
            enter3.gameObject.SetActive(true);

            music.stage2.Stop();
            music.stage3.time = 0f;
            music.stage3.Play();
        }
        else if (bg3.gameObject.activeSelf == true)
        {
            bg3.gameObject.SetActive(false);
            enter3.gameObject.SetActive(false);

            bg4.gameObject.SetActive(true);
            enter4.gameObject.SetActive(true);

            music.stage3.Stop();
            music.stage4.time = 0f;
            music.stage4.Play();
        }
        else
        {
            bg4.gameObject.SetActive(false);
            enter4.gameObject.SetActive(false);

            bg1.gameObject.SetActive(true);
            enter1.gameObject.SetActive(true);

            music.stage4.Stop();
            music.stage1.time = 0f;
            music.stage1.Play();
        }
    }

    public void Enter_Stage1()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void Enter_Stage2()
    {
        SceneManager.LoadScene("Stage2");
    }
    public void Enter_Stage3()
    {
        SceneManager.LoadScene("Stage3");
    }
    public void Enter_Stage4()
    {
        SceneManager.LoadScene("Stage4");
    }
}
