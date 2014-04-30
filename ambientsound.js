var BarAudio : AudioSource;
var NightAudio : AudioSource;
var SunAudio : AudioSource;
var GirlsAudio : AudioSource;
var RiosAudio : AudioSource;
var ErikaVal2Audio : AudioSource;

function OnTriggerEnter (other : Collider){
	if (other.gameObject.tag == "Player") {
		BarAudio.Play();
		SunAudio.Play();
		NightAudio.Play();
		GirlsAudio.Play();
		RiosAudio.Play();
		ErikaVal2Audio.Play();
	}
}