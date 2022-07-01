using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : ScriptableObject
{
    private float _maxScore, _currentScore;

    public float MaxScore => _maxScore;

    public float CurrentScore
    {
        get => _currentScore;
        set
        {
            _currentScore = value;
            if (value > _maxScore)
            {
                _maxScore = value;
            }
        }
    }
}