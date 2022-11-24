using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battle2 : MonoBehaviour
{
    public GameObject weapon;
    public bool attack;
    public float t = 1;
    public bool idol;

    // Start is called before the first frame update
    void Start()
    {
        // weapon.GetComponent<MeshCollider>().convex = true;
        // weapon.GetComponent<MeshCollider>().isTrigger = true;
        //  weapon.GetComponent<MeshCollider>().convex = false;
        // weapon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        t = t - Time.deltaTime;
        if (wepon.w == 2)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                GetComponent<Animation>().Play("a2");
                t = 0.3f;
                move.manager.getscore(0.3f);
                attack = true;
            }
            else if (t <= 0)
            {
                attack = false;
            }
        }
        if (!attack)

        {
            weapon.GetComponent<MeshCollider>().enabled = false;
            //   weapon.SetActive(false);
            if (Input.GetKey(KeyCode.W))
            {
                attack = false;
                t = 2;
                GetComponent<Animation>().Play("run");
            }
            else if (Input.GetKeyUp(KeyCode.W))
            {
                GetComponent<Animation>().Play("stop");
            }
            if (t <= 0)
            {
                GetComponent<Animation>().Play("idol");
            }
            if (Input.GetKey(KeyCode.A))
            {
                t = 2;
                GetComponent<Animation>().Play("run");
            }
            else if (Input.GetKeyUp(KeyCode.A))
            {
                GetComponent<Animation>().Play("stop");
            }
            if (Input.GetKey(KeyCode.D))
            {
                t = 2;
                GetComponent<Animation>().Play("run");
            }
            else if (Input.GetKeyUp(KeyCode.D))
            {
                GetComponent<Animation>().Play("stop");
            }
            if (Input.GetKey(KeyCode.S))
            {
                attack = false;
                t = 2;
                GetComponent<Animation>().Play("run");
            }
            else if (Input.GetKeyUp(KeyCode.S))
            {
                GetComponent<Animation>().Play("stop");
            }

        }
        if (attack)
        {
            weapon.GetComponent<MeshCollider>().enabled = true;
            // weapon.SetActive(true);
        }
        if (t < -3)
        {
            idol = true;
            HP.manager.getbot(1);
            t = 0;
        }
        else
        {
            idol = false;
            HP.manager.getbot(0);

        }

    }
}
