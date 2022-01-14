using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Enemy : MonoBehaviour
{
    public static Enemy instance;
    public int scoreToGive;
    public BoxCollider2D enemyPlace;
    
    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        RandomizePosition();
        scoreToGive = 1;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        GameManager.instance.addScore(scoreToGive);
        RandomizePosition();
    }

    private void RandomizePosition()
    {
        Bounds bounds = enemyPlace.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }
}
