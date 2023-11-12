using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint4_2 : MonoBehaviour
{
    public Fail4 fail;
    public GameObject ballon;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sun" || collision.gameObject.tag == "Moon")
        {
            fail.check_point = 2;
            StartCoroutine(nameof(Up));

            Data.Instance.gameData.stage4_checkpoint = 2;
            if (Data.Instance.gameData.stage4_bestcheck < Data.Instance.gameData.stage4_checkpoint)
            {
                Data.Instance.gameData.stage4_bestcheck = Data.Instance.gameData.stage4_checkpoint;
            }
            Data.Instance.SaveGameData();
        }
    }
    IEnumerator Up()
    {
        for (int i = 0; i < 100; i++)
        {
            ballon.transform.Translate(0, 5 * Time.deltaTime, 0);
            yield return new WaitForSeconds(0.03f);
        }
    }
}
