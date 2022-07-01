using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MaxScoreDisplayController : MonoBehaviour
{
    public ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshProUGUI>().text = "Meilleur temps : " + scoreManager.MaxScore.ToString(ScoreManager.TimeSpanStringFormat);
    }
}