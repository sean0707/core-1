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
    public bool savepoint;
    public GameObject myObjArray;
    [SerializeField]
    PlayerData data;
    [System.Serializable]
    public class PlayerData
    {
        public string name;
        public int hp;
        public int exp;
        public int A;
        public int B;
        public int C;
        public int D;
        public string QUEST;
        public GameObject deta;
        public GameObject gameObject;
        public float d1;
        public float d2;
        public float d3;
        public float X;
        public float Y;
        public float Z;
    }
    // Start is called before the first frame update
    void Start()
    {
         // data = JsonUtility.FromJson<PlayerData>(PlayerPrefs.GetString("jsondata"));
    }

    // Update is called once per frame
    void Update()
    {
        //  text.text = data.name;

        if (savepoint)
        {
            data.hp = HP.manager.currentHealth;
            data.exp = exp.manager.score;
            data.A = NewBehaviourScript1.manager.a;
            data.B = NewBehaviourScript1.manager.b;
            data.C = NewBehaviourScript1.manager.c;
            data.D = NewBehaviourScript1.manager.d;
        /*    data.X = transform.position.x;
            data.Y = transform.position.y;
            data.Z = transform.position.z;*/
         /* data.d1 = data.deta.transform.position.x;
            data.d2 = data.deta.transform.position.y;
            data.d3 = data.deta.transform.position.z;*/
            if (Input.GetKeyUp(KeyCode.T))
           {
              //  PlayerPrefs.SetString("jsondata", JsonUtility.ToJson(data));
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
                    sw.WriteLine(data.A);
                    sw.WriteLine(data.B);
                    sw.WriteLine(data.C);
                    sw.WriteLine(data.D);
                    sw.WriteLine(data.deta.transform.position.x);
                    sw.WriteLine(data.deta.transform.position.y);
                    sw.WriteLine(data.deta.transform.position.z);
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
            savepoint = true;
            myObjArray = other.gameObject;
            data.name = myObjArray.name;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "save")
        {
            savepoint = false;
            myObjArray = default;
        }
    }
}

