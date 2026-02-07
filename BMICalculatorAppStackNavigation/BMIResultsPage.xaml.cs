namespace BMICalculatorAppStackNavigation;

public partial class BMIResultsPage : ContentPage
{
    Person person;

    string UnderweightRecommendations = "- Increase calorie intake with nutrient-rich food(e.g., nuts, lean protein, whole grains).\n" +
                                        "- Incorporate strength training to build muscle mass.\n" +
                                        "- Consult a nutrintionist if needed.";
    string NormalWeightRecommendations = "- Maintain a balanced diet with proteins, healthy fats, and fiber.\n" +
                                         "- Stay physically active with at least 150 minutes of excerise per week.\n" +
                                         "- Keep regular check-ups to monitor overall health.";
    string OverweightRecommendations = "- Reduce processed foods and focus on portion control\n" +
                                       "- Engage in regular aerobic exercises (e.g., jogging, swimming) and strength training.\n" +
                                       "- Drink plenty of water and track your progress";
    string ObesityRecommendations = "- Consult a doctor for personalized guidance.\n" +
                                    "- Start with low-impact exercises (e.g., walking, cycling).\n" +
                                    "- Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes\n" +
                                    "- Avoid sugary drinks and main a consistent sleep schedule.";
    public BMIResultsPage(Person person)
    {
        InitializeComponent();
        this.person = person;
        LabelBMIValue.Text = person.BMI.ToString();
        LabelHealthStatusValue.Text = person.HealthStatus;
    }

    private void RecommendationsButton_Clicked(object sender, EventArgs e)
    {
        string HealthRecommendationMessage = $"Gender: {person.Gender}\n";

        if (person.HealthStatus == "Underweight")
        {
            HealthRecommendationMessage += UnderweightRecommendations;

        }
        else if (person.HealthStatus == "Normal Weight")
        {
            HealthRecommendationMessage += NormalWeightRecommendations;

        }
        else if (person.HealthStatus == "Overweight")
        {
            HealthRecommendationMessage += OverweightRecommendations;

        }
        else
        {
            HealthRecommendationMessage += ObesityRecommendations;

        }
        Navigation.PushAsync(new HealthRecommendationsPage(HealthRecommendationMessage));
    }

    private void ReturnHomeButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }
}