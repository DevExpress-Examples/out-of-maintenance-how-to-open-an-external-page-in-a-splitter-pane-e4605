@Code
    ViewBag.Title = "Menu"
End code

@Html.DevExpress().Splitter(
    Sub(settings)
            settings.Name = "Splitter"
            settings.FullscreenMode = True
            settings.Height = System.Web.UI.WebControls.Unit.Percentage(100)
            settings.Width = System.Web.UI.WebControls.Unit.Percentage(100)
            settings.AllowResize = True
            settings.Panes.Add(
                Sub(pane)
                        pane.AutoWidth = True
                        pane.SetContent(
                            Sub()
                                    Html.DevExpress().Menu(
                                        Sub(MenuSettings)
                                                MenuSettings.Name = "Menu"
                                                MenuSettings.Orientation = System.Web.UI.WebControls.Orientation.Vertical
                                                MenuSettings.Target = "NavigationIframe"

                                                MenuSettings.Items.Add("Content 1", Nothing, Nothing, Url.Action("Content1"))
                                                MenuSettings.Items.Add("Content 2", Nothing, Nothing, Url.Action("Content2"))
                
                                        End Sub).Render()
                            End Sub)
                End Sub)
            settings.Panes.Add(
                Sub(pane)
                        pane.ContentUrl = "about:blank"
                        pane.ContentUrlIFrameName = "NavigationIframe"
                End Sub)
    End Sub).GetHtml()