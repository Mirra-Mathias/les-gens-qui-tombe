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

    public GameObject explosion;


    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        if (_rigidbody.position.y < DeathYPosition)
        {
            Instantiate(explosion, new Vector3(_rigidbody.position.x, _rigidbody.position.y, _rigidbody.position.z), Quaternion.identity);
            // new WaitForSeconds(6);
            StartCoroutine(ExecuteAfterTime(0.8f, () =>
            {            
                SceneManager.LoadScene("GameOver");
                scoreManager.Stop();
            }));
        }
    }

    private bool isCoroutineExecuting = false;
    IEnumerator ExecuteAfterTime(float time, Action task)
    {
        if (isCoroutineExecuting)
            yield break;
        isCoroutineExecuting = true;
        yield return new WaitForSeconds(time);
        task();
        isCoroutineExecuting = false;
    }

}