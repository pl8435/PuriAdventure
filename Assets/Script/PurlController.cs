using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurlController : MonoBehaviour
{
    private Transform tm;
    public float Speed = 1.0f;

    // Start is called before the first frame update
    void Awake()
    {
        tm = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        WASD_Controller();
    }

    void WASD_Controller()
    {
        int key = 0;
        if (Input.GetKey("w"))
        {
            tm.Translate(Vector3.up * Speed * Time.deltaTime);
        }
        else if (Input.GetKey("d"))
        {
            tm.Translate(Vector3.left * Speed * Time.deltaTime);
            key = 1;
        }
        else if (Input.GetKey("s"))
        {
            tm.Translate(Vector3.down * Speed * Time.deltaTime);
        }
        else if (Input.GetKey("a"))
        {
            tm.Translate(Vector3.right * Speed * Time.deltaTime);
            key = -1;
        }

        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) //산호초 먹으면 사라지는 거 53:24
    {
        if(collision.gameObject.CompareTag("CanBePickedUp"))
        {

            collision.gameObject.SetActive(false);
        }
    }
}
