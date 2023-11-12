using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;
using System;

public class AdMobManager : MonoBehaviour
{
    public bool is_Test;

    // Start is called before the first frame update
    void Awake()
    {
        LoadFrontAd();
    }

    private void Start()
    {
        frontAd.OnAdClosed += HandleOnAdClosed;
    }


    const string frontTestID = "ca-app-pub-3940256099942544/8691691433";
    const string frontID = "ca-app-pub-7537224848353526/5181629207";
   
   
   
    InterstitialAd frontAd;

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainPage");
    }

    AdRequest GetAdRequest()
    {
        return new AdRequest.Builder().Build();
    }


    void LoadFrontAd()
    {
        frontAd = new InterstitialAd(is_Test ? frontTestID : frontID);
        frontAd.LoadAd(GetAdRequest());
        frontAd.OnAdClosed += (sender, e) =>
        {
        };
    }

    public void ShowFrontAd()
    {
        frontAd.Show();

        //LoadFrontAd();
    }

}
