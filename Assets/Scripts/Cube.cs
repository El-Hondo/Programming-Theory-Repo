using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Creature
{
    protected override void Start()
    {
        base.Start();
        StartCoroutine(Duplicate());
        Debug.Log("Start");
    }
    IEnumerator Duplicate()
    {
        yield return new WaitForSeconds(gameManager.DuplicateTime);
        gameManager.createCreature(transform, gameManager.Cube);
         StartCoroutine(Duplicate());
        Debug.Log("Duplicate");
    }
    
}
