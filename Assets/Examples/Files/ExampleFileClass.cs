using Adnc.Utility.Files;
using UnityEngine;

namespace Adnc.Utility.Examples {
	public class ExampleFileClass : MonoBehaviour {
		[FilePathAttribute(true, true, "json")] 
		public FilePath file;
		
		[FilePathAttribute(true)] 
		public FilePathFolder folder;

		void Start () {
			Debug.Log(file.FullPath);
			Debug.Log(folder.FullPath);

			Debug.Log(file.GetFullPath(false));
		}
	}
}

