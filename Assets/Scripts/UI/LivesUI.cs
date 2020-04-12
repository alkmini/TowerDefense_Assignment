using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesUI : MonoBehaviour
{
    [SerializeField] PlayerStats playerStats;
    public Text livesText;

    private void Update()
    {
        livesText.text = playerStats.Lives.ToString() + " LIVES";
    }
}
