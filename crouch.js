var toggle = 0;
var localScale : Vector3;

function Start () {
	Screen.showCursor = false; 
}
 
function Update () {
	if (toggle == 0){ 
		if (Input.GetKeyDown(KeyCode.LeftControl)) {    
			transform.localScale += Vector3(-0.2, -.8, -0.2);    
			toggle = 1;   
		}    
	return; 
	}
 
 
	if (toggle == 1){ 
		if(Input.GetKeyDown(KeyCode.LeftControl)) {   
			transform.position.y += 0.5;   
			transform.localScale += Vector3(.2, .8, .2);    
			toggle = 0;  
		}    
	return; 
	}
}