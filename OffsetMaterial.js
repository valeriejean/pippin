// Scroll main texture based on time
var scrollSpeed : float = 0.06;
function Update () {
	var offset : float = Time.time * scrollSpeed;
	renderer.material.SetTextureOffset ("_MainTex", Vector2(offset,0));
}