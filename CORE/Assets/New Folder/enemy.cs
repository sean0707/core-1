using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject e1;
    public GameObject e2;
    private pool<enemy> ep;
    public GameObject s;
    // Start is called before the first frame update
    void Start()
    {
        ep = pool<enemy>.Instance;
        ep.initpool(e1);
        ep.initpool(e2);
    }

    // Update is called once per frame
    void Update()
    {
        enemy e1 = ep.Spawn(this.transform.position, this.transform.rotation, s.transform.parent);
    }
}
