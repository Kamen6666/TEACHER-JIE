using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMaterial : MonoBehaviour {


    GameObject tmpGameOne;

    GameObject tmpGameTwo;


    public Texture2D testTexture;

	// Use this for initialization
	void Start () {


     Object   tmpObj=   Resources.Load("Cube");

       tmpGameOne=    GameObject.Instantiate(tmpObj) as  GameObject;


       tmpGameTwo = GameObject.Instantiate(tmpObj) as GameObject;


      Vector2  tmpPos=   Camera.main.WorldToScreenPoint(tmpGameOne.transform.position);
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
           // tmpGameOne.GetComponent<MeshRenderer>().material.SetTexture("_MainTex", testTexture); ;

            tmpGameOne.GetComponent<MeshRenderer>().sharedMaterial.SetTexture("_MainTex",testTexture); ;

        }
		
	}
}
