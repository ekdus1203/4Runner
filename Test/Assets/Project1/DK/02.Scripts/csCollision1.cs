using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csCollision1 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("�浹");
    }

    /*    private void OnTriggerEnter(Collider other)
        {
            Debug.Log("�߻�");
        }*/

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("���̴���");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("�浹��");
    }
}
