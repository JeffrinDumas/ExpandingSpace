using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointTrigger : MonoBehaviour 
{
	public List<Transform> checkpointPositions = new List<Transform>();
	private int nextCheckpoint = 0;
	public GameObject checkPrefab;
	private Rigidbody rbody;

	void Start () {
      

        rbody = GetComponent<Rigidbody>();
        AddNextCheckpoint();
        
    }
	
	// Update is called once per frame

	void OnTriggerEnter(Collider col)
    {        
        if (col.gameObject.tag != "Checkpoint")
        {
            return;
        }
        Debug.Log(col.gameObject);
        Debug.Log(nextCheckpoint + ", " + checkpointPositions.Count);
        GameObject.Destroy(col.gameObject);

        if(nextCheckpoint < checkpointPositions.Count)
        {
            AddNextCheckpoint();
        }
            
        

    }
	public void AddNextCheckpoint(){
        
        GameObject checkpoint = Instantiate(checkPrefab, checkpointPositions[nextCheckpoint].position, checkpointPositions[nextCheckpoint].rotation);
        checkpoint.name = "checkpoint" + nextCheckpoint;
        nextCheckpoint++;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.up);
        }
    }
}


