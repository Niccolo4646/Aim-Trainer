using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> Spheres = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    { 
        Instantiate(Spheres[Random.Range(0, Spheres.Count)]);
    }
}
