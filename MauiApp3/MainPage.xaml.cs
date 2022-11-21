namespace MauiApp3;

public partial class MainPage : ContentPage
{
	List<user> list = new List<user>();
	class user
	{
		public string name;
		public string familia;
		public string otchestvo;
	}
	public MainPage()
	{
		InitializeComponent();
        user i = new user();
		i.name = NameF.Text;
		i.familia = FamiliaF.Text;
		i.otchestvo = OtchestvoF.Text;
		list.Add(i);
        user q = new user();
        q.name = NameS.Text;
        q.familia = FamiliaS.Text;
        q.otchestvo = OtchestvoS.Text;
        list.Add(q);
        user w = new user();
        w.name = NameT.Text;
        w.familia = FamiliaT.Text;
        w.otchestvo = OtchestvoT.Text;
        list.Add(w);
        user e = new user();
        e.name = NameFo.Text;
        e.familia = FamiliaFo.Text;
        e.otchestvo = OtchestvoFo.Text;
        list.Add(e);
    }

	private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
	{
		for (int i = 0; i < list.Count; i++) 
		{
            F.BackgroundColor = Color.FromRgb(1.0, 1.0, 1.0);
            S.BackgroundColor = Color.FromRgb(1.0, 1.0, 1.0);
            T.BackgroundColor = Color.FromRgb(1.0, 1.0, 1.0);
            Fo.BackgroundColor = Color.FromRgb(1.0, 1.0, 1.0);
            if (e.NewTextValue.Length - 1 > -1)
            {

            
            if (e.NewTextValue == list[i].name[e.NewTextValue.Length-1].ToString())
            {
                switch (i)
                {
                    case 0:
                        F.BackgroundColor = Color.FromRgb(0, 1.0, 0);
                        break;
                    case 1:
                        S.BackgroundColor = Color.FromRgb(0, 1.0, 0);
                        break;
                    case 2:
                        T.BackgroundColor = Color.FromRgb(0, 1.0, 0);
                        break;
                    case 3:
                        Fo.BackgroundColor = Color.FromRgb(0, 1.0, 0);
                        break;
                    }
            }
            }
            //else
            //{
            //   F.BackgroundColor = Color.FromRgb(1.0, 1.0, 1.0);
            //   S.BackgroundColor = Color.FromRgb(1.0, 1.0, 1.0);
            //   T.BackgroundColor = Color.FromRgb(1.0, 1.0, 1.0);
            //   Fo.BackgroundColor = Color.FromRgb(1.0, 1.0, 1.0);
            //}
        }
	}
	private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
	{
        SearchBar s = sender as SearchBar;
        for (int i = 0; i < list.Count; i++)
        {
            if (s.Text.ToString() == list[i].name.ToString())
            {
                switch (i)
                {
                    case 0:
                        F.BackgroundColor = Color.FromRgb(255/255.0, 202/255.0, 0);
                        S.BackgroundColor = Color.FromRgb(1.0, 1.0, 1.0);
                        T.BackgroundColor = Color.FromRgb(1.0, 1.0,1.0);
                        Fo.BackgroundColor = Color.FromRgb(1.0, 1.0, 1.0);
                        break;
                    case 1:
                        F.BackgroundColor = Color.FromRgb(1.0, 1.0, 1.0);
                        S.BackgroundColor = Color.FromRgb(255 / 255.0, 202 / 255.0, 0); ;
                        T.BackgroundColor = Color.FromRgb(1.0, 1.0,1.0);
                        Fo.BackgroundColor = Color.FromRgb(1.0, 1.0,1.0);
                        break;
                    case 2:
                        F.BackgroundColor = Color.FromRgb(1.0, 1.0,1.0);
                        S.BackgroundColor = Color.FromRgb(1.0, 1.0,1.0);
                        T.BackgroundColor = Color.FromRgb(255 / 255.0, 202 / 255.0, 0); ;
                        Fo.BackgroundColor = Color.FromRgb(1.0, 1.0,1.0);
                        break;
                    case 3:
                        F.BackgroundColor = Color.FromRgb(1.0, 1.0,1.0);
                        S.BackgroundColor = Color.FromRgb(1.0, 1.0,1.0);
                        T.BackgroundColor = Color.FromRgb(1.0, 1.0, 1.0);
                        Fo.BackgroundColor = Color.FromRgb(255/255.0, 202/255.0, 0);
                        break;
                }
            }
            else
            {
                F.BackgroundColor = Color.FromRgb(1.0, 1.0, 1.0);
                S.BackgroundColor = Color.FromRgb(1.0, 1.0, 1.0);
                T.BackgroundColor = Color.FromRgb(1.0, 1.0, 1.0);
                Fo.BackgroundColor = Color.FromRgb(1.0, 1.0, 1.0);
            }
            
        }
    }

	//private void SwipeView_SwipeStarted(object sender, SwipeStartedEventArgs e)
	//{

	//}

	//private void SwipeView_SwipeChanging(object sender, SwipeChangingEventArgs e)
	//{

	//}

	//private void SwipeView_SwipeEnded(object sender, SwipeEndedEventArgs e)
	//{

	//}

	//private void SwipeItem_Invoked(object sender, EventArgs e)
	//{

	//}
}

