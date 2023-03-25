using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class savedata
{
    public static bool check;
    public static bool savepoint;
    [SerializeField]
    static PlayerData data;
    [System.Serializable]
    public class PlayerData
    {
        public static string name;
        public static int hp;
        public static int exp;
        public static int A;
        public static int B;
        public static int C;
        public static int D;
        public static string QUEST;
        public static float X;
        public static float Y;
        public static float Z;
        public static float d1;
        public static float d2;
        public static float d3;
    }
    static savedata()
    {
        // data = JsonUtility.FromJson<PlayerData>(PlayerPrefs.GetString("jsondata")); 
    }

}
