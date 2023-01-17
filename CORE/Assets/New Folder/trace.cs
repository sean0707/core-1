using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trace : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<ParticleSystem>().Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            gameObject.GetComponent<ParticleSystem>().Play();
        }
    }
}
