using EducationCenter.Desktop.Windows.Students;
using EducationCenter.Domain.Entities;
using System;
using System.Windows;

namespace EducationCenter.Desktop;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void btnClose_Click(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void btnRestore_Click(object sender, RoutedEventArgs e)
    {
        if (WindowState == WindowState.Normal)
            WindowState = WindowState.Maximized;
        else
            WindowState = WindowState.Normal;
    }

    private void btnMinimize_Click(object sender, RoutedEventArgs e)
    {
        WindowState = WindowState.Minimized;
    }

    private void rdHome_Click(object sender, RoutedEventArgs e)
    {
        // PagesNavigation.Navigate(new HomePage());
        PagesNavigation.Navigate(new System.Uri("Pages/HomePage.xaml", UriKind.RelativeOrAbsolute));
    }

    private void rdPayment_Click(object sender, RoutedEventArgs e)
    {
        PagesNavigation.Navigate(new System.Uri("Pages/PaymentPage.xaml", UriKind.RelativeOrAbsolute));
    }

    private void rdCourses_Click(object sender, RoutedEventArgs e)
    {
        PagesNavigation.Navigate(new System.Uri("Pages/CoursesPage.xaml", UriKind.RelativeOrAbsolute));
    }

    private void rdTeachers_Click(object sender, RoutedEventArgs e)
    {
        PagesNavigation.Navigate(new System.Uri("Pages/TeachersPage.xaml", UriKind.RelativeOrAbsolute));

    }

    private void rdStudents_Click(object sender, RoutedEventArgs e)
    {
        PagesNavigation.Navigate(new System.Uri("Pages/StudentsPage.xaml", UriKind.RelativeOrAbsolute));
    }

    private void rdPayment_Click_1(object sender, RoutedEventArgs e)
    {
        PagesNavigation.Navigate(new System.Uri("Pages/PaymentsPage.xaml", UriKind.RelativeOrAbsolute));
    }

    private void rdSubjects_Click(object sender, RoutedEventArgs e)
    {
        PagesNavigation.Navigate(new System.Uri("Pages/SubjectsPage.xaml", UriKind.RelativeOrAbsolute));
    }

    private void rdPosition_Click(object sender, RoutedEventArgs e)
    {
        PagesNavigation.Navigate(new System.Uri("Pages/PositionsPage.xaml", UriKind.RelativeOrAbsolute));
    }

    private void rdSetting_Click(object sender, RoutedEventArgs e)
    {
        PagesNavigation.Navigate(new System.Uri("Pages/SettingsPage.xaml", UriKind.RelativeOrAbsolute));

    }
}
