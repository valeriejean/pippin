private var hasPlayed : boolean;
var Trigger : AudioClip;

function OnTriggerEnter (other : Collider){
	if (!hasPlayed){
			audio.Play();
	}
	hasPlayed = true;
}