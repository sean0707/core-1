﻿using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;
using TMPro;


public class TMP : MonoBehaviour
{
    public static TMP ctrl;
    // TextMeshPro Text;
    public TextMeshProUGUI Text;
    public bag bag;
    public coin coin;
    public string m;
    string Str;
    string Name;
    string[] strs;
    public int x;
    public int y;
    public bool clear;
    public GameObject effect;
    private void Awake()
    {
        ctrl = this;
    }
    void Start()

    {
        Text = gameObject.GetComponent<TextMeshProUGUI>();
        Name = "C";
    }


    void Update()
    {

        if (m == "b")
        {
            y = 1;
        }
        if (m == "a")
        {
            y = 2;
        }
        if (x >= y)
        {
            //   clear = true;
            Invoke("Clear", 0);
        }
        else
        {
            //  clear = false;
        }
        if (quest.ctrl.Q)
        {
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                Text.text = Resources.Load<TextAsset>(m).text + "(" + x + "/" + y + ")";
            }

        }
    }
    void ReadFile(string Name)
    {
        strs = File.ReadAllLines(Name);
        for (int i = 0; i < strs.Length; i++)
        {
            Str += strs[i];
            Str += "\n";
        }
    }
    public void getscore(int value)
    {
        x += value;
        Text.text = Resources.Load<TextAsset>(m).text + "(" + x + "/" + y + ")";
    }
    void Clear()
    {
        if (m == "a")
        {
            exp.manager.getscore(50);
        }
        if (m == "b")
        {
            getcoin(100);
        }
        effect.gameObject.GetComponent<ParticleSystem>().Play();
        x = 0;
        Text.text = Resources.Load<TextAsset>(m).text + "(" + x + "/" + y + ")";
    }
    public void getcoin(int value)
    {
        if (!bag.itemlist.Contains(coin))
        {
            bag.itemlist.Add(coin);

        }
            coin.數量 += value;
    }
}