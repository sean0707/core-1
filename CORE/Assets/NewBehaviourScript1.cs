using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public static NewBehaviourScript1 manager;
    public int a = 100;
    public int b = 100;
    public int c = 100;
    public int d;
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


    }
    public void  Red()
    {
    
        if (d > 0 & a < 23 & b > 0 & c > 0)
        {
          a = a + 2;
          b = b - 1;
          c = c - 1;
          d = d - 1;
         gameObject.transform.position += new Vector3(-3,-2);
        }
    }
    public void Blue()
    {
        if (d > 0 & a > 0 & b < 23 & c > 0)
        {
         a = a - 1;
         b = b + 2;
         c = c - 1;
         d = d - 1;
            gameObject.transform.position += new Vector3( 0, 3.5f);
        }   
    }
    public void Yellow()
    {
        if (d > 0 & a > 0 & b > 0 & c < 23)
        {
         a = a - 1;
         b = b - 1;
         c = c + 2;
         d = d - 1;
            gameObject.transform.position += new Vector3(3, -2);
        }
    }
    public void getd(int value)
    {
        d += value;
    }
}
