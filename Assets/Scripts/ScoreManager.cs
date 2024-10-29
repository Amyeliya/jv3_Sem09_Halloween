using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public int score = 0;
    
    private AudioSource audioSource;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("grabbable_object"))
        {
            citrouilleDropped();
            Destroy(other.gameObject);
        }
    }
    private void citrouilleDropped() {
        score ++;
        Debug.Log("La variable int du score est à une valeur de : " + score);
        audioSource.Play();
    }

}
