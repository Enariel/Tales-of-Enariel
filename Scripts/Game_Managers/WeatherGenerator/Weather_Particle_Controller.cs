using UnityEngine;
using System.Linq;
using System.Collections.Generic;

namespace Tales_Of_Enariel
{
    public class Weather_Particle_Controller : MonoBehaviour
    {
        private ParticleSystem rainParticles;
        private ParticleSystem snowParticles;
        private ParticleSystem hailParticles;
        private ParticleSystem fogParticles;
        private static string RAIN_TAG = "Rain";
        private static string SNOW_TAG = "Snow";
        private static string HAIL_TAG = "Hail";
        private static string FOG_TAG = "Fog";

        private WeatherType currentWeatherType;
        [SerializeField] WeatherType newWeatherType;

        private void Awake()
        {
            var rainObj = GameObject.FindGameObjectWithTag(RAIN_TAG);
            var snowObj = GameObject.FindGameObjectWithTag(SNOW_TAG);
            var hailObj = GameObject.FindGameObjectWithTag(HAIL_TAG);
            var fogObj = GameObject.FindGameObjectWithTag(FOG_TAG);
            rainParticles = rainObj.GetComponent<ParticleSystem>();
            snowParticles = snowObj.GetComponent<ParticleSystem>();
            hailParticles = hailObj.GetComponent<ParticleSystem>();
            fogParticles = fogObj.GetComponent<ParticleSystem>();
            currentWeatherType = WeatherType.Sunny;
            newWeatherType = WeatherType.Sunny;
        }

        // Update is called once per frame
        private void Update()
        {
            UpdateWeatherParticleSystems();
        }

        public void UpdateWeather(Weather weather)
        {
            //newWeatherType = weather.WeatherType;
        }

        private void UpdateWeatherParticleSystems()
        {
            if(currentWeatherType != newWeatherType)
            {
                switch (newWeatherType)
                {
                    case WeatherType.Rain:
                        fogParticles.Stop();
                        hailParticles.Stop();
                        snowParticles.Stop();
                        rainParticles.Play();
                        break;
                    case WeatherType.Snow:
                        fogParticles.Stop();
                        hailParticles.Stop();
                        rainParticles.Stop();
                        snowParticles.Play();
                        break;
                    case WeatherType.Hail:
                        fogParticles.Stop();
                        rainParticles.Stop();
                        snowParticles.Stop();
                        hailParticles.Play();
                        break;
                    case WeatherType.Foggy:
                        hailParticles.Stop();
                        rainParticles.Stop();
                        snowParticles.Stop();
                        fogParticles.Play();
                        break;
                    default:
                        fogParticles.Stop();
                        hailParticles.Stop();
                        rainParticles.Stop();
                        snowParticles.Stop();
                        break;
                }
                currentWeatherType = newWeatherType;
            }
        }
    }
}