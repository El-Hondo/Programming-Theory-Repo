using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    float fieldSize = 50.0f;
    [SerializeField] GameObject sphere;
    [SerializeField] GameObject cube;
    [SerializeField] float speed = 50;
    [SerializeField] float activeTime = 5;
    [SerializeField] float lifeTime;
    [SerializeField] float moveTime = 10;
    [SerializeField] float duplicateTime = 0.1f;

    public GameObject Cube { get => cube; set => cube = value; }
    public GameObject Sphere { get => sphere; set => sphere = value; }
    public float DuplicateTime { get => duplicateTime; set => duplicateTime = value; }
    public float LifeTime { get => lifeTime; set => lifeTime = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void createCreature(Transform trans, GameObject obj)
    {
       Vector3 pos2= new Vector3(Random.Range(-fieldSize / 2, fieldSize / 2), 5, Random.Range(-fieldSize / 2, fieldSize / 2));
         Instantiate(obj, trans.position, new Quaternion());
        
        Debug.Log("Obejct created");
    }

}
