using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate4 : MonoBehaviour
{
    public GameObject camera;

    public float zRotation;

    private void Start()
    {
        zRotation = 90f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sun" || collision.gameObject.tag == "Moon")
        {
            StartCoroutine(nameof(Rotate));
        }
    }

    IEnumerator Rotate()
    {
        /*for (int i = 0; i < 100; i++)
        {
            camera.transform.Rotate(new Vector3(0, 0, - 20 * Time.deltaTime));
            yield return new WaitForSeconds(0.001f);
        }*/
        while (zRotation >= 0)
        {
            camera.gameObject.transform.eulerAngles = new Vector3(0, 0, zRotation);
            zRotation -= 0.03f;
            yield return new WaitForSeconds(0.009f);
        }
        camera.gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
    }
}
