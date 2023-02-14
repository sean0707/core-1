using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trace : MonoBehaviour
{
    public bool s;
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
        s = true;
    }
}
