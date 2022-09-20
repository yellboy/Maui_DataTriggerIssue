# What is in this repo?
This repo is a reproduction repo for Microsoft MAUI issue #10124: https://github.com/dotnet/maui/issues/10124

## Where is the issue represented?
[MainPage](DataTriggerIssue/MainPage.xaml) references [LabelEntryRow](DataTriggerIssue/Views/LabelEntryRow.xaml) which has two bindable properties. It uses data trigger to change the color of the entry text to red when the IsValid property becomes false. [MainPage](DataTriggerIssue/MainPage.xaml) sets IsValid property to false once the Value property becomes greater than 5.

**Expected behavior**: Entry text color is green when IsValid is true and red when it is false.

**Actual behavior**: Entry text color is green initially, changes to red when IsValid becomes false, but it doesn't go back to green when IsValid becomes true again.