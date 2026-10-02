using System.Collections.Generic;
using NUnit.Framework;
using Unity.Jobs;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyData[] data;
   
    private int currentHealth;
    private EnemyData dataRandom;

	void Start()
    {
       dataRandom = ControllerEnemy();

		currentHealth = dataRandom.maxHealth;
        GetComponent<SpriteRenderer>().color = dataRandom.color;
    }
    EnemyData ControllerEnemy()
    {
		int random = Random.Range(0, data.Length);
        return data[random];


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * dataRandom.speed * Time.deltaTime);
    }
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

}
