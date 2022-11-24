using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auto : MonoBehaviour
{
    public string levelName;
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(levelName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
