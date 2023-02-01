using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{

    public GameObject b;
    private pool<bullet> bp;
    public bool attack;
    public float t = 1;
    // Start is called before the first frame update
    void Start()
    {
        bp = pool<bullet>.Instance;
        bp.initpool(b);
    }

    // Update is called once per frame
    void Update()
    {
        t = t - Time.deltaTime;
        if (wepon.w == 4)
        {
            if (Input.GetKeyDown(KeyCode.F1))
            {
                t = 1.1f;
                attack = true;
            }
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                bullet b = bp.Spawn(this.transform.position, Quaternion.identity);
                t = 1.5f;
                attack = true;
            }
            else if (t <= 0)
            {
                attack = false;
            }
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "enemy")
        {
            
        }
    }
}
