using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFruits : MonoBehaviour
{
    [SerializeField] private GameObject fruitPrefab;
    [SerializeField] private GameObject upperBound;
    [SerializeField] private GameObject bottonBound;
    [SerializeField] private GameObject leftBound;
    [SerializeField] private GameObject rightBound;
    [SerializeField] private int fruitCount;
    private List<GameObject> fruitList;
    void Start()
    {
        fruitList = new List<GameObject>();
        FruitPopulator();
        AssignPositions();
    }

    // Update is called once per frame

    private void FruitPopulator()
    {
        for (int i = 0; i<fruitCount;i++)
        {
            GameObject newFruit = Instantiate(fruitPrefab);
            newFruit.SetActive(false);
            fruitList.Add(newFruit);
        }
    }

    private void AssignPositions()
    {
        for (int i = 0; i < fruitList.Count; i++)
        {
            fruitList[i].transform.position = new Vector3(Random.Range(leftBound.transform.position.x,rightBound.transform.position.x),0,Random.Range(bottonBound.transform.position.z,upperBound.transform.position.x));
            fruitList[i].SetActive(true);
        }
    }
}
