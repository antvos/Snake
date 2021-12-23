using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    public float Smooth = 5.0f;
    public Vector3 Offset = new Vector3(0, 30, 7);
    void Update()
    {
        Vector3 position = new Vector3(0, Target.position.y + Offset.y, Target.position.z + Offset.z);
        transform.position = Vector3.Lerp(transform.position, position, Time.deltaTime * Smooth);
    }

}
