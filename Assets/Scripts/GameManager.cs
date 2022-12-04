using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //create an array of spawn points, assigned in inspector
     public Transform[] collectableSpawnPoints = new Transform[3];
     
       //create an array of collectables to choose from
          public GameObject[] items = new GameObject[2];
          
          // Keeps track of the items spawn index
          private int itemIndex = 0;
      
          // Use this for initialization
          void Start ()
          {
              
              itemIndex = Random.Range(0, items.Length);
              SpawnCollectables();
          }
          
          // Update is called once per frame
          void Update ()
          {
              
          }
      
         //selects spawn point
         public Transform GetCollectableSpawnPoint()
          {
              //randomly selects a point out of the array
           //   int index = Random.Range(0, collectableSpawnPoints.Length);
              //returns the selected point
             // return collectableSpawnPoints[index];
             
             itemIndex = itemIndex % items.Length;
             return collectableSpawnPoints[itemIndex++];
          }
      
          //selects object to spawn
          public GameObject GetCollectable()
          {
              //selects one of the items from the array
              int index = Random.Range(0, items.Length);
              //returns the object selected
              return items[index];
          }
      
          // spawns the random object on the random point
          private void SpawnCollectables()
          {
              /*
              //selects the spawn point
              Transform spawnPoint = GetCollectableSpawnPoint();
              //selects the object
              GameObject collectable = GetCollectable();
              //creates the object selected on the point selected
              GameObject c = Instantiate(collectable, spawnPoint.position, spawnPoint.rotation) as GameObject;
             //spawns the object
              return c;
               */
              
              // first pick what random collectable you want to spawn
              GameObject randomCollectable = items[Random.Range(0, items.Length)];
              
              // next iterate all the spawn points, and spawn that item on each of them
              foreach (Transform spawnPoint in collectableSpawnPoints)
              {
                Instantiate(randomCollectable, spawnPoint.position, spawnPoint.rotation);
              }
          }
          }
