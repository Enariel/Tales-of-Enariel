//copyright(c) FuchsFarbe
//Author: Oliver

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Tales_Of_Enariel
{
    public class Weather_Particle_Manager : MonoBehaviour
    {
		#region Variables
		//References
		[SerializeField] private GameObject weatherObj;
		[SerializeField] private GameObject snowObj;
		[SerializeField] private GameObject rainObj;
		private WeatherType currentWeatherType;
		[SerializeField] private WeatherType newWeatherType;
		#endregion

		#region Unity Methods
		private void Awake()
		{
			weatherObj = GameObject.FindGameObjectWithTag("WeatherSystem");
			rainObj = GameObject.FindGameObjectWithTag("Rain");
			snowObj = GameObject.FindGameObjectWithTag("Snow");

			newWeatherType = WeatherType.Sunny;
		}
		private void Update()
		{
			if (currentWeatherType != newWeatherType)
			{
				CheckWeatherChange();
				currentWeatherType = newWeatherType;
			}
		}
		#endregion

		void CheckWeatherChange()
		{
			var rainParticles = rainObj.GetComponent<ParticleSystem>();
			var snowParticles = snowObj.GetComponent<ParticleSystem>();

			switch (newWeatherType)
			{
				case WeatherType.Sunny:
					rainParticles?.Stop();
					snowParticles?.Stop();
					break;
				case WeatherType.Rain:
					rainParticles?.Play();
					snowParticles?.Stop();
					break;
				case WeatherType.Snow:
					rainParticles?.Stop();
					snowParticles?.Play();
					break;
			}
		}
	}
}
