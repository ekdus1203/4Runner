using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision �浹����!");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Collision �浹��!");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Collsion �浹��!");
    }
}
