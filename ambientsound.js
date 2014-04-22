var BarAudio : AudioSource;
var NightAudio : AudioSource;
var SunAudio : AudioSource;
var GirlsAudio : AudioSource;

function OnTriggerEnter (other : Collider){
	if (other.gameObject.tag == "Player") {
		BarAudio.Play();
		SunAudio.Play();
		NightAudio.Play();
		GirlsAudio.Play();
	}
}