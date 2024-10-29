using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    private int _score = 0;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Citrouille"))
        {
            citrouilleDropped();
            Destroy(other.gameObject);
        }
    }
    private void citrouilleDropped() {
        _score ++;
        Debug.Log("La variable int du score est à une valeur de : " + _score);

    }

}
