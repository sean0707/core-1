    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class equipment : MonoBehaviour
{
    public static equipment manager;
    public GameObject a;
    public bag bag;
    public equip amor;
    // public equip Equip;

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
        /*   if (!equip == default)
           {
               equip = null;
           }*/

    }
    public void get(equip value)
    {
        amor = value;
      //  amor = equip;
        bag.equiplist.Add(amor);
        a.GetComponent<Image>().sprite = amor.圖示;
    }

}
