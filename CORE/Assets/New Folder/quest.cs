using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quest : MonoBehaviour
{
    public static quest ctrl;
    public bool Q;
    public GameObject myObjArray;


    private void Awake()
    {
        ctrl = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "npc")
        {
            Q = true;
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                myObjArray = other.gameObject;
                TMP.ctrl.m = myObjArray.name;
            }

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "npc")
        {
            Q = false;
            myObjArray = default;

        }
    }
}
