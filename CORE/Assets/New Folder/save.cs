using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.IO;
using System.Text;


public class save : MonoBehaviour
{
    public coin c;
    public bool check;
    public GameObject myObjArray;
    [SerializeField]
    Text text;
    [SerializeField]
    PlayerData data;
    [System.Serializable]
    public class PlayerData
    {
        public string name;
        public int hp;
        public int exp;
        public GameObject gameObject;
        public float X;
        //  public float Y;
        //   public float Z;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //  text.text = data.name;
        //   name = data.name;
        data.hp = HP.manager.currentHealth;
        data.exp = exp.manager.score;
        if (check)
        {
           if (Input.GetKeyUp(KeyCode.T))
           {
            FileStream fs = new FileStream(Application.dataPath + "/save.txt",FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            // PlayerPrefs.SetFloat("X",transform.position.x);
            // PlayerPrefs.SetFloat("Y",transform.position.y);
            // PlayerPrefs.SetFloat("Z",transform.position.z);
            // PlayerPrefs.SetString("name", data.name);
            // PlayerPrefs.SetInt("level", data.level);
            // Debug.Log(transform.position.x);
            sw.WriteLine(data.name);
            sw.WriteLine(transform.position.x);
            sw.WriteLine(transform.position.y);
            sw.WriteLine(transform.position.z);
            sw.WriteLine(data.hp);
            sw.WriteLine(data.exp);
            sw.Close();
            fs.Close(); 

           }
        }
        
        if (Input.GetKeyUp(KeyCode.B))
        {
         /*   FileStream fs = new FileStream(Application.dataPath + "/save.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
           // data.name = sr.ReadLine();
            data.level = int.Parse(sr.ReadLine());
            //  data.name = PlayerPrefs.GetString("name");
            // data.level = PlayerPrefs.GetInt("level"); 
            gameObject.transform.position = new Vector3(float.Parse(sr.ReadLine()), float.Parse(sr.ReadLine()),float.Parse(sr.ReadLine()));
          //  gameObject.transform.position = new Vector3(PlayerPrefs.GetFloat("X"), PlayerPrefs.GetFloat("Y"), PlayerPrefs.GetFloat("Z"));
            // text.text = PlayerPrefs.GetString("name")*/
        }


    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "save")
        {
            check = true;
            myObjArray = other.gameObject;
            data.name = myObjArray.name;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "save")
        {
            check = false;
            myObjArray = default;
        }
    }
}

