using Android.Text.Style;
using Java.Util;
using static Android.Graphics.ColorSpace;
using static Android.Provider.ContactsContract.CommonDataKinds;

namespace MauiApp1;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		// DO NOT PUT ANYTHING HERE THAT INTERACTS WITH THE UI
		// UI NOT BUILT
		InitializeComponent(); // Builds the UI from XAML
		Title.Text = "Tengu"; 
		SubTitle.Text = "by Joel Fagin";


        Paragraph1.Text = "The clouds in the sky had blurred away but the samurai had his head bowed and did not notice. The air had changed, too,\r\nthe breeze shifting around to be borne from a new sea, but the samurai’s path was winding so the direction was lost on him.\r\nThe sun warmed slightly but his hat and cloak kept it from his skin and its shifting spectrum went unnoticed beneath the\r\nshadows of the trees.";

		Paragraph2.Text = "But when the sound of the path changed beneath the stilt-like soles of his geta sandals, then he raised his eyes and noticed\r\nthat the world had changed around him. He frowned as he saw the trees, oddly shaped to his eyes, smelt the new air, tainted\r\nwith alchemical fumes, and looked upon the gravel beneath his feet, now less of a worn route through a forest than a laid\r\npath, cared for and maintained.";

		Paragraph3.Text = "He looked back along the way he had come, eyes narrow. Then, he turned forwards again and continued walking, resting his\r\nhand on the hilt of his lone sword as he did so.\r\nNorth";

    }

}

