using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenerateScene : MonoBehaviour {
	public GameObject[] availableRooms;
	public List<GameObject> currentRooms;
	private float screenWidthPoints;


	// Use this for initialization
	void Start () {
		float height = 2.0f * Camera.main.orthographicSize;
		screenWidthPoints = height * Camera.main.aspect;
	}
	
	void FixedUpdate () 
	{    
		GenerateRoomIfRequired();
	}

	void AddRoom(float farhtestRoomEndX) {
		int randomRoomIndex = Random.Range (0, availableRooms.Length);
		GameObject room = (GameObject)Instantiate (availableRooms [randomRoomIndex]);
		float roomwidth = room.transform.FindChild ("floor").localScale.x;
		float roomcenter = farhtestRoomEndX * roomwidth * 0.5f;
		room.transform.position = new Vector3 (roomcenter, 0, 0);
		currentRooms.Add(room);
	}

	void GenerateRoomIfRequired() {
		List<GameObject> roomsToRemove = new List<GameObject> ();
		bool addRooms = true;
		float playerX = transform.position.x;
		float removeRoomX = playerX - screenWidthPoints;        
		float addRoomX = playerX + screenWidthPoints;
		float farthestRoomEndX = 0;

		foreach(var room in currentRooms)
		{
			float roomWidth = room.transform.FindChild("floor").localScale.x;
			float roomStartX = room.transform.position.x - (roomWidth * 0.5f);
			float roomEndX = roomStartX + roomWidth; 

			if (roomStartX > addRoomX) {
				addRooms = false;
			}
				

			if (roomEndX < removeRoomX) {
				roomsToRemove.Add(room);
				farthestRoomEndX = Mathf.Max(farthestRoomEndX, roomEndX);
			}

		}
			
		foreach(var room in roomsToRemove)
		{
			currentRooms.Remove(room);
			Destroy(room);           
		}

		if (addRooms) {
			AddRoom(farthestRoomEndX);
		}
			
	}
}
