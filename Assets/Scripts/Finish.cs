using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public Game Game;
    public Canvas CanvasWin;
    public AudioSource Finish_Sound;
    private void Start()
    {

        Finish_Sound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
       {
           if (other.CompareTag("SnakeMain"))
           {
            Finish_Sound.Play();
            Game.Stop();
            CanvasWin.gameObject.SetActive(true);
           }
       }
   /* private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == "SnakeMain")
        {
            Game.Stop();
            CanvasWin.gameObject.SetActive(true);
        }
    }*/

}
