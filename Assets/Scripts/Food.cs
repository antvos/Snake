using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Food : MonoBehaviour
{
    public int Food_HP;
    public TextMeshPro Food_Text;
    public AudioSource Food_Sound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {
            Food_Sound.Play();
            other.GetComponent<Head>().New_HP += Food_HP;
            Invoke("Dest", 0.15f);
        }
    }
    private void Start()
    {
        Food_HP = Random.Range(1, 7);
        Food_Text.text = Food_HP.ToString();
        Food_Sound = GetComponent<AudioSource>();
    }
    public void Dest()
    {
        Destroy(gameObject);
    }
}
