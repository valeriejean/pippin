using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Footsteps : MonoBehaviour {
	AudioSource audioSource;
	public AudioClip[] footsteps;
	
	CharacterMotor motor;
	
	float footstepThreshold = 0.8f;
	Vector3 lastFootstepPosition;
	
	void Start () {
		audioSource = gameObject.AddComponent( "AudioSource" ) as AudioSource;
		lastFootstepPosition = transform.position;
		motor = GetComponent<CharacterMotor>();
	}
	
	void Update () {
		if ( Vector3.Distance( lastFootstepPosition, transform.position ) > footstepThreshold ) {
				audioSource.PlayOneShot( footsteps[ Random.Range ( 0, footsteps.Length ) ] ); 
			lastFootstepPosition = transform.position;
		}
	}
}
