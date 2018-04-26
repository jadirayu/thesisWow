﻿namespace TermControl
{
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;

    /// <summary>
    /// Interaction logic for KeyboardKeys.xaml
    /// </summary>
    public partial class KeyboardKeys : UserControl
    {
        //public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
        //    "Text",
        //    typeof(string),
        //    typeof(KeyboardKeys),
        //    new UIPropertyMetadata(null));

        public static readonly DependencyProperty TypingResultsProperty = DependencyProperty.Register(
            "TypingResults",
            typeof(string),
            typeof(KeyboardKeys),
            new UIPropertyMetadata(null));

        public static readonly DependencyProperty CommandProperty = DependencyProperty.Register(
            "Command",
            typeof(ICommand),
            typeof(KeyboardKeys));

        public KeyboardKeys()
        {
            this.InitializeComponent();
            this.DataContext = new TermControl.ViewModels.KeyboardKeysViewModel("");
        }

        //public string Text
        //{
        //    get { return (string)this.GetValue(TextProperty); }
        //    set { this.SetValue(TextProperty, value); }
        //}

        public string TypingResults
        {
            get { return (string)this.GetValue(TypingResultsProperty); }
            set { this.SetValue(TypingResultsProperty, value); }
        }

        public ICommand Command
        {
            get { return (ICommand)this.GetValue(CommandProperty); }
            set { this.SetValue(CommandProperty, value); }
        }

        //private void Button_Activated(object sender, Tobii.Interaction.Wpf.ActivationRoutedEventArgs e)
        //{

        //}


    }
}
