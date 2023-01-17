using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public static item manager;
    public int T1;
    public int T2;
    public GameObject x1;
    public GameObject player;
    public GameObject hef;
    // Start is called before the first frame update
    void Start()
    {
        if (manager == null)
        {
            manager = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(T1 > 0)
        {
            x1.GetComponent<CanvasGroup>().alpha = 1;
        }
        if(T1 <= 0)
        {
            x1.GetComponent<CanvasGroup>().alpha = 0;
        }
        if (Input.GetKeyDown(KeyCode.F1))
        {
            if (T1 > 0)
            {
                T1 = T1 - 1;
                HP.manager.getitem(1);
                move.manager.getscore(1.1f);
                player.GetComponent<Animation>().Play("heal");
                hef.gameObject.GetComponent<ParticleSystem>().Play();
            }
        }
    }
    public void getT1(int value)
    {
        T1 += value;
      //  counter.manager.getctrl(1);
    }
}
