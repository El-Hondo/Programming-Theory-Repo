using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{

    float speed = 50;
    float activeTime = 5;
    float moveTime = 10;

    protected GameManager gameManager;

    Vector3 moveDirection;

    public float Speed { get => speed; set => speed = value; }
    public float ActiveTime { get => activeTime; set => activeTime = value; }
    public float MoveTime { get => moveTime; set => moveTime = value; }

    // Start is called before the first frame update
    protected virtual void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        GenerateRandomDireaction(); // new direction
        StartCoroutine(MovementChange());
    }

    // Update is called once per frame
    void Update()
    {
               transform.position += transform.forward * Time.deltaTime * Speed;
    }
   IEnumerator MovementChange()
    {
        yield return new WaitForSeconds(MoveTime);
        GenerateRandomDireaction();
        StartCoroutine(MovementChange());
    }
    private void Move()
    {
        
    }
    void GenerateRandomDireaction()
    {
        var euler = transform.eulerAngles;
        euler.y = Random.Range(0.0f, 360.0f);
        transform.eulerAngles = euler;
    }

    void reverseDirection()
    {
        var euler = transform.eulerAngles;
        euler.y = (euler.y + 180) % 360;
        transform.eulerAngles = euler; 
    }

    protected virtual void OnTriggerEnter(Collider other)
    {
        
     //   Debug.Log("Collision");
        if (other.gameObject.CompareTag("Boundary"))
        {
            reverseDirection();
        }
    }
}
