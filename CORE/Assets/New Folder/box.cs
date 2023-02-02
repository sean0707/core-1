using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    public float hp = 1;
    public int ex = 0;
    public int b = 0;
    public int t1 = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Damage(float damagevalue)
    {
        hp -= damagevalue;
        if (hp <= 0)
        {
            Destroy(this.gameObject);
              exp.manager.getscore(ex);
              item.manager.getT1(t1);
            if (TMP.ctrl.m == "b")
            {
                TMP.ctrl.getscore(b);
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.tag== "wepon")
        {
            Damage(1);
        }

    }
}
