using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public GameObject up;
    public GameObject player;
    public static HP manager;
    public const int maxHealth = 100;
    public int currentHealth = maxHealth;
    public RectTransform a,b;
    public int LV;
    public int bot;

    void Start()
    {
        if (manager == null)
        {
            manager = this;
        }
        currentHealth = auto.manager.hp;
    }
    void OnTriggerEnter(Collider other)
    {
       int s = NewBehaviourScript1.manager.a + equipment.manager.amor.def;
        if (other.name == "area")
        {
        currentHealth = currentHealth - (25 - s );
        }
        if (other.name == "area 2")
        {
            currentHealth = currentHealth - (35 - s);
        }
    }
    // Update is called once per frame
    void Update()
    {
        a.sizeDelta = new Vector2(currentHealth, a.sizeDelta.y);
        if(b.sizeDelta.x > a.sizeDelta.x)
       {
            b.sizeDelta += new Vector2(-1,0)*Time.deltaTime * 10;
       }
        a.sizeDelta = new Vector2(currentHealth, a.sizeDelta.y);
        if (b.sizeDelta.x < a.sizeDelta.x)
        {
            b.sizeDelta += new Vector2(1, 0) * Time.deltaTime * 10;
        }
        if(currentHealth > 100)
        {
            currentHealth = 100;
        }
        if(bot >0)
        {
            if(currentHealth < 100)
            {
             //   currentHealth = currentHealth + 10;
            }
        }

    }
    public void getLV(int value)
    {
        LV += value;
        currentHealth = 100;
        Instantiate(up, player.transform.position, up.transform.rotation);
    }
    public void getbot(int value)
    {
        bot = value;
    }
    public void getitem(int value)
    {
        currentHealth = currentHealth + 30;
    }
}
