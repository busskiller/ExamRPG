using System;
using UnityEngine;
using System.Collections.Generic;

public class Enemy : MonoBehaviour
{


    public enum EnemySelection
    {
        dragon, monkey
    };

    public EnemySelection EnemyType;
    
    public GameObject EnemyAppearance;
    public GameObject Player;
    public int EnemyHealth;

    public int FireAttribute; //-1 is weak against, 0 is neutral, 1 is strong against
    public int IceAttribute; //-1 is weak against, 0 is neutral, 1 is strong against
    public int EarthAttribute; //-1 is weak against, 0 is neutral, 1 is strong against


    private void EnemySelectionFunc()
    {
        if (EnemyType == EnemySelection.dragon)
        {
            EnemyHealth = 251;

            //EnemySkills = is fecthed from a script called EnemySkills

             

            EnemyAppearance = Instantiate(Resources.Load("Category1/dragon"), this.transform.position, Quaternion.identity) as GameObject;
        }

        if (EnemyType == EnemySelection.monkey)
        {
            EnemyHealth = 123;

            //EnemySkills = is fecthed from a script called EnemySkills, which is found on the combat manager object in the combat state

            EnemyAppearance = Instantiate(Resources.Load("Category2/monkey"), this.transform.position, Quaternion.identity) as GameObject;

            
        }

    }





    // Use this for initialization
	void Start ()
	{
        Player = GameObject.FindGameObjectWithTag("Player");
	    EnemySelectionFunc();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
