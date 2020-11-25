using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CanvasScript : MonoBehaviour
{
	public GameObject P;
	PlayerController PC;
    // Start is called before the first frame update
    void Start()
    {
    	PC = P.GetComponent<PlayerController>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FeedFrog() 
    {
    	PC.Mode = "Feed";
    	//Debug.Log(PC.Hunger);
    }

    public void SocializeFrog() 
    {
        PC.Mode = "Social";
    }
}
