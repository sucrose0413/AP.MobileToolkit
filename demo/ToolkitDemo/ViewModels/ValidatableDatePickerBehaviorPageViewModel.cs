using AP.CrossPlatform.Validations;
using Prism.Logging;
using Prism.Navigation;
using Prism.Services;

namespace ToolkitDemo.ViewModels
{
    public class ValidatableDatePickerBehaviorPageViewModel : DemoPageViewModelBase
    {
        public IValidatableModel DatePickerValidatableModel { get; }
        public ValidatableDatePickerBehaviorPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService, ILogger logger, IValidatableModel validatableModel)
            : base(navigationService, pageDialogService, logger)
        {
            DatePickerValidatableModel = validatableModel;

            DatePickerValidatableModel.Errors.Add(new ValidationError() { Message = "Date entered is incorrect" });
            DatePickerValidatableModel.IsValid = false;
        }
    }
}
