using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate5 : MonoBehaviour
{
    public GameObject camera;

    public float zRotation;

    private void Start()
    {
        zRotation = 0f;
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
        while (zRotation <= 60)
        {
            camera.gameObject.transform.eulerAngles = new Vector3(0, 0, zRotation);
            zRotation += 0.02f;
            yield return new WaitForSeconds(0.009f);
        }
        camera.gameObject.transform.eulerAngles = new Vector3(0, 0, 60f);
        StartCoroutine(nameof(Rotate2));
    }

    IEnumerator Rotate2()
    {
        /*for (int i = 0; i < 100; i++)
        {
            camera.transform.Rotate(new Vector3(0, 0, - 20 * Time.deltaTime));
            yield return new WaitForSeconds(0.001f);
        }*/
        while (zRotation <= 120)
        {
            camera.gameObject.transform.eulerAngles = new Vector3(0, 0, zRotation);
            zRotation += 0.04f;
            yield return new WaitForSeconds(0.009f);
        }
        camera.gameObject.transform.eulerAngles = new Vector3(0, 0, 120f);
        StartCoroutine(nameof(Rotate3));
    }
    IEnumerator Rotate3()
    {
        /*for (int i = 0; i < 100; i++)
        {
            camera.transform.Rotate(new Vector3(0, 0, - 20 * Time.deltaTime));
            yield return new WaitForSeconds(0.001f);
        }*/
        while (zRotation <= 180)
        {
            camera.gameObject.transform.eulerAngles = new Vector3(0, 0, zRotation);
            zRotation += 0.06f;
            yield return new WaitForSeconds(0.009f);
        }
        camera.gameObject.transform.eulerAngles = new Vector3(0, 0, 180f);
        StartCoroutine(nameof(Rotate4));
    }

    IEnumerator Rotate4()
    {
        /*for (int i = 0; i < 100; i++)
        {
            camera.transform.Rotate(new Vector3(0, 0, - 20 * Time.deltaTime));
            yield return new WaitForSeconds(0.001f);
        }*/
        while (zRotation <= 240)
        {
            camera.gameObject.transform.eulerAngles = new Vector3(0, 0, zRotation);
            zRotation += 0.08f;
            yield return new WaitForSeconds(0.009f);
        }
        camera.gameObject.transform.eulerAngles = new Vector3(0, 0, 240f);
        StartCoroutine(nameof(Rotate4_2));
    }

    IEnumerator Rotate4_2()
    {
        /*for (int i = 0; i < 100; i++)
        {
            camera.transform.Rotate(new Vector3(0, 0, - 20 * Time.deltaTime));
            yield return new WaitForSeconds(0.001f);
        }*/
        while (zRotation <= 300)
        {
            camera.gameObject.transform.eulerAngles = new Vector3(0, 0, zRotation);
            zRotation += 0.1f;
            yield return new WaitForSeconds(0.009f);
        }
        camera.gameObject.transform.eulerAngles = new Vector3(0, 0, 300f);
        StartCoroutine(nameof(Rotate4_3));
    }

    IEnumerator Rotate4_3()
    {
        /*for (int i = 0; i < 100; i++)
        {
            camera.transform.Rotate(new Vector3(0, 0, - 20 * Time.deltaTime));
            yield return new WaitForSeconds(0.001f);
        }*/
        while (zRotation <= 360)
        {
            camera.gameObject.transform.eulerAngles = new Vector3(0, 0, zRotation);
            zRotation += 0.1f;
            yield return new WaitForSeconds(0.009f);
        }
        camera.gameObject.transform.eulerAngles = new Vector3(0, 0, 360f);
    }
}
