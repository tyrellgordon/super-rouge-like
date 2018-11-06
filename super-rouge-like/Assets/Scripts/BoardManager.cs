using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BoardManager : MonoBehaviour {

 	[System.Serializable]
	  public class Count{
		 public int minumum;
		 public int maximum;

		 public Count(int min, int max)
		 {
			 minumum = min;
			 maximum = max;

		 }

	}


		public int columns = 8;
		public int rows = 8;
		public Count wallCount = new Count (5,9);
		public Count foodCount = new Count (1,5);
		
		public GameObject exit;
		public GameObject[] floorTiles;
		public GameObject[] wallTiles;
		public GameObject[] foodTiles;
		public GameObject[] enemyTiles;
		public GameObject[] outerWallTiles;

		private Transform boardHolder;
		private List <Vector3> gridPositions = new List <Vector3>();



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
