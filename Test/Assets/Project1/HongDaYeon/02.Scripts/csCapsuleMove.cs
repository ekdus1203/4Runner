using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csCapsuleMove : MonoBehaviour
{
    public float speed = 10f;
    void Start()
    {
        
    }
    void Update()
    {
        //Ű
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float j = Input.GetAxis("Jump");

        //������
        h = h * speed * Time.deltaTime;
        v = v * speed * Time.deltaTime;
        j = j * speed * Time.deltaTime;

        //����
        transform.Translate(Vector3.right * h);
        transform.Translate(Vector3.forward * v);
        transform.Translate(Vector3.up * j);

    }
}
