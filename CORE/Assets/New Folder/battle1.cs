using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battle1 : MonoBehaviour
{
  //  public GameObject bgm;
    public GameObject weapon;
    public bool attack;
    public float t = 1;
    public bool idol;
    public GameObject effect;
   

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
        if (wepon.w == 1)
        {
            if (Input.GetKeyDown(KeyCode.F1))
            {
                t = 1.1f;
                attack = true;
            }
                if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                GetComponent<Animation>().Play("a5");
                move.manager.getscore(1.1f);
                t = 1.1f;
                attack = true;
                wepon.manager.a = true;
                //  Instantiate(bgm, transform.position, Quaternion.identity);
            }
            else if (t <= 0)
            {
                attack = false;
                wepon.manager.a = false;
            }
        }
        if (!attack)

        {
            weapon.GetComponent<MeshCollider>().enabled = false;
            effect.GetComponent<TrailRenderer>().enabled = false;
            //   weapon.SetActive(false);
            if (Input.GetKey(KeyCode.W))
        {
            attack = false;
            t = 2;
            GetComponent<Animation>().Play("run");
        } else if (Input.GetKeyUp(KeyCode.W))
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
            effect.GetComponent<TrailRenderer>().enabled = true;
            // weapon.SetActive(true);
        }
        if(t < -4)
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
