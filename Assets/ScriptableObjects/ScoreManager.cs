using System;
using UnityEngine;

[CreateAssetMenu]
public class ScoreManager : ScriptableObject
{
    private DateTime _currentStartTime;
    private TimeSpan _maxScore, _currentScore;

    public DateTime CurrentStartTime => _currentStartTime;

    public TimeSpan MaxScore => _maxScore;

    public TimeSpan CurrentScore => _currentScore;

    public void Start()
    {
        _currentStartTime = DateTime.Now;
    }

    public void Stop()
    {
        _currentScore = DateTime.Now - _currentStartTime;
        if (_currentScore > _maxScore)
        {
            _maxScore = _currentScore;
        }
    }
}