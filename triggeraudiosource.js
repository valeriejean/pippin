private var hasPlayed : boolean;
var Trigger : AudioClip;

function OnTriggerEnter (other : Collider){
	if (!hasPlayed){
		// if (other.GameObject.tag == "Player"){
			audio.Play();
		// }
	}
	hasPlayed = true;
}