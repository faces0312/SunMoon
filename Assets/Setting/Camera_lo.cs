using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_lo : MonoBehaviour
{
    public GameObject target1;//해의 위치
    public GameObject target2;//달의 위치
    private void Awake()
    {
        Camera camera = GetComponent<Camera>();
        Rect rect = camera.rect;
        float scaleHeight = ((float)Screen.width / Screen.height) / ((float)16 / 9);
        float scaleWidth = 1f / scaleHeight;

        if (scaleHeight < 1)
        {
            rect.height = scaleHeight;
            rect.y = (1f - scaleHeight) / 2f;
        }
        else
        {
            rect.width = scaleWidth;
            rect.x = (1f - scaleWidth) / 2f;
        }
        camera.rect = rect;
    }
    private void Start()
    {
        Time.timeScale = 1;
    }
    private void Update()
    {
        Vector3 targetPos = new Vector3((target1.transform.position.x + target2.transform.position.x) / 2 + 6,
            (target1.transform.position.y + target2.transform.position.y) / 2, -10);
        transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * 5);
    }
}
