using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Creature
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        StartCoroutine(Die());
        Debug.Log("Start");
    }
    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
        if (other.gameObject.CompareTag("Cube"))
        {
            gameManager.createCreature(other.transform, gameManager.Sphere);

            Destroy(other.gameObject);

        }
    }
    IEnumerator Die()
    {
        yield return new WaitForSeconds(gameManager.LifeTime);
        Destroy(gameObject);
    }


}
