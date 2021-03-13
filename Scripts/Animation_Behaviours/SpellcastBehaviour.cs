using System.Collections.Generic;
using Tales_Of_Enariel.StaffCasting;
using UnityEngine;

namespace Tales_Of_Enariel
{
    public class SpellcastBehaviour : StateMachineBehaviour
    {
		//Notes
		//-Hands and legs point outward away from the body. Use handTransform.Up vector to move items in the direction of the arms
		//-Items in the hands need handTransform.Forward, this is for palm-based effects
		[SerializeField] protected ElementData elementData;
		[SerializeField] protected Transform weaponTransform;
		[SerializeField] protected Transform offHandTransform;
		[SerializeField] protected Transform rightHand;
		[SerializeField] protected ParticleSystem particleSystem;
		[SerializeField] protected ArmetureData armDat;
		// OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
		override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			//Get necessary information
			armDat = animator.GetComponent<ArmetureData>();
			elementData = animator.gameObject.GetComponent<ElementManager>().CurrentElementData;
			Transform[] transforms = armDat.RightHand.gameObject.GetComponentsInChildren<Transform>();
			foreach (Transform transform in transforms)
			{
				if (transform.gameObject.CompareTag("StaffEffect"))
				{
					weaponTransform = transform;
					break;
				}
			}

			//Get main spell effect
			if (elementData != null)
			{
				particleSystem = elementData.MainParticleEffect;
				particleSystem = Instantiate(particleSystem, weaponTransform.transform.position, Quaternion.identity, weaponTransform);
				particleSystem.Play();
			}
		}

		// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
		override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{

		}

		// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
		override public void OnStateExit(Animator animator, AnimatorStateInfo stateinfo, int layerindex)
		{
			particleSystem?.Stop();
			Destroy(particleSystem.gameObject, 5f);
		}
	}
}
