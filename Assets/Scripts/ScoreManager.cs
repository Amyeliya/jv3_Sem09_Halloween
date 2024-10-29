using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    private int _score = 0;

    [SerializeField] private TextMeshProUGUI scoreText;

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

        scoreText.text = _score.ToString();
    }

}
