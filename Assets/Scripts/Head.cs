using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Head : MonoBehaviour
{
    public float Speed;
    public float Sensivity;
    public int New_HP;
    public int Current_HP;
    public TextMeshPro Snake_Text;
    public Rigidbody HeadRigidbody;
    private Vector3 _previosMousePosition;
    public Game Game;


    private void Start()
    {
        Current_HP = New_HP;
    }
    private void Update()
    {

        Snake_Text.text = New_HP.ToString();
        //движение
        HeadRigidbody.velocity = new Vector3(0, 0, -Speed) * Time.deltaTime;
        //transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        if (Input.GetMouseButton(0))
        {
            Vector3 delta = (Input.mousePosition - _previosMousePosition) /** Sensivity * Time.deltaTime*/;
            HeadRigidbody.velocity = new Vector3(-delta.x * Sensivity, 0, -Speed);
            // transform.Rotate(0, delta.x, 0);
        }
        else
        {
            // transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        _previosMousePosition = Input.mousePosition;

        //жизни
        if (New_HP > Current_HP)
        {
            int _addHP = New_HP - Current_HP;
            for (int i = 0; i < _addHP; i++)
            {
                Game.HPAdd();
            }
            Current_HP = New_HP;
        }
        if (New_HP < Current_HP)
        {
            int _minusHP = Current_HP - New_HP;
            for (int i = 0; i < _minusHP; i++)
            {
                Game.HPSubtract();
            }
            Current_HP = New_HP;
        }

    }

}
