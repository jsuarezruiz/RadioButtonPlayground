using System;
using Xamarin.Forms;

namespace RadioButtonPlayground.Views
{
    public partial class RadioButtonView : ContentPage
    {
        public RadioButtonView()
        {
            InitializeComponent();
        }

        void OnRedRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            LogEvent("Red RadioButton CheckedChanged");
        }

        void OnRedRadioButtonClicked(object sender, EventArgs e)
        {
            LogEvent("Red RadioButton Clicked");
            UpdateStatus();
        }

        void OnBlueRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            LogEvent("Blue RadioButton CheckedChanged");
        }

        void OnBlueRadioButtonClicked(object sender, EventArgs e)
        {
            LogEvent("Blue RadioButton Clicked");
            UpdateStatus();
        }

        void OnGreenRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            LogEvent("Green RadioButton CheckedChanged");
        }

        void OnGreenRadioButtonClicked(object sender, EventArgs e)
        {
            LogEvent("Green RadioButton Clicked");
            UpdateStatus();
        }

        void LogEvent(string message)
        {
            InfoLabel.Text += $"{message} {Environment.NewLine}";
        }

        void UpdateStatus()
        {
            InfoLabel.Text += 
                $"RedRadioButton {RedRadioButton.IsChecked} {Environment.NewLine}" +
                $"BlueRadioButton {BlueRadioButton.IsChecked} {Environment.NewLine}" +
                $"GreenRadioButton {GreenRadioButton.IsChecked} {Environment.NewLine}";
        }
    }
}