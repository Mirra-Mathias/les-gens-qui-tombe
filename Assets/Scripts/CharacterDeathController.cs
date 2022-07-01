using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterDeathController : MonoBehaviour
{
    public ScoreManager scoreManager;
    
    private Rigidbody _rigidbody;
    private const int DeathYPosition = -40;
    
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (_rigidbody.position.y < DeathYPosition)
        {
            SceneManager.LoadScene("GameOver");
            scoreManager.Stop();
        }
    }
}