using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class TimerController : MonoBehaviour
{
    private DateTime _startTime;
    private TextMeshProUGUI _textComponent;

    // Start is called before the first frame update
    void Start()
    {
        _startTime = DateTime.Now;
        _textComponent = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        _textComponent.text = (DateTime.Now - _startTime).ToString("g");
    }
}