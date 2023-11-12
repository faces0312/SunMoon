using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_Moon_Tuto : MonoBehaviour
{
    public GameObject[] arrow_1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Moon")
        {
            for (int i = 0; i < 3; i++)
            {
                arrow_1[i].gameObject.SetActive(true);
            }
        }
    }
}
