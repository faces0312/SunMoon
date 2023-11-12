using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{
    public Button button;


    private void Start()
    {
        StartCoroutine(nameof(Down));
    }
    IEnumerator Down()
    {
        for(int i=0; i<50; i++)
        {
            transform.Translate(0, -1 * Time.deltaTime, 0);
            yield return new WaitForSeconds(0.01f);
        }

        StartCoroutine(nameof(Up));
    }

    IEnumerator Up()
    {
        for (int i = 0; i < 50; i++)
        {
            transform.Translate(0, 1 * Time.deltaTime, 0);
            yield return new WaitForSeconds(0.01f);
        }

        StartCoroutine(nameof(Down));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Sun" || collision.gameObject.tag == "Moon")
        {
            if (button.is_change == false)
            {
                button.sun_jump.gameObject.transform.position = button.right_pos.gameObject.transform.position;
                button.sun_flip.gameObject.transform.position = button.right_pos.gameObject.transform.position;

                button.moon_jump.gameObject.transform.position = button.left_pos.gameObject.transform.position;
                button.moon_flip.gameObject.transform.position = button.left_pos.gameObject.transform.position;
            }
            else
            {
                button.sun_jump.gameObject.transform.position = button.left_pos.gameObject.transform.position;
                button.sun_flip.gameObject.transform.position = button.left_pos.gameObject.transform.position;

                button.moon_jump.gameObject.transform.position = button.right_pos.gameObject.transform.position;
                button.moon_flip.gameObject.transform.position = button.right_pos.gameObject.transform.position;
            }

            if (button.is_change == false)
                button.is_change = true;
            else
                button.is_change = false;

            gameObject.SetActive(false);
        }
    }


}
