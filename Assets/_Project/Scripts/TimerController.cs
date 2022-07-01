using System;
using TMPro;
using UnityEngine;

public class TimerController : MonoBehaviour
{
    public ScoreManager scoreManager;

    private TextMeshProUGUI _textComponent;

    // Start is called before the first frame update
    void Start()
    {
        _textComponent = GetComponent<TextMeshProUGUI>();
        scoreManager.Start();
    }

    // Update is called once per frame
    void Update()
    {
        _textComponent.text = (DateTime.Now - scoreManager.CurrentStartTime).ToString(ScoreManager.TimeSpanStringFormat);
    }
}