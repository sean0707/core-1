using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgm2 : MonoBehaviour
{
    public GameObject w1;
    public GameObject w4;
    //  public bool B;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (wepon.w == 1)
            {
                w1.gameObject.GetComponent<AudioSource>().enabled = false;
                w1.gameObject.GetComponent<AudioSource>().enabled = true;
            }
            if (wepon.w == 4)
            {
                w4.gameObject.GetComponent<AudioSource>().enabled = false;
                w4.gameObject.GetComponent<AudioSource>().enabled = true;
            }

            //   B = !B;
        }
      /*  if (B)
        {
            gameObject.GetComponent<AudioSource>().enabled = true;

        }
        else
        {
            gameObject.GetComponent<AudioSource>().enabled = false;
        }*/
    }
}
