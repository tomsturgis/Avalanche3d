using UnityEngine;
using System.Collections;

public class MapGenerator : MonoBehaviour {

    public int width;
    public int height;
    public GameObject[] backgroundTiles;

    private Transform boardHolder;
    int[,] map;

    public int[,] GenerateMap()
    {

        map = new int[width, height];

        return map;
    }

    void LayoutTiles()
    {
        boardHolder = new GameObject("Board").transform;

        for (int x = 0; x < map.GetLength(0); x++)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                GameObject toInstantiate = backgroundTiles[Random.Range(0, backgroundTiles.Length)];
                GameObject instance = Instantiate(toInstantiate, new Vector3(x, y, 0f), Quaternion.identity) as GameObject;
                instance.transform.SetParent(boardHolder);
            }
        }
    }

	// Use this for initialization
	void Start () {
        map = GenerateMap();
        LayoutTiles();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
