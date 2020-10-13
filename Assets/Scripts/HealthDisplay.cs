using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    Text healthText;
    Player currentPlayer;

    private void Start()
    {
        healthText = GetComponent<Text>();
        currentPlayer = FindObjectOfType<Player>();
    }

    private void Update()
    {
        healthText.text = currentPlayer.GetHealth().ToString();
    }

}
