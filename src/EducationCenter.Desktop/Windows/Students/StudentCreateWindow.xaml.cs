using EducationCenter.Domain.Entities;
using EducationCenter.Service.Common.Helpers;
using EducationCenter.Service.Common.Validators;
using EducationCenter.Service.Interfaces.Services;
using EducationCenter.Service.Services.Students;
using System.Windows;

namespace EducationCenter.Desktop.Windows.Students
{
    /// <summary>
    /// Interaction logic for CreateStudentWindow.xaml
    /// </summary>
    public partial class StudentCreateWindow : Window
    {
        private readonly IStudentService _service;
        public StudentCreateWindow()
        {
            InitializeComponent();
            this._service = new StudentService();
        }

        private async void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            var student = new Student();

            var nameValidatorResult = NameValidator.IsValid(tbFirstName.Text);
            if (nameValidatorResult.IsSuccessful) student.FirstName = tbFirstName.Text;
            else
            {
                MessageBox.Show(nameValidatorResult.ErrorMessage, "First name is not valid",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            nameValidatorResult = NameValidator.IsValid(tbLastName.Text);
            if (nameValidatorResult.IsSuccessful) student.LastName = tbLastName.Text;
            else
            {
                MessageBox.Show(nameValidatorResult.ErrorMessage, "Last name is not valid",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            nameValidatorResult = NameValidator.IsValid(tbMiddleName.Text);
            if (nameValidatorResult.IsSuccessful) student.MiddleName = tbMiddleName.Text;
            else
            {
                MessageBox.Show(nameValidatorResult.ErrorMessage, "Middle name is not valid",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var phoneNumberValidatorResult = PhoneNumberValidator.IsValid(tbPhoneNumber.Text);
            if (phoneNumberValidatorResult.IsSuccessful || string.IsNullOrEmpty(tbPhoneNumber.Text)) 
                student.PhoneNumber = tbPhoneNumber.Text;
            else
            {
                MessageBox.Show(phoneNumberValidatorResult.ErrorMessage, "Phone number is not valid",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            student.BirthDate = DateHelper.GetStandartDateFromLocal(dpBirthDate.Text);

            var emailValidatorResult = EmailValidator.IsValid(tbEmail.Text);
            if (emailValidatorResult.IsSuccessful || string.IsNullOrEmpty(tbEmail.Text))
                student.Email = tbEmail.Text;
            else
            {
                MessageBox.Show(emailValidatorResult.ErrorMessage, "Email is not valid",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            student.Address = tbAddress.Text;
            student.Description = tbDescription.Text;
            var serviceResult = await _service.CreateAsync(student);
            if (serviceResult.IsSuccessful)
                MessageBox.Show("Student is created succesfully", "Successful",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            else MessageBox.Show(serviceResult.ErrorMessage, "There is an error in saving data",
                    MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
