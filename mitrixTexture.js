var mitrix1 : Texture;
var mitrix2 : Texture;

private var toggle : boolean;
private var counter = 0;

// toggle == false;

InvokeRepeating("SwitchTexture", 1, 1);

function Update(){
}

function SwitchTexture(){
	counter++;
	Debug.Log(counter);
	if (counter % 2 == 0){
		renderer.material.mainTexture = mitrix1;	
		Debug.Log("divisible by 2");
	}
	else{
		renderer.material.mainTexture = mitrix2;
		Debug.Log("not divisible by 2");
	}
	
}