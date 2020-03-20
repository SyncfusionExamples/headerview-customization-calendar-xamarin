# How to customize the header view of Calendar in Xamarin.Forms (SfCalendar) ?

You can customize the header view by loading the content in HeaderView property of SfCalendar.

**XAML**

``` xml
<?xml version="1.0" encoding="UTF-8"?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms" 
xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml" 
xmlns:LocalNamespace="clr-namespace:GettingStartedKBSyncfusion"
xmlns:Syncfusion ="clr-namespace:Syncfusion.SfCalendar.XForms;assembly=Syncfusion.SfCalendar.XForms"
x:Class="GettingStartedKBSyncfusion.MainPage">
<ContentPage.Content>
<Syncfusion:SfCalendar x:Name="calendar">
    <Syncfusion:SfCalendar.HeaderView>
        <Grid BackgroundColor="#E0CCFF">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="*"/>
                <ColumnDefinition Width="*"/>
                <ColumnDefinition Width="*"/>
            </Grid.ColumnDefinitions>
            <Image Source="Left.png">
                    <Image.GestureRecognizers>
                    <TapGestureRecognizer Command="{Binding LeftCommand}" />
                </Image.GestureRecognizers>
                </Image>
            <Label Text="{Binding SelectedMonth}" FontSize="18" Grid.Column="1" VerticalOptions="Center" HorizontalOptions="Center" VerticalTextAlignment="Center" HorizontalTextAlignment="Center"/>
            <Image Source="Right.png" Grid.Column="2">
                    <Image.GestureRecognizers>
                    <TapGestureRecognizer Command="{Binding RightCommand}" />
                </Image.GestureRecognizers>
                </Image>
        </Grid>
    </Syncfusion:SfCalendar.HeaderView>
    </Syncfusion:SfCalendar>
</ContentPage.Content>
</ContentPage>
```
**Output**

![CustomHeaderView](https://github.com/SyncfusionExamples/headerview-customization-calendar-xamarin/blob/master/ScreenShots/CutomHeaderView.png)
