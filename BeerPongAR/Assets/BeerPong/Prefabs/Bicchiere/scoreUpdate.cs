using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreUpdate : MonoBehaviour
{
    Text score;
    int punti;

    private void Awake()
    {
        
    var scor = GameObject.FindGameObjectWithTag("Score");
        score = scor.GetComponent<Text>();
    }

    private void OnTriggerEnter(Collider other)
    {
        punti++;
        score.text = punti.ToString();
    }
}
