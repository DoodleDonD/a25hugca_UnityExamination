using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChange : MonoBehaviour
{
	public InputActionAsset hugosPlayerAction;
	public Animator hugosAnimator;

	void Update()
	{
		if (hugosPlayerAction.FindAction("Move").IsPressed())
		{
			hugosAnimator.SetBool("Walking", true);
		}
		else
			hugosAnimator.SetBool("Walking", false);
	}
    
}
