using UnityEngine;
using System.Collections;

public class FruitsCreator : MonoBehaviour {

    public GameObject[] Fruits;
    public Vector3[] FruitsPositions;


	void Start () {
	    foreach(Vector3 fruitPosition in FruitsPositions)
        {
            int fruitId = UnityEngine.Random.Range(0, Fruits.Length);
            Instantiate(Fruits[fruitId], fruitPosition, Quaternion.identity);
        }
	}
	
	
	void Update () {
	
	}
}
