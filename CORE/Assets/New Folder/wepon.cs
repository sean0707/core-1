using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wepon : MonoBehaviour
{
    public static wepon manager;
    public static float w = 1;
    public GameObject w1;
    public GameObject w2;
    public GameObject w3;
    public GameObject w4;
    public GameObject b;
    public bool a;
    F mode = F.w1;
    //S  public bool x;
    public enum F
    {
        w1=1,
        w2=2,
        w3=3,
        w4=4
    }
    void Start()
    {
        if (manager == null)
        {
            manager = this;
        }
        // x = false;
        // gameObject.GetComponent<CanvasGroup>().alpha = 0;
        // gameObject.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!a)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                mode = mode + 1;
                /* x = !x;
                 gameObject.GetComponent<CanvasGroup>().blocksRaycasts = !gameObject.GetComponent<CanvasGroup>().blocksRaycasts;
             }
             if (!x)
             {
                 w1.SetActive(false);
                 w2.SetActive(true);
                 w3.SetActive(false);
                 b.GetComponent<battle1>().enabled = false;
                 b.GetComponent<battle2>().enabled = true;
                 b.GetComponent<battle3>().enabled = false;


             }
             else
             {
                 w3.SetActive(true);
                 w2.SetActive(false);
                 w1.SetActive(false);
                 b.GetComponent<battle1>().enabled = false;
                 b.GetComponent<battle3>().enabled = true;
                 b.GetComponent<battle2>().enabled = false;
             }*/
                switch (mode)
                {
                    case F.w1:
                        w2.SetActive(false);
                        w1.SetActive(true);
                        w3.SetActive(false);
                        w4.SetActive(false);
                        b.GetComponent<battle2>().enabled = false;
                        b.GetComponent<battle1>().enabled = true;
                        b.GetComponent<battle3>().enabled = false;
                        b.GetComponent<battle4>().enabled = false;
                        w = 1;
                        break;
                    case F.w2:
                        w1.SetActive(false);
                        w2.SetActive(true);
                        w3.SetActive(false);
                        w4.SetActive(false);
                        b.GetComponent<battle1>().enabled = false;
                        b.GetComponent<battle2>().enabled = true;
                        b.GetComponent<battle3>().enabled = false;
                        b.GetComponent<battle4>().enabled = false;
                        w = 2;
                        break;
                    case F.w3:
                        w3.SetActive(true);
                        w2.SetActive(false);
                        w1.SetActive(false);
                        w4.SetActive(false);
                        b.GetComponent<battle1>().enabled = false;
                        b.GetComponent<battle3>().enabled = true;
                        b.GetComponent<battle2>().enabled = false;
                        b.GetComponent<battle4>().enabled = false;
                        w = 3;
                        break;
                          case F.w4:
                             w4.SetActive(true);
                               w2.SetActive(false);
                               w1.SetActive(false);
                               w3.SetActive(false);
                               b.GetComponent<battle1>().enabled = false;
                               b.GetComponent<battle4>().enabled = true;
                               b.GetComponent<battle2>().enabled = false;
                               b.GetComponent<battle3>().enabled = false;
                        w = 4;
                        mode = 0;
                        break;

                }


            }
        }
        

    }
}

