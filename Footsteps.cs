using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Footsteps : MonoBehaviour {
	AudioSource audioSource;
	public AudioClip[] footsteps;
//	public AudioClip[] footstepsgrass;
//	public AudioClip[] splashes;
	
//	public Transform whisperPrefab;
//	public Transform Grasstrigger;
	
//  private bool onGrass = false;
	
	CharacterMotor motor;
	
//	List<Collider> puddles = new List<Collider>();
	
	float footstepThreshold = 0.8f;
	Vector3 lastFootstepPosition;
	
//	float whisperThreshold = 1.0f;
//	Vector3 lastWhisperPosition;
//	bool whisperFlip = false;
	
	// Use this for initialization
	void Start () {
		audioSource = gameObject.AddComponent( "AudioSource" ) as AudioSource;
		lastFootstepPosition = transform.position;
//		lastWhisperPosition = transform.position;
		motor = GetComponent<CharacterMotor>();
	}
	
	// Update is called once per frame
	void Update () {
		if ( Vector3.Distance( lastFootstepPosition, transform.position ) > footstepThreshold ) {
//			if ( onGrass == true ) { 
//			audioSource.PlayOneShot( footstepsgrass[ Random.Range( 0, footstepsgrass.Length ) ] );
//			}
//			if ( onGrass == false ) {
				audioSource.PlayOneShot( footsteps[ Random.Range ( 0, footsteps.Length ) ] ); 
//			}
//			if ( puddles.Count > 0 ) {
//				audioSource.PlayOneShot( splashes[ Random.Range( 0, splashes.Length ) ] );
//			}
			lastFootstepPosition = transform.position;
		}
//		if ( whisperPrefab && motor.movement.velocity.magnitude > motor.movement.maxForwardSpeed - .15f &&
//			Vector3.Distance( lastWhisperPosition, transform.position ) > whisperThreshold ) {
			
//			Vector3 offset = Vector3.forward * 3.0f + Vector3.left * ( whisperFlip ? -2.0f : 2.0f );
//			Vector3 whisperPosition = transform.position + Quaternion.FromToRotation( Vector3.forward, motor.movement.velocity ) * offset;
//			Instantiate( whisperPrefab, whisperPosition, Quaternion.identity );
			
//			lastWhisperPosition = transform.position;
//			whisperFlip = !whisperFlip;
//		}	
	}
	
//	void OnTriggerEnter( Collider other ) {
//		if ( other.name.Contains( "fountaintrigger" ) ) {
//			puddles.Add( other );
//		}		
//		if (other.name.Contains ( "Grasstrigger" ) ) {
//			Debug.Log("inside");
//			onGrass = true;			
//		}
//	}
	
//	void OnTriggerExit( Collider other ) {
//		if ( other.name.Contains( "fountaintrigger" ) ) {			
//			puddles.Remove( other );			
//		}
//		if (other.name.Contains ( "Grasstrigger" ) ) {
//			onGrass = false;
//			Debug.Log("outside");
//		}	
//	  }
}
