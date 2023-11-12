using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public bool is_change;//¹Ù²î¾ú´ÂÁö
    public GameObject left_pos;
    public GameObject right_pos;

    public GameObject sun_jump;
    public GameObject sun_flip;
    public GameObject moon_jump;
    public GameObject moon_flip;

    private void Start()
    {
        is_change = false;
        sun_jump.gameObject.SetActive(true);
        sun_flip.gameObject.SetActive(false);
        moon_jump.gameObject.SetActive(true);
        moon_flip.gameObject.SetActive(false);
    }

    public void Sun_Jump()
    {
        sun_jump.gameObject.SetActive(true);
        sun_flip.gameObject.SetActive(false);
    }

    public void Sun_Flip()
    {
        sun_jump.gameObject.SetActive(false);
        sun_flip.gameObject.SetActive(true);
    }

    public void Moon_Jump()
    {
        moon_jump.gameObject.SetActive(true);
        moon_flip.gameObject.SetActive(false);
    }

    public void Moon_Flip()
    {
        moon_jump.gameObject.SetActive(false);
        moon_flip.gameObject.SetActive(true);
    }
}
