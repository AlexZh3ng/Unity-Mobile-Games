using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundGenerator : MonoBehaviour {
    public Transform rhino; //drag in the rhino sprite
    public GameObject[] background; //put set size for the #of backgrounds in the game and drag in all background objects 
    private float backgroundSpace = 10f; // change this based on the size of background
    private float y = 10f; //same as backgroundSpace
    private int backgroundCount = 3; //edit for the amount of backgrounds on the screen we want
    /* private int randomBackground; 
    private List<int> RandomList = new List<int>();
    private int colorCount = 0; */
    // Use this for initialization
    private void Start () {
        /*randomBackground = 0; //start the game off with background 1
        for (int j = 1; j < 3; j++)
        {
            RandomList[j] = randomBackground;           
        } */
        for (int i = 1; i < 3; i++) //start the game off with 3 backgrounds *note that 1 additional background will be added with the destruction script
        {
            SpawnBackground();
        }
	}
	
	// Update is called once per frame
	private void Update () {
        if (rhino.position.y > (y - backgroundCount * backgroundSpace))
        {
            
            SpawnBackground();
            //AddToList();
        }
    }

    private void SpawnBackground(int prefabIndex = -1) 
    {
        GameObject go = Instantiate(background[Random.Range(0, 2)]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = new Vector3(0, 1 * y, 0);
        y += backgroundSpace;
    }
    
    /* private void AddToList()
    {
        if (colorCount > 3 && randomBackground == randomBackground - 1 && randomBackground == randomBackground - 2 && randomBackground == randomBackground - 3)
        {
            RandomList[colorCount] = Random.Range(0, 2);
        }
        else
        {
            RandomList[colorCount] = RandomList[colorCount - 1];
        }
        Debug.Log(RandomList[colorCount]);
    } 
    private int BackgroundColor()
    {
        colorCount++;
        return RandomList[colorCount];
    } */

}
