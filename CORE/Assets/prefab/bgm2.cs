using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgm2 : MonoBehaviour
{
  //  public bool B;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && (wepon.w == 1))
        {
            gameObject.GetComponent<AudioSource>().enabled = false;
            gameObject.GetComponent<AudioSource>().enabled = true;
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
