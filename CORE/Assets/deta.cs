using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deta : MonoBehaviour
{
    public bool x;
    void Start()
    {
        x = false;
        // gameObject.GetComponent<CanvasGroup>().alpha = 0;
        gameObject.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            x = !x;
            gameObject.GetComponent<CanvasGroup>().blocksRaycasts = !gameObject.GetComponent<CanvasGroup>().blocksRaycasts;
        }
        if (!x)
        {
            gameObject.GetComponent<CanvasGroup>().alpha = 0;
            Time.timeScale = 1;
        }
        else
        {
            gameObject.GetComponent<CanvasGroup>().alpha = 1;
            Time.timeScale = 0;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            x = false;
        }
    }
}
