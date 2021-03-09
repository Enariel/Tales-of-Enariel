using System.Collections.Generic;
using Tales_Of_Enariel.StaffCasting;
using UnityEngine;

namespace Tales_Of_Enariel
{
    public class SpellcastBehaviour : StateMachineBehaviour
    {
		//Replace the next two variables with a SpellData class
		[SerializeField] private Spell spellData;
		[SerializeField] private Transform effectPoint;
		[SerializeField] private ParticleSystem mainEffect;
		// OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
		override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			//Get effect point
			Transform[] transforms = animator.gameObject.GetComponentsInChildren<Transform>();
			spellData = GameObject.FindGameObjectWithTag("GameController").GetComponent<Spellcaster>().CurrentSpell;
			foreach (Transform transform in transforms)
			{
				if (transform.gameObject.CompareTag("StaffEffect"))
				{
					effectPoint = transform;
					break;
				}
			}

			//Get main spell effect
			mainEffect = spellData.ElementData.MainParticleEffect;
			mainEffect = Instantiate(mainEffect, effectPoint.transform.position, Quaternion.identity, effectPoint);
			mainEffect.Play();
		}

		// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
		override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{

		}

		// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
		override public void OnStateExit(Animator animator, AnimatorStateInfo stateinfo, int layerindex)
		{
			mainEffect.Stop();
			animator.ResetTrigger("Attack");
		}
	}
}
