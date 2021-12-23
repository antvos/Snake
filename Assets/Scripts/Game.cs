using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public List<GameObject> tailObjects = new List<GameObject>();
    public GameObject TailPrefab;
    public Tail Tail;
    public Head Head;

    public Canvas CanvasLose;
    public Text Number_LVL;

    private void Update()
    {
        if (tailObjects.Count == 1)
        {
            Stop();
            CanvasLose.gameObject.SetActive(true);
        }

        Tail.Target = tailObjects[0].gameObject;
    }
    private void Start()
    {
        int _currentLvl = SceneManager.GetActiveScene().buildIndex + 1;
        Number_LVL.text = "Level: " + _currentLvl.ToString();
    }

    public void HPAdd()
    {
        Tail.Target = tailObjects[0].gameObject;
        Vector3 newTailPos = tailObjects[0].transform.position;
        tailObjects.Insert(0, Instantiate(TailPrefab, newTailPos, Quaternion.identity));
    }
    public void HPSubtract()
    {
        Destroy(tailObjects[0]);
        tailObjects.RemoveAt(0);
    }

    public void Level_Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Level_Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Level_First()
    {
        SceneManager.LoadScene(0);
    }
    public void Stop()
    {
        Head.HeadRigidbody.velocity = Vector3.zero;
        Head.GetComponent<Head>().enabled = false;
    }
}
