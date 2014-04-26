// Smoothly open a door
var smooth = 2.0;
var DoorOpenAngle = 90.0;
var DoorSound : AudioClip;
private var open : boolean;
private var enter : boolean;
private var hasPlayed : boolean;
private var defaultRot : Vector3;
private var openRot : Vector3;

function Start(){
	defaultRot = transform.eulerAngles;
	openRot = new Vector3 (defaultRot.x, defaultRot.y + DoorOpenAngle, defaultRot.z);
	audio.clip = DoorSound;
}

function Update (){
	if(open){
		transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, openRot, Time.deltaTime * smooth);
				
		if (!hasPlayed){ 
			audio.Play();
		}
		hasPlayed = true;
		
	}else{
		transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, defaultRot, Time.deltaTime * smooth);
	}

	if(Input.GetKeyDown("f") && enter){
		Debug.Log("someone pushing door");
		open = !open;
	}
}

//Activate the Main function when player is near the door
function OnTriggerEnter (other : Collider){
	if (other.gameObject.tag == "Player") {
		enter = true;
	}
}

function OnTriggerExit (other : Collider){
	// door self-close not working?
	// transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, defaultRot, Time.deltaTime * smooth);

	if (other.gameObject.tag == "Player") {
		enter = false;
	}
	
}