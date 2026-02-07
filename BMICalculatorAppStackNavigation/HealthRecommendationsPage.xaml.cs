namespace BMICalculatorAppStackNavigation;

public partial class HealthRecommendationsPage : ContentPage
{
    string recommendationsMessage;
    public HealthRecommendationsPage(string recommendationsMessage)
    {
        InitializeComponent();
        this.recommendationsMessage = recommendationsMessage;
        LabelRecommendationsValue.Text = recommendationsMessage;

    }

    private void BackToResultsButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void ReturnHomeButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }
}