using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("�⵹ ���� ����");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("�浹 ���� ��");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("�浹 ���� ��");
    }



}
