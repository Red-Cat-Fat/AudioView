using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
	public Animator MyAnimator;
	private int _speed = 5;
    public void Update()
    {
	    if (Input.GetMouseButton(0))
	    {
			Debug.Log("Click");
			//MyAnimator.SetTrigger("SpaceClick");
			_speed++;
	    }

	    if (Input.GetMouseButton(1))
	    {
		    _speed--;
	    }

		MyAnimator?.SetInteger("SpeedMove", _speed);
    }
}
