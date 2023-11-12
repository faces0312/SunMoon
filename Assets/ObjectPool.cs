using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject arrowPrefab;
    GameObject[] arrow;

    GameObject[] targetPool;

    private void Awake()
    {
        arrow = new GameObject[100];
        Generate();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Generate()
    {
        for (int index = 0; index < arrow.Length; index++)
        {
            arrow[index] = Instantiate(arrowPrefab);
            arrow[index].SetActive(false);
        }
    }

    public GameObject MakeObj(string type)
    {
        switch (type)
        {
            case "Arrow":
                targetPool = arrow;
                break;
        }
        for (int index = 0; index < targetPool.Length; index++)
        {
            if (!targetPool[index].activeSelf)
            {
                targetPool[index].SetActive(true);
                return targetPool[index];
            }
        }

        return null;
    }
}
