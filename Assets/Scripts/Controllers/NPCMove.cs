using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMove: MonoBehaviour 
{
	[SerializeField]
	Transform _destination;

	UnityEngine.AI.NavMeshAgent _navMeshAgent;

	// Use this for initialization
	void Start () 
	{
		_navMeshAgent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();

		if (_navMeshAgent == null) {
			Debug.LogError ("nav mesh is not attached to" + gameObject.name);
		} 
		else 
		{
			SetDestination ();
		}
	}
	
	// Update is called once per frame
	private void SetDestination() 
	{
		if (_destination != null) 
		{
			Vector3 targetVector = _destination.transform.position;
			_navMeshAgent.SetDestination (targetVector);
		}
	}
}
