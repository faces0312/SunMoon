using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_Sun_Tuto : MonoBehaviour
{
    public GameObject[] arrow_1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sun")
        {
            for(int i=0; i<2; i++)
            {
                arrow_1[i].gameObject.SetActive(true);
            }
        }
    }
}
