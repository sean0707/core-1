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
    public TextMeshProUGUI pt;
    public TextMeshProUGUI money;
    public bag bag;
    public coin coin;
    public string m;
    string Str;
    string Name;
    string[] strs;
    public int x;
    public int y;
    public int p;
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
        money.text = "$"+coin.數量;
        pt.text = "" + p;

        if (m == "b")
        {
            y = 1;
        }
        if (m == "a")
        {
            y = 2;
        }
        if (m == "c")
        {
            y = 1;
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
            exp.manager.getscore(100);
            p++;
        }
        if (m == "b")
        {
            p++;
            getcoin(100);
        }
        if (m == "c")
        {
            p++;
            exp.manager.getscore(50);
            getcoin(150);
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