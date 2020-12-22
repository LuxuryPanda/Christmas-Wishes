using System;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace ChristmasLogvillage
{
	public class GameManagerChristmas : MonoBehaviour
	{
		#region ## Variables ##
		
		public static GameManagerChristmas _instance;

		public AudioClip MainMusic;
		public AudioSource source;

		#endregion
		
		#region ## Unity Methods ##
		
		private void Awake()
		{
			_instance = this;
		}

		// Use this for initialization
		private void Start()
		{
			DontDestroyOnLoad(transform.gameObject);
			
			SceneManager.LoadScene(1);
			SceneManager.sceneLoaded += OnSceneWasLoaded;
		}
		
		#endregion

		#region ## Utils ##
		
		private void OnSceneWasLoaded(Scene scene, LoadSceneMode mode)
		{
			if (scene.buildIndex == 1)
			{
				PlaySong();
			}
		}

		private void PlaySong()
		{
			if (source && MainMusic)
			{
				source.volume = 0.5f;
				source.clip = MainMusic;
				source.Play();
			}
		}
		
		#endregion
	}
}
