using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    [SerializeField] private GameObject _citrouille;

    private int _score = 0;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Citrouille"))
        {
            citrouilleDropped();
        }
    }
    private void citrouilleDropped() {
        _score ++;
    }

}
