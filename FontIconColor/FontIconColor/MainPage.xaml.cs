namespace FontIconColor
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }

    public class Tab1 : ContentPage
    {
        public Tab1()
        {
            IconImageSource = new FontImageSource
            {
                FontFamily = "Ionicons",
                Glyph = "\uf30c",
                Size = 15
            };
            Title = "Tab 1";
            var verticalStackLayout = new VerticalStackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
    {
        new Label
        {
            HorizontalOptions = LayoutOptions.Center,
            Text = "Tab 1"
        }
    }
            };
            Content = verticalStackLayout;
        }
    }

    public class Tab2 : ContentPage
    {
        public Tab2()
        {
            IconImageSource = new FontImageSource
            {
                FontFamily = "Ionicons",
                Glyph = "\uf30c",
                Color = Colors.Green, // Unicode character for the glyph
                Size = 15
            };
            Title = "Tab 2";
            var verticalStackLayout = new VerticalStackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
    {
        new Label
        {
            HorizontalOptions = LayoutOptions.Center,
            Text = "Tab 2"
        }
    }
            };
            Content = verticalStackLayout;
        }
    }

}
