# How to create a glass like Navigation Drawer in .NET MAUI

Syncfusion’s [.NET MAUI Navigation Drawer](https://www.syncfusion.com/maui-controls/maui-navigationdrawer) provides built-in support for a glass-like visual effect through the [EnableLiquidGlassEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_EnableLiquidGlassEffect) property.
To enable or disable the liquid glass effect on the NavigationDrawer, set the `EnableLiquidGlassEffect` property in NavigationDrawer:

* When EnableLiquidGlass = true, a subtle glass-like effect is applied to the Drawer, enhancing its modern aesthetic.
* When EnableLiquidGlass = false, the NavigationDrawer displays its default appearance.
 
> This feature is supported only on .NET 10, along with iOS 26 and macOS 26.

**XAML**
```
    <Grid>
        <Image Source="beach2.jpg" Aspect="AspectFill" />
        <navigationDrawer:SfNavigationDrawer x:Name="navigationDrawer" EnableLiquidGlassEffect="True">
            <navigationDrawer:SfNavigationDrawer.ContentView>
                <Grid RowDefinitions="80, *">
                    <core:SfGlassEffectView EffectType="Regular">
                        <Grid>
                            <Button Text="&#xe719;" Clicked="OnPrimaryDrawerToggled" FontFamily="MauiMaterialAssets" FontAttributes="Bold" FontSize="24" TextColor="Black" BackgroundColor="Transparent" HorizontalOptions="Start" Grid.Column="0" />
                        </Grid>
                    </core:SfGlassEffectView>
                    <Label Grid.Row="1" Text="Main Content" HorizontalOptions="Center" VerticalOptions="Center" HorizontalTextAlignment="Center" Margin="16" />
                </Grid>
            </navigationDrawer:SfNavigationDrawer.ContentView>

            <navigationDrawer:SfNavigationDrawer.DrawerSettings>
                <navigationDrawer:DrawerSettings x:Name="primaryDrawer" Position="Left" ContentBackground="Transparent" DrawerWidth="300" EnableSwipeGesture="True" Transition="SlideOnTop">
                    <navigationDrawer:DrawerSettings.DrawerContentView>
                        <ScrollView>
                            <VerticalStackLayout Padding="12" Spacing="2">
                                <Label Text="Mail" FontAttributes="Bold" FontSize="18" VerticalTextAlignment="Center" HorizontalTextAlignment="Center" Margin="12, 0" />
                                <Label Text="Inbox" Padding="12,14" VerticalTextAlignment="Center" FontSize="15" />
                                <Label Text="Drafts" Padding="12,14" VerticalTextAlignment="Center" FontSize="15" />
                                <Label Text="Sent" Padding="12,14" VerticalTextAlignment="Center" FontSize="15" />
                                <Label Text="Starred" Padding="12,14" VerticalTextAlignment="Center" FontSize="15" />
                                <Label Text="Spam" Padding="12,14" VerticalTextAlignment="Center" FontSize="15" />
                                <Label Text="Trash" Padding="12,14" VerticalTextAlignment="Center" FontSize="15" />
                            </VerticalStackLayout>
                        </ScrollView>
                    </navigationDrawer:DrawerSettings.DrawerContentView>
                </navigationDrawer:DrawerSettings>
            </navigationDrawer:SfNavigationDrawer.DrawerSettings>
        </navigationDrawer:SfNavigationDrawer>
    </Grid>

```

**C#**
```
SfNavigationDrawer navigationDrawer = new SfNavigationDrawer
{
    EnableLiquidGlassEffect = true
};  
```

**Output**
 
 ![glassdrawer-kb.gif](https://support.syncfusion.com/kb/agent/attachment/article/22333/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjU2Nzk4Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.Zgyg37g9ILilnnSNiD_ra6VIOJXTp0CK_M10X63rJ9A)
