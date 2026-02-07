namespace BMICalculatorAppStackNavigation;

public partial class BMICalculator : ContentPage
{
    string selectedGender = "Male";
    public BMICalculator()
    {
        InitializeComponent();
        
    }

    private void TapGestureRecognizer_MaleTapped(object sender, TappedEventArgs e)
    {
        selectedGender = "Male";
        FrameMale.BorderColor = Colors.LimeGreen;
        FrameFemale.BorderColor = Colors.Transparent;


    }

    private void TapGestureRecognizer_FemaleTapped(object sender, TappedEventArgs e)
    {
        selectedGender = "Female";
        FrameFemale.BorderColor = Colors.LimeGreen;
        FrameMale.BorderColor = Colors.Transparent;


    }

    private void Button_Clicked(object sender, EventArgs e)
    {

        Person person = GetBMIResults(Math.Round(HeightSlider.Value, MidpointRounding.AwayFromZero), Math.Round(WeightSlider.Value, MidpointRounding.AwayFromZero), selectedGender);

        Navigation.PushAsync(new BMIResultsPage(person));
    }

    private static Person GetBMIResults(double height, double weight, string gender)
    {
        double bmi = (weight / (height * height)) * 703;
        double roundedBmi = Math.Round(bmi, 1, MidpointRounding.AwayFromZero);
        if (gender == "Male")
        {
            if (bmi < 18.5)
            {
                return new Person(gender, roundedBmi, "Underweight");
            }
            else if (bmi >= 18.5 && bmi < 25.0)
            {
                return new Person(gender, roundedBmi, "Normal Weight");
            }
            else if (bmi >= 25.0 && bmi < 30.0)
            {
                return new Person(gender, roundedBmi, "Overweight");
            }
            else
            {
                return new Person(gender, roundedBmi, "Obesity");
            }
        }
        else
        {
            if (bmi < 18)
            {
                return new Person(gender, roundedBmi, "Underweight");
            }
            else if (bmi >= 18 && bmi < 24.0)
            {
                return new Person(gender, roundedBmi, "Normal Weight");
            }
            else if (bmi >= 24.0 && bmi < 29.0)
            {
                return new Person(gender, roundedBmi, "Overweight");
            }
            else
            {
                return new Person(gender, roundedBmi, "Obesity");
            }
        }
    }
}