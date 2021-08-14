using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csMoveCube : MonoBehaviour
{
    private float movspeed = 10f;
    private float jumpvalue = 5f;
    void Start()
    {
        
    }
    void Update()
    {
        //Ű���� �Է�
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        float j = Input.GetAxis("Jump");
        //�̵� �Ÿ� ����
        v= v * movspeed * Time.deltaTime;
        h=h * movspeed * Time.deltaTime;
        j = j * jumpvalue * Time.deltaTime;
        transform.Translate(Vector3.forward * v);
        transform.Translate(Vector3.right * h);
        transform.Translate(Vector3.up * j);
    }
}
