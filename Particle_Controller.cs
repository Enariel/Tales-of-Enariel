using System.Collections;
using System.Collections.Generic;
using Tales_Of_Enariel;
using UnityEngine;

public class Particle_Controller : MonoBehaviour
{
	public List<ParticleSystem> particleEmitters;

	//This is called before the first frame.
	private void Awake()
	{
		CacheParticleSystem();
	}

	private void OnTriggerEnter(Collider other)
	{
		//other is the game object this gameobject is colliding with

		//Deactivate the gameobject once it collides with something.
		//this.gameObject.SetActive(false);

		foreach (ParticleSystem system in particleEmitters)
		{
			ParticleSystem particle = system.GetComponent<ParticleSystem>();

			particle.Stop();
		}

		//Get rigidbody of particle emitter
		var rb = this.gameObject.GetComponent<Rigidbody>();

		Vector3 freezePos = new Vector3(transform.position.x, transform.position.y, transform.position.z);

		if (rb != null)
		{
			rb.useGravity = false;
			rb.isKinematic = true;

			this.gameObject.transform.position = freezePos;
		}
	}

	private void CacheParticleSystem()
	{
		//Get each subemitter particle system
		foreach (ParticleSystem system in gameObject.GetComponentsInChildren<ParticleSystem>())
		{
			//subEmitters?.Add(system);

			if (system != null)
			{
				particleEmitters.Add(system);
			}
		}
	}
}
