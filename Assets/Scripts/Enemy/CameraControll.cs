using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    void Update()
    {
        this.transform.Rotate(Vector3.forward*20*Time.deltaTime);
    }
}
