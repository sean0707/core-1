using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript2 : MonoBehaviour
{
    public float t = 1;
    public Transform target;
    public Vector3 offset1;
    public Vector3 offset2;
 //   public Vector3 offset3;
    public bool e;
  //  public static bool s;
    public float x;
    public float y;
    public float d;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
       // offset = target.position - this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (e)
        {
          //  this.transform.position = target.position - offset ;
         //   transform.rotation = Quaternion.Euler(25, 0, 0);
            transform.position = (target.position) + Quaternion.Euler(x, y, 0) * (Vector3.back * d) + offset1;
            transform.LookAt(target.position + offset1);
        }
        else
        {
            t = t - Time.deltaTime;
            transform.position = (target.position) + Quaternion.Euler(-5, y, 0) * (Vector3.forward * 50) + offset2;
            transform.LookAt(target.position + offset2);
        }
     /*   if (s)
        {
            transform.position = (target.position) + Quaternion.Euler(-x, y, 0) * (Vector3.forward * 50) + offset3;
            transform.LookAt(target.position + offset3);
        }*/

        if (Input.GetKeyDown(KeyCode.G))
        {
            e = !e;
        }
    /*    if (Input.GetKeyDown(KeyCode.S))
        {
            s = true;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            s = false;
        }*/
        if (t <= 0)
        {
            e = !e;
            t = 1;
        }
    }
}
