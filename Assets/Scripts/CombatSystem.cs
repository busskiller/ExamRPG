using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;

public class CombatSystem : MonoBehaviour
{

    public List<GameObject> Enemies;
    public GameObject Player;


    private void Start ()
    {
        Enemies = new List<GameObject>();



        FetchEnemyData();
        FetchPlayerData();
    }
	
	// Update is called once per frame
	private void Update () {
	
	}





    private void FetchEnemyData()
    {
        Enemies.AddRange(GameObject.FindGameObjectsWithTag("Enemy"));
    }

    private void FetchPlayerData()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

}
