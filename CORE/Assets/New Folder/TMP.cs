using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;
using TMPro;


public class TMP : MonoBehaviour
{
    public static TMP ctrl;
    // TextMeshPro Text;
    public TextMeshProUGUI Text;
    public string m;
    string Str;
    string Name;
    string[] strs;
    public int x;
    public int y;
    public bool clear;
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

        if(m == "b")
        {
            y = 1;
        }
        if (m == "a")
        {
            y = 2;
        }
        if( x >= y)
        {
            //   clear = true;
            Invoke("Clear",0);
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
        exp.manager.getscore(50);
        x = 0;
        Text.text = Resources.Load<TextAsset>(m).text + "(" + x + "/" + y + ")";
    }
}