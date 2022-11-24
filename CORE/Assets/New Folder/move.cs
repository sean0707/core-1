using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public static move manager;
    public GameObject bgm;
    public CharacterController characterController;
    // Start is called before the first frame update
    public Rigidbody rb;
    public bool attack;
    public bool stay;
    public float j;


    // enum Mode
    //{ move, attack, tallk } 
    public float t = 1;
    public float speed = 2;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        rb = GetComponent<Rigidbody>();
        if (manager == null)
        {
            manager = this;
        }
    }
    void FixedUpdate()
    {
       // Mode mode = Mode.move;

        t = t - Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bgm, transform.position, Quaternion.identity);
            t = 1.1f;
            attack = true;
        }
        else if (t <= 0)
           {
          attack = false;
           }
          if (!attack)

     //   if (Input.GetKeyDown(KeyCode.Mouse0))
       // {
      //      mode = mode + 1;
      //  }
       // if (Input.GetKeyDown(KeyCode.F))
      //  {
      //      mode = mode + 2;
       // }
       // switch (mode)
       // {
        // case Mode.move:
        {
                if (Input.GetKey(KeyCode.D))
                {

                    Vector3 newPos = new Vector3();
                    newPos.x = gameObject.transform.position.x + speed;
                    newPos.y = gameObject.transform.position.y;
                    newPos.z = gameObject.transform.position.z;
                    gameObject.transform.SetPositionAndRotation(newPos, gameObject.transform.rotation);
                    transform.rotation = Quaternion.Euler(0, 90, 0);
                }
                else if (Input.GetKeyUp(KeyCode.D))
                {
                    transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                if (Input.GetKey(KeyCode.A))
                {//rb.velocity = Vector3.left * 500;
                    Vector3 newPos = new Vector3();
                    newPos.x = gameObject.transform.position.x - speed;
                    newPos.y = gameObject.transform.position.y;
                    newPos.z = gameObject.transform.position.z;
                    gameObject.transform.SetPositionAndRotation(newPos, gameObject.transform.rotation);
                    transform.rotation = Quaternion.Euler(0, -90, 0);
                }
                else if (Input.GetKeyUp(KeyCode.A))
                {
                    transform.rotation = Quaternion.Euler(0, 0, 0);
                }
        if (Input.GetKey(KeyCode.W))
        {
              //  characterController.SimpleMove(transform.forward*100);
            Vector3 newPos = new Vector3();
            newPos.x = gameObject.transform.position.x ;
            newPos.y = gameObject.transform.position.y;
            newPos.z = gameObject.transform.position.z+ speed;
            gameObject.transform.SetPositionAndRotation(newPos, gameObject.transform.rotation);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            //rb.velocity = Vector3.forward * 500;
        }
        if (Input.GetKey(KeyCode.S))
        {
              //  characterController.SimpleMove(transform.forward * -100);
                  Vector3 newPos = new Vector3();
                  newPos.x = gameObject.transform.position.x;
                  newPos.y = gameObject.transform.position.y;
                  newPos.z = gameObject.transform.position.z - speed;
                  gameObject.transform.SetPositionAndRotation(newPos, gameObject.transform.rotation);
                  transform.rotation = Quaternion.Euler(0, 180, 0);
                // rb.velocity = Vector3.back * 500;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            j = GetComponent<Transform>().position.y;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            //  characterController.SimpleMove(transform.forward*100);
            Vector3 newPos = new Vector3();
            newPos.x = gameObject.transform.position.x;
            newPos.y = gameObject.transform.position.y + 4;
            newPos.z = gameObject.transform.position.z;
            gameObject.transform.SetPositionAndRotation(newPos, gameObject.transform.rotation);
        }
        rb.AddForce(Vector3.down * 30000);
    }

       

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "LoadLevel")
        {
            Application.LoadLevel(other.name);

        }

    }
    public void getscore(float value)
    {
        t = value;
    }

    public void end(float value)
    {
        Application.LoadLevel("001");
        Destroy(this.gameObject);
    }
}
