using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoler : MonoBehaviour
{
    public ScoreCount score;
    public PlayerContoler playerScript;
    int scores = 1;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "collection")
        {
            score.myscore += 1;
            Debug.Log(other.gameObject.name);
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "otherColor")
        {
            playerScript.enabled = false;
        }
    }
}
