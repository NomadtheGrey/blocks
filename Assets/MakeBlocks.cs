using UnityEngine;
using System.Collections;

public class MakeBlocks : MonoBehaviour
{
    public GameObject mainBlock;
    public GameObject smallZone;
\
    // Use this for initialization
	void Start () {
	    for(int i = 0; i< 100; i++)
	    {	       
               StartCoroutine(GenerateBlocks(i,0));	            
	    }	    
	}

	 public static int layerCount = 0;
    IEnumerator GenerateBlocks(int x, int y)
    {       
    for (int k=0;k<100;k++)
	    {
            Instantiate(mainBlock, new Vector3(x, 0, k), Quaternion.identity);
	    }
        layerCount++;
        yield return layerCount;
    }
	// Update is called once per frame
	void Update () {
	
	}
}
