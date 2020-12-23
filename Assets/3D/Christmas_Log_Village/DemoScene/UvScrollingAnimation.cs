using UnityEngine;

public class UvScrollingAnimation : MonoBehaviour
{
	public Vector2 UvSpeed;
	
	void Update()
	{
		this.GetComponent<Renderer>().material.mainTextureOffset += UvSpeed;
	}
}
