var mitrix1 : Texture;
var mitrix2 : Texture;

private var counter = 0;

InvokeRepeating("SwitchTexture", 1, 1);

function Update(){
}

function SwitchTexture(){
	counter++;
	if (counter % 2 == 0){
		renderer.material.mainTexture = mitrix1;	
	}
	else{
		renderer.material.mainTexture = mitrix2;
	}
}