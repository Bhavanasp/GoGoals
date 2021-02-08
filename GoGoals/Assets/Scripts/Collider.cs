using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{

    public int maxHealth = 100;
	public int currentHealth;
	public HealthBar healthBar;

    public int minScore = 0;
	public int currentScore;
	public ScoreBar scoreBar;

    void TakeDamage(int damage)
	{
		currentHealth -= damage;
		healthBar.SetHealth(currentHealth);
	}

    void IncreaseScore(int score)
	{
		currentScore += score;
		scoreBar.SetScore(currentScore);
	}

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        currentScore = minScore;
        scoreBar.SetMinScore(minScore);   
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision coll){
        if(coll.gameObject.name=="rock(Clone)"){
            TakeDamage(20);
        }
        else if(coll.gameObject.name=="coin1(Clone)"){
            Destroy(coll.gameObject);
            IncreaseScore(5);
        }
        else if(coll.gameObject.name=="coin2(Clone)"){
            Destroy(coll.gameObject);
            IncreaseScore(5);
        }
        else if(coll.gameObject.name=="coin3(Clone)"){
            Destroy(coll.gameObject);
            IncreaseScore(5);
        }
        else if(coll.gameObject.name=="coin4(Clone)"){
            Destroy(coll.gameObject);
            IncreaseScore(5);
        }
        else if(coll.gameObject.name=="coin5(Clone)"){
            Destroy(coll.gameObject);
            IncreaseScore(5);
        }
    }
}
