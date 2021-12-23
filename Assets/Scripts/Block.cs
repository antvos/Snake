using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int Block_HP;
    public TextMeshPro Block_Text;
    public Head Head;
    public Renderer rend;
    private void Update()
    {
        Block_Text.text = Block_HP.ToString();
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == "SnakeMain")
        {
            while (Block_HP != 0)
            { 
                if (Head.New_HP == 0)
                    break;
                else
                {
                    Head.New_HP--;
                    Block_HP--;
                        if (Block_HP == 0)
                        Destroy(gameObject);
                }
            }
        }
    }
    private void Start()
    {
        Block_HP = Random.Range(0, 20);
        if (Block_HP < 7 && Block_HP > 0)
        {
            rend.material.SetFloat("_Grad", 0.3f);
        }
        if (Block_HP > 7 && Block_HP < 14)
        {
            rend.material.SetFloat("_Grad", 0.12f);
        }
        else if (Block_HP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
