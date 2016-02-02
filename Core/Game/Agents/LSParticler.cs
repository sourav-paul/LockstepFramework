﻿using UnityEngine;
using System.Collections;

namespace Lockstep
{
	public class LSParticler : MonoBehaviour
	{
		LSAnimatorBase animator;

		void Awake ()
		{
			animator = GetComponent<LSAnimatorBase> ();
			animator.OnStatePlay += HandleOnStatePlay;
			animator.OnImpulsePlay += HandleOnImpulsePlay;
		}

		void HandleOnImpulsePlay (AnimImpulse obj)
		{
		}

		void HandleOnStatePlay (AnimState obj)
		{

		}
	}
}