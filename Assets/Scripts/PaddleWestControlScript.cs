using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleWestControlScript : MonoBehaviour
{
    public float speed;
    public KeyCode forwardKey;
    public KeyCode backKey;
    public Rigidbody rig;
    public ScoreManagerScript manager;

    public void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        MoveObject(GetInput());
    }

    private Vector3 GetInput()
    {
        if (Input.GetKey(forwardKey))
        {
            if (GetComponent<Rigidbody>().position.y < 120f)
            {
                return Vector3.up * speed;
            }
        }
        else if (Input.GetKey(backKey))
        {
            if (GetComponent<Rigidbody>().position.y > 27f)
            {
                return Vector3.down * speed;
            }
        }

        return Vector3.zero;
    }

    private void MoveObject(Vector3 movement)
    {
        if (manager.WisLose == false)
        {
            transform.Translate(movement * Time.deltaTime);
        }
    }
}