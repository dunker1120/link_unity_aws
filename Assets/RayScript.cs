using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RayScript : MonoBehaviour
{
    [SerializeField]
    float shootRange = 1.2f;
    void Start()
    {
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        //レイを飛ばす
        if (Physics.Raycast(ray, shootRange))
        {
            // TODO S3からテキストを取得し、反映
        }
    }
}