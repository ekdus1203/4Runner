using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csRaycastBullet : MonoBehaviour
{
    public GameObject particle;
    private RaycastHit hits;
    private Ray shootRay;
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 20, Color.red);

        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position, transform.forward, 20.0f);

        if (Physics.Raycast(shootRay, out hits))
        {
            
            //Vector3 v3Pos = shootRay.GetPoint(hits.distance * distance);
            //lineRenderer.SetPosition(1, v3Pos);

            GameObject particleObj = Instantiate(particle) as GameObject;
            particleObj.transform.position = hits.point;

            Destroy(particleObj, 1.0f);
        }
        for (int i = 0; i < hits.Length; i++)
        {
            RaycastHit hit = hits[i];

            Debug.Log(hit.collider.gameObject.name);
        }



    }
}