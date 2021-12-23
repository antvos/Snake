using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tail : MonoBehaviour
{
    public float Speed;
    public Vector3 TargetVector;
    public Head mainSnake;
    public GameObject Target;

    private void Start()
    {
        mainSnake = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<Head>();
        Speed = mainSnake.Speed;
    }
    private void Update()
    {
        TargetVector = Target.transform.position;
        // transform.LookAt(TargetVector);
        transform.position = Vector3.Lerp(transform.position + new Vector3(0f, 0f, 0.01f), TargetVector, Time.deltaTime * Speed);
    }

}
